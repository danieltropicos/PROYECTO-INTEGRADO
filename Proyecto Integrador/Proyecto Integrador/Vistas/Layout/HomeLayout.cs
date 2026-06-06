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
        private Button? _botonSidebarActivo;

        public HomeLayout(Usuario usuario)
        {
            InitializeComponent();
            _botonesMenu = [btnHome, button1, button2, button3, button4, button5];
            _usuario = usuario;

            var esAdmin = _usuario.Rol.Nombre == "Admin";
            panelMenuUsuarios.Visible = esAdmin;
            panelMenuMateriales.Visible = esAdmin;

            picLogoNavbar.ImageLocation = RecursosAplicacion.RutaLogoNavbar;
            picLogoCentro.ImageLocation = RecursosAplicacion.RutaLogoCentro;

            ConfigurarHoverSidebar();
            UiHelper.EstilizarBotonNavbar(btnMiPerfilNavbar);
            MostrarHome();
        }

        private void ConfigurarHoverSidebar()
        {
            UiHelper.ConfigurarHoverItemSidebar(panelMenuHome, btnHome, () => _botonSidebarActivo == btnHome);
            UiHelper.ConfigurarHoverItemSidebar(panelMenuUsuarios, button1, () => _botonSidebarActivo == button1);
            UiHelper.ConfigurarHoverItemSidebar(panelMenuClientes, button2, () => _botonSidebarActivo == button2);
            UiHelper.ConfigurarHoverItemSidebar(panelMenuCotizacion, button3, () => _botonSidebarActivo == button3);
            UiHelper.ConfigurarHoverItemSidebar(panelMenuMateriales, button4, () => _botonSidebarActivo == button4);
            UiHelper.ConfigurarHoverItemSidebar(panelMenuFacturas, button5, () => _botonSidebarActivo == button5);
            UiHelper.ConfigurarHoverItemSidebar(panelCerrarSesion, btnCerrarSesion, () => false);
        }

        private void MarcarActivoSidebar(Button? activo)
        {
            _botonSidebarActivo = activo;
            UiHelper.MarcarBotonSidebarActivo(activo, _botonesMenu);
        }

        private void MostrarHome()
        {
            foreach (Control c in panelContenido.Controls.OfType<UserControl>().ToList())
                panelContenido.Controls.Remove(c);

            panelBienvenida.Visible = true;
            panelBienvenida.BringToFront();

            MarcarActivoSidebar(btnHome);
        }

        private void AbrirVista(UserControl vista, Button? botonActivo)
        {
            foreach (Control c in panelContenido.Controls.OfType<UserControl>().ToList())
                panelContenido.Controls.Remove(c);

            panelBienvenida.Visible = false;
            vista.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(vista);
            vista.BringToFront();

            MarcarActivoSidebar(botonActivo);
        }

        private void btnHome_Click(object sender, EventArgs e) => MostrarHome();

        private void btnMiPerfilNavbar_Click(object sender, EventArgs e) =>
            AbrirVista(new PerfilUsuarioControl(_usuario), null);

        private void button1_Click(object sender, EventArgs e) =>
            AbrirVista(new RegistrarUsuariosControl(_usuario), button1);

        private void button2_Click(object sender, EventArgs e) =>
            AbrirVista(new ClienteControl(_usuario), button2);

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
