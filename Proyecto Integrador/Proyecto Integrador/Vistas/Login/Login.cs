using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Layout;
using Proyecto_Integrador.Vistas.Usuarios;

namespace Proyecto_Integrador.Vistas.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioControlador usuarioControlador = new();

            var usuario = usuarioControlador.ObtenerUsuarioPorNombreUsuario(txtUsuario.Text);
            if (usuario != null && usuario.ValidarContrasena(txtContraseña.Text))
            {
                HomeLayout homeLayout = new(usuario);
                homeLayout.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("-- Usuario o Contraseña Incorrecto --");
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            var registrarUsuariosForm = new RegistrarUsuarios();
            registrarUsuariosForm.FormClosed += (_, _) => Show();
            registrarUsuariosForm.Show();
            Hide();
        }

        private void picOjo_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar)
            {
                txtContraseña.UseSystemPasswordChar = false;
                picOjo.ImageLocation = "Recursos\\Imagenes\\ojoAbierto.jpg";
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                picOjo.ImageLocation = "Recursos\\Imagenes\\ojoCerrado.jpg";
            }
        }
    }
}
