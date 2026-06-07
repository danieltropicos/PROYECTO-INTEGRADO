using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Clientes;
using Proyecto_Integrador.Vistas.Cotizaciones;
using Proyecto_Integrador.Vistas.Facturas;
using Proyecto_Integrador.Vistas.Usuarios;
using Proyecto_Integrador.Vistas.Utilidades;

namespace Proyecto_Integrador.Vistas.Layout;

public partial class HomeLayout : Form
{
    private static HomeLayout? _actual;
    private readonly Button[] _botonesMenu;
    private readonly Usuario _usuario;
    private Button? _botonSidebarActivo;

    public HomeLayout(Usuario usuario)

    {
        InitializeComponent();
        _actual = this;
        _botonesMenu = [btnHome, button1, button2, button3, button4, button5];
        _usuario = usuario;

        var esAdmin = _usuario.Rol.Nombre == "Admin";
        panelMenuUsuarios.Visible = esAdmin;
        panelMenuMateriales.Visible = esAdmin;

        picLogoNavbar.ImageLocation = RecursosAplicacion.RutaLogoNavbar;
        ConfigurarHoverSidebar();
        Estilos.EstilizarBotonNavbar(btnMiPerfilNavbar);
        AbrirVista(new HomeControl(_usuario), btnHome);
    }

    public static void AbrirVista(UserControl vista, Button? botonActivo = null) =>
        _actual?.MostrarVista(vista, botonActivo);


    private void MostrarVista(UserControl vista, Button? botonActivo)

    {
        foreach (Control c in panelContenido.Controls.OfType<UserControl>().ToList())
            panelContenido.Controls.Remove(c);

        vista.Dock = DockStyle.Fill;
        panelContenido.Controls.Add(vista);

        if (botonActivo is not null)
            MarcarActivoSidebar(botonActivo);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)

    {
        if (_actual == this)
            _actual = null;

        base.OnFormClosed(e);
    }

    private void ConfigurarHoverSidebar()
    {
        Estilos.ConfigurarHoverItemSidebar(panelMenuHome, btnHome, () => _botonSidebarActivo == btnHome);
        Estilos.ConfigurarHoverItemSidebar(panelMenuUsuarios, button1, () => _botonSidebarActivo == button1);
        Estilos.ConfigurarHoverItemSidebar(panelMenuClientes, button2, () => _botonSidebarActivo == button2);
        Estilos.ConfigurarHoverItemSidebar(panelMenuCotizacion, button3, () => _botonSidebarActivo == button3);
        Estilos.ConfigurarHoverItemSidebar(panelMenuMateriales, button4, () => _botonSidebarActivo == button4);
        Estilos.ConfigurarHoverItemSidebar(panelMenuFacturas, button5, () => _botonSidebarActivo == button5);
        Estilos.ConfigurarHoverItemSidebar(panelCerrarSesion, btnCerrarSesion, () => false);
    }

    private void MarcarActivoSidebar(Button? activo)

    {
        _botonSidebarActivo = activo;
        Estilos.MarcarBotonSidebarActivo(activo, _botonesMenu);
    }

    private void btnHome_Click(object sender, EventArgs e) =>
        AbrirVista(new HomeControl(_usuario), btnHome);

    private void btnMiPerfilNavbar_Click(object sender, EventArgs e) =>
        AbrirVista(new PerfilUsuarioControl(_usuario));

    private void button1_Click(object sender, EventArgs e) =>
        AbrirVista(new RegistrarUsuariosControl(_usuario), button1);

    private void button2_Click(object sender, EventArgs e) =>
        AbrirVista(new ClienteControl(_usuario), button2);

    private void button3_Click(object sender, EventArgs e) =>
        AbrirVista(new ListaCotizacionControl(_usuario), button3);

    private void button4_Click(object sender, EventArgs e) =>
        AbrirVista(new MaterialControl(), button4);

    private void btnCerrarSesion_Click(object sender, EventArgs e)
    {
        if (_actual == this)
            _actual = null;

        var login = new Login.Login();
        login.Show();
        Close();
    }

    private void button5_Click(object sender, EventArgs e) =>
        AbrirVista(new FacturaControl(_usuario), button5);
}


