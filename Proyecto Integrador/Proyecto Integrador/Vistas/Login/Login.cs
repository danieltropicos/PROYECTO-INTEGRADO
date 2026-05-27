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
            Rol roltemporal = new Rol("Admin");
            Usuario usuarioTemporal = new Usuario(
                Guid.NewGuid(),
                "Admin",
                "Temporal",
                "admin@gmail.com",
                "3000000000",
                "Sin direccion",
                "admin",
                "1234",
                roltemporal,
                DateTime.Now
            );

            HomeLayout homeLayout = new(usuarioTemporal);
            homeLayout.Show();
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
