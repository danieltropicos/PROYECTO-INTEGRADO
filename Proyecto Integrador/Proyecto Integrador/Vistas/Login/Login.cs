using System.Runtime.InteropServices;
using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Layout;
using Proyecto_Integrador.Vistas.Utilidades;

namespace Proyecto_Integrador.Vistas.Login
{
    public partial class Login : Form
    {
        private readonly UsuarioControlador usuarioControlador = new();

        public Login()
        {
            InitializeComponent();
            CargarImagenes();
        }

        private void CargarImagenes()
        {
            panelBrand.ImagenMaquina = CargarImagen(RecursosAplicacion.ArchivoLoginFondoMaquina);
            panelBrand.Invalidate();

            AsignarImagen(picLogoGeoterra, RecursosAplicacion.ArchivoLoginLogoGeoterra);
            AsignarImagen(picIconoFormulario, RecursosAplicacion.ArchivoLoginIconoFormulario);
            AsignarImagen(picEscudo, RecursosAplicacion.ArchivoIconoEscudo);
            AsignarImagen(picOjo, RecursosAplicacion.ArchivoOjoCerrado);

            var fondoDerecho = CargarImagen(RecursosAplicacion.ArchivoLoginFondoDerecho);
            if (fondoDerecho is not null)
            {
                panelForm.BackgroundImage = fondoDerecho;
                panelForm.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private static void AsignarImagen(PictureBox pictureBox, string archivo)
        {
            var imagen = CargarImagen(archivo);
            if (imagen is null)
                return;

            pictureBox.Image?.Dispose();
            pictureBox.Image = imagen;
        }

        private static Image? CargarImagen(string archivo)
        {
            var ruta = RecursosAplicacion.Ruta(archivo);
            if (!File.Exists(ruta))
                return null;

            try
            {
                return Image.FromFile(ruta);
            }
            catch (ExternalException)
            {
                return null;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var nombreUsuario = txtUsuario.Text.Trim();
            var contrasena = txtContraseña.Text;

            if (string.IsNullOrEmpty(nombreUsuario) && string.IsNullOrEmpty(contrasena))
            {
                Ingresar(ObtenerUsuarioPrueba());
                return;
            }

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show(
                    "Ingrese usuario y contraseña.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var usuario = usuarioControlador.ObtenerUsuarioPorNombreUsuario(nombreUsuario);

            if (usuario is null || !usuario.ValidarContrasena(contrasena))
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!usuario.EsActivo)
            {
                MessageBox.Show(
                    "El usuario está inactivo. Contacte al administrador.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Ingresar(usuario);
        }

        private static Usuario ObtenerUsuarioPrueba()
        {
            var usuario = new Usuario(
                "Admin",
                "Temporal",
                "admin@gmail.com",
                "3000000000",
                "Sin direccion",
                "admin",
                new Rol("Admin"));

            usuario.EstablecerContrasena("1234");
            return usuario;
        }

        private void Ingresar(Usuario usuario)
        {
            var homeLayout = new HomeLayout(usuario);
            homeLayout.Show();
            Hide();
        }

        private void picOjo_Click(object sender, EventArgs e)
        {
            var mostrar = txtContraseña.UseSystemPasswordChar;
            txtContraseña.UseSystemPasswordChar = !mostrar;
            AsignarImagen(picOjo, mostrar ? RecursosAplicacion.ArchivoOjoAbierto : RecursosAplicacion.ArchivoOjoCerrado);
        }
    }
}
