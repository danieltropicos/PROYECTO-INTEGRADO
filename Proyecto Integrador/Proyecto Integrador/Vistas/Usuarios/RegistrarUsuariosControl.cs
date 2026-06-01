using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Vistas.Usuarios
{
    public partial class RegistrarUsuariosControl : UserControl
    {
        private readonly UsuarioControlador _controlador = new();
        private readonly Usuario _usuario;
        private List<Usuario> _usuarios = [];

        public RegistrarUsuariosControl(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            colCambiarEstado.Visible = EsAdmin;
            CargarUsuarios();
        }

        private bool EsAdmin => _usuario.Rol.Nombre == "Admin";

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            using var form = new UsuarioForm();
            if (form.ShowDialog(FindForm()) != DialogResult.OK || form.UsuarioCreado is null)
                return;

            _controlador.AgregarUsuario(form.UsuarioCreado);
            CargarUsuarios();
            MessageBox.Show("Usuario agregado exitosamente", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => CargarUsuarios();

        private void CargarUsuarios()
        {
            var filtro = txtBuscar.Text.Trim();
            _usuarios = _controlador.ObtenerUsuarios(
                string.IsNullOrEmpty(filtro) ? null : filtro);

            dgvUsuarios.Rows.Clear();
            foreach (var usuario in _usuarios)
            {
                dgvUsuarios.Rows.Add(
                    usuario.Id,
                    usuario.NombreCompleto,
                    usuario.NombreUsuario,
                    usuario.CorreoElectronico,
                    usuario.Telefono,
                    usuario.Rol.Nombre,
                    usuario.EsActivo ? "Activo" : "Inactivo",
                    usuario.EsActivo ? "Inactivar" : "Activar"
                );
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!EsAdmin) return;
            if (e.ColumnIndex != dgvUsuarios.Columns["colCambiarEstado"]!.Index) return;

            var usuario = _usuarios[e.RowIndex];
            var accion = usuario.EsActivo ? "inactivar" : "activar";

            var confirmar = MessageBox.Show(
                $"¿Desea {accion} a {usuario.NombreCompleto}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            usuario.CambiarEstado(!usuario.EsActivo);
            _controlador.ActualizarUsuario(usuario);
            CargarUsuarios();

            MessageBox.Show(
                $"Usuario {(usuario.EsActivo ? "activado" : "inactivado")}.",
                "Listo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
