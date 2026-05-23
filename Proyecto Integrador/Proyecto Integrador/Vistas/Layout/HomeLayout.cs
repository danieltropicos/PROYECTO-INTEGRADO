using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Utilidades;
using Proyecto_Integrador.Vistas.Clientes;
using Proyecto_Integrador.Vistas.Cotizaciones;
using Proyecto_Integrador.Vistas.Usuarios;

namespace Proyecto_Integrador.Vistas.Layout
{
    public partial class HomeLayout : Form
    {
        private readonly Button[] _botonesMenu;
        private readonly Usuario _usuario;

        public HomeLayout(Usuario usuario)
        {
            InitializeComponent();
            _botonesMenu = [btnHome, button1, button2, button3, button4];
            _usuario = usuario;

            button1.Visible = _usuario.Rol.Nombre == "Admin";

            picLogoNavbar.ImageLocation = AppAssets.RutaLogoNavbar;
            picLogoCentro.ImageLocation = AppAssets.RutaLogoCentro;
            picIconoCerrarSesion.ImageLocation = AppAssets.RutaIconoCerrarSesion;

            UiHelper.EstilizarBotonNavbar(btnMiPerfilNavbar);
            MostrarHome();
        }

        private void MostrarHome()
        {
            foreach (Control c in panelContenido.Controls.OfType<UserControl>().ToList())
                panelContenido.Controls.Remove(c);

            panelBienvenida.Visible = true;
            panelBienvenida.BringToFront();

            UiHelper.MarcarBotonSidebarActivo(btnHome, _botonesMenu);
        }

        private void AbrirVista(UserControl vista, Button? botonActivo)
        {
            foreach (Control c in panelContenido.Controls.OfType<UserControl>().ToList())
                panelContenido.Controls.Remove(c);

            panelBienvenida.Visible = false;
            vista.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(vista);
            vista.BringToFront();

            UiHelper.MarcarBotonSidebarActivo(botonActivo, _botonesMenu);
        }

        private void btnHome_Click(object sender, EventArgs e) => MostrarHome();

        private void btnMiPerfilNavbar_Click(object sender, EventArgs e) =>
            AbrirVista(new PerfilUsuarioControl(_usuario), null);

        private void button1_Click(object sender, EventArgs e) =>
            AbrirVista(new RegistrarUsuariosControl(), button1);

        private void button2_Click(object sender, EventArgs e) =>
            AbrirVista(new ClienteControl(), button2);

        private void button3_Click(object sender, EventArgs e) =>
            AbrirVista(new CotizacionControl(), button3);

        private void button4_Click(object sender, EventArgs e) =>
            AbrirVista(new MaterialControl(), button4);

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var login = new Login.Login();
            login.Show();
            Close();
        }
    }
}
