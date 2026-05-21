using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Vistas.Usuarios
{
    public partial class UsuarioForm : Form
    {
        private readonly RolControlador _rolControlador = new();

        public Usuario? UsuarioCreado { get; private set; }

        public UsuarioForm()
        {
            InitializeComponent();
            comboBoxRol.DisplayMember = nameof(Rol.Nombre);
            comboBoxRol.DataSource = _rolControlador.ObtenerRoles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                comboBoxRol.SelectedItem is not Rol rolSeleccionado)
            {
                MessageBox.Show("Complete los campos obligatorios.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsuarioCreado = new Usuario(
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtTelefono.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtUsuario.Text.Trim(),
                txtContrasena.Text,
                rolSeleccionado);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void picOjo_Click(object sender, EventArgs e)
        {
            if (txtContrasena.UseSystemPasswordChar)
            {
                txtContrasena.UseSystemPasswordChar = false;
                picOjo.ImageLocation = "Recursos\\Imagenes\\ojoAbierto.jpg";
            }
            else
            {
                txtContrasena.UseSystemPasswordChar = true;
                picOjo.ImageLocation = "Recursos\\Imagenes\\ojoCerrado.jpg";
            }
        }
    }
}
