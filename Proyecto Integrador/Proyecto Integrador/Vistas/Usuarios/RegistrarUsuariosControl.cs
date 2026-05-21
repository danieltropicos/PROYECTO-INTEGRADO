using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Vistas.Usuarios
{
    public partial class RegistrarUsuariosControl : UserControl
    {
        private readonly UsuarioControlador _controlador = new();

        public RegistrarUsuariosControl()
        {
            InitializeComponent();
            CargarUsuarios();
        }

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
            var usuarios = _controlador.ObtenerUsuarios(
                string.IsNullOrEmpty(filtro) ? null : filtro);

            dgvUsuarios.Rows.Clear();
            foreach (var usuario in usuarios)
            {
                dgvUsuarios.Rows.Add(
                    usuario.NombreCompleto,
                    usuario.NombreUsuario,
                    usuario.CorreoElectronico,
                    usuario.Telefono,
                    usuario.Rol.Nombre,
                    usuario.EsActivo);
            }
        }
    }
}
