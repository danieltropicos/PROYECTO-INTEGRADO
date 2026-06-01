using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Clientes;
using Proyecto_Integrador.Vistas.Cotizaciones;
using Proyecto_Integrador.Vistas.Facturas;
using Proyecto_Integrador.Vistas.Usuarios;
using Proyecto_Integrador.Vistas.Utilidades;

namespace Proyecto_Integrador.Vistas.Layout
{
    public partial class HomeLayout : Form
    {
        private readonly Button[] _botonesMenu;
        private readonly Usuario _usuario;

        public HomeLayout(Usuario usuario)
        {
            InitializeComponent();
            _botonesMenu = [btnHome, button1, button2, button3, button4, button5];
            _usuario = usuario;

            button1.Visible = _usuario.Rol.Nombre == "Admin";
            button4.Visible = _usuario.Rol.Nombre == "Admin";

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
            AbrirVista(new RegistrarUsuariosControl(_usuario), button1);

        private void button2_Click(object sender, EventArgs e) =>
            AbrirVista(new ClienteControl(), button2);

        private void button3_Click(object sender, EventArgs e) =>
            AbrirListaCotizaciones();

        private void button4_Click(object sender, EventArgs e) =>
            AbrirVista(new MaterialControl(), button4);

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var login = new Login.Login();
            login.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e) =>
            AbrirVista(new FacturaControl(_usuario), button5);

        private void AbrirListaCotizaciones()
        {
            var lista = new ListaCotizacionControl(_usuario);
            lista.CrearCotizacionClick += (_, _) => AbrirCotizacionControl();
            AbrirVista(lista, button3);
        }

        private void AbrirCotizacionControl()
        {
            var cotizacion = new CotizacionControl(_usuario);
            cotizacion.CotizacionGuardada += (_, _) => AbrirListaCotizaciones();
            AbrirVista(cotizacion, button3);
        }
    }
}
