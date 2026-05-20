using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Vistas.Usuarios
{
    public partial class RegistrarUsuarios : Form
    {
        private readonly UsuarioControlador _controladorUsuario = new();

        public RegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Rol nuevorol = new("Usuario");
            Usuario usuarionuevo = new(
                txtNombreUsu.Text,
                txtApellidoUsu.Text,
                txtCorreoUsu.Text,
                txtTelefonoUsu.Text,
                txtDireccionUsu.Text,
                txtNombreUsuarioUsu.Text,
                txtContrasenaUsu.Text,
                nuevorol,
                true);
            _controladorUsuario.AgregarUsuario(usuarionuevo);
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => Limpiar();

        private void lnkVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Close();

        private void picOjo_Click(object sender, EventArgs e)
        {
            if (txtContrasenaUsu.UseSystemPasswordChar)
            {
                txtContrasenaUsu.UseSystemPasswordChar = false;
                picOjo.ImageLocation = "Recursos\\Imagenes\\ojoAbierto.jpg";
            }
            else
            {
                txtContrasenaUsu.UseSystemPasswordChar = true;
                picOjo.ImageLocation = "Recursos\\Imagenes\\ojoCerrado.jpg";
            }
        }

        private void Limpiar()
        {
            txtNombreUsu.Clear();
            txtApellidoUsu.Clear();
            txtCorreoUsu.Clear();
            txtTelefonoUsu.Clear();
            txtDireccionUsu.Clear();
            txtNombreUsuarioUsu.Clear();
            txtContrasenaUsu.Clear();
        }
    }
}
