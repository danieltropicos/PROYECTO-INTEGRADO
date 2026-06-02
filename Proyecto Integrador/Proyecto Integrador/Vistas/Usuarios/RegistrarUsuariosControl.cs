using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Utilidades;

namespace Proyecto_Integrador.Vistas.Usuarios
{
    public partial class RegistrarUsuariosControl : UserControl
    {
        private readonly UsuarioControlador _controlador = new();
        private readonly Usuario _usuario;
        private readonly ToolTip _toolTip = new();
        private List<Usuario> _usuarios = [];

        public RegistrarUsuariosControl(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            UiHelper.ConfigurarColumnasGrid(dgvUsuarios, colIconoEditar, colIconoEstado);
            colIconoEstado.Visible = EsAdmin;
            UiHelper.AjustarAnchosColumnas(dgvUsuarios, colIconoEditar, colIconoEstado);
            CargarUsuarios();
        }

        private bool EsAdmin => _usuario.Rol.Nombre == "Admin";

        private void btnNuevoUsuario_Click(object sender, EventArgs e) =>
            AbrirFormularioUsuario();

        private void AbrirFormularioUsuario(Usuario? usuario = null)
        {
            var esEditar = usuario is not null;
            using var form = esEditar ? new UsuarioForm(usuario!) : new UsuarioForm();

            if (form.ShowDialog(FindForm()) != DialogResult.OK || form.Entidad is null)
                return;

            if (esEditar)
            {
                var actualizado = form.Entidad;
                actualizado.CambiarEstado(usuario!.EsActivo);
                _controlador.ActualizarUsuario(usuario.Id, actualizado, form.ContrasenaPlana);
                MessageBox.Show("Usuario actualizado exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _controlador.AgregarUsuario(form.Entidad);
                MessageBox.Show("Usuario agregado exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CargarUsuarios();
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
                var indice = dgvUsuarios.Rows.Add(
                    usuario.Id,
                    usuario.NombreCompleto,
                    usuario.NombreUsuario,
                    usuario.CorreoElectronico,
                    usuario.Telefono,
                    usuario.Rol.Nombre,
                    usuario.EsActivo ? "Activo" : "Inactivo");

                dgvUsuarios.Rows[indice].Cells[colIconoEditar.Index].Value = IconosAcciones.Editar;
                dgvUsuarios.Rows[indice].Cells[colIconoEstado.Index].Value =
                    usuario.EsActivo ? IconosAcciones.Inactivar : IconosAcciones.Activar;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var usuario = _usuarios[e.RowIndex];

            if (e.ColumnIndex == colIconoEditar.Index)
            {
                AbrirFormularioUsuario(usuario);
                return;
            }

            if (!EsAdmin || e.ColumnIndex != colIconoEstado.Index) return;

            var accion = usuario.EsActivo ? "inactivar" : "activar";
            var confirmar = MessageBox.Show(
                $"¿Desea {accion} a {usuario.NombreCompleto}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            usuario.CambiarEstado(!usuario.EsActivo);
            _controlador.ActualizarUsuario(usuario.Id, usuario);
            CargarUsuarios();

            MessageBox.Show(
                $"Usuario {(usuario.EsActivo ? "activado" : "inactivado")}.",
                "Listo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void dgvUsuarios_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ayuda = "";
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == colIconoEditar.Index) ayuda = "Editar usuario";
                else if (e.ColumnIndex == colIconoEstado.Index) ayuda = "Activar o inactivar";
            }

            _toolTip.SetToolTip(dgvUsuarios, ayuda);
            dgvUsuarios.Cursor = ayuda.Length > 0 ? Cursors.Hand : Cursors.Default;
        }
    }
}
