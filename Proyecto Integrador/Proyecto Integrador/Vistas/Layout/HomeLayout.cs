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
            _botonesMenu = [button1, button2, button3, button4];
            AplicarEstilosLayout();
            
            _usuario = usuario;

            button1.Visible = _usuario.Rol.Nombre == "Admin";

            picLogoNavbar.ImageLocation = AppAssets.RutaLogoNavbar;
            picLogoCentro.ImageLocation = AppAssets.RutaLogoCentro;
        }

        private void AplicarEstilosLayout()
        {
            BackColor = AppTheme.FondoPrincipal;
            tableLayoutPanel1.BackColor = AppTheme.FondoPrincipal;

            panelNavbar.BackColor = AppTheme.AzulPrincipal;
            flowLayoutPanel1.BackColor = AppTheme.AzulPrincipal;
            panelContenido.BackColor = AppTheme.FondoPrincipal;
            panelBienvenida.BackColor = AppTheme.FondoPrincipal;

            lblTituloApp.ForeColor = AppTheme.Blanco;
            lblTituloApp.Font = AppTheme.FuenteTitulo;
            lblTituloApp.BackColor = Color.Transparent;

            foreach (var boton in _botonesMenu)
                UiHelper.EstilizarBotonSidebar(boton);
        }

        private void AbrirVista(UserControl vista, Button botonActivo)
        {
            foreach (Control c in panelContenido.Controls.OfType<UserControl>().ToList())
                panelContenido.Controls.Remove(c);

            panelBienvenida.Visible = false;
            vista.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(vista);
            vista.BringToFront();

            UiHelper.MarcarBotonSidebarActivo(botonActivo, _botonesMenu);
        }

        private void button1_Click(object sender, EventArgs e) =>
            AbrirVista(new RegistrarUsuariosControl(), button1);

        private void button2_Click(object sender, EventArgs e) =>
            AbrirVista(new ClienteControl(), button2);

        private void button3_Click(object sender, EventArgs e) =>
            AbrirVista(new CotizacionControl(), button3);

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void panelNavbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeLayout_Load(object sender, EventArgs e)
        {
            
        }
    }
}
