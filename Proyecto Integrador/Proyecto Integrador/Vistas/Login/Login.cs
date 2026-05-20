using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Layout;
using Proyecto_Integrador.Vistas.Usuarios;
using System.Security.Cryptography;
using System.Text;

namespace Proyecto_Integrador.Vistas.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private static string HashContrasena(string contrasena)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(contrasena);
            byte[] hash = sha256.ComputeHash(bytes);

            StringBuilder sb = new();
            foreach (byte b in hash)
                sb.Append(b.ToString("x2"));

            return sb.ToString();
        }

        private void Limpiar()
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioControlador usuarioControlador = new();
            int bandera = 0;
            foreach (var usuario in usuarioControlador.ObtenerUsuarios())
            {
                if (usuario.NombreUsuario == txtUsuario.Text && usuario.ContrasenaEncriptada == HashContrasena(txtContraseña.Text))
                {
                    MessageBox.Show("-- Bienvenido " + usuario.NombreUsuario + ". --");
                    HomeLayout homeLayout = new(usuario);
                    homeLayout.Show();
                    Hide();
                    bandera++;
                }
            }
            if (bandera == 0)
            {
                MessageBox.Show("-- Usuario o Contraseña Incorrecto --");
                Limpiar();
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
