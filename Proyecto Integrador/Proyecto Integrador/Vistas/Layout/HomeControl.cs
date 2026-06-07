using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Cotizaciones;

namespace Proyecto_Integrador.Vistas.Layout;

public partial class HomeControl : UserControl
{
    private const int MaxActividades = 5;

    private readonly Usuario _usuario;
    private readonly UsuarioControlador _usuarioControlador = new();
    private readonly ClienteControlador _clienteControlador = new();
    private readonly MaterialControlador _materialControlador = new();
    private readonly CotizacionControlador _cotizacionControlador = new();
    private readonly FacturaControlador _facturaControlador = new();
    private readonly TarjetaActividadControl[] _tarjetasActividad;

    public HomeControl(Usuario usuario)
    {
        _usuario = usuario;
        InitializeComponent();
        _tarjetasActividad =
        [
            tarjetaActividad1,
            tarjetaActividad2,
            tarjetaActividad3,
            tarjetaActividad4,
            tarjetaActividad5
        ];
        CargarDashboard();
    }

    private bool EsAdmin => _usuario.Rol.Nombre == "Admin";

    private void CargarDashboard()
    {
        lblBienvenida.Text = $"¡Bienvenido, {_usuario.Nombre}!";
        lblSubtitulo.Text = "Este es el resumen general de tu sistema.";

        if (EsAdmin)
        {
            lblCantidadUsuarios.Text = _usuarioControlador.ContarUsuarios().ToString();
        }
        else
        {
            panelCardUsuarios.Visible = false;
            tableLayoutCards.ColumnStyles[0].SizeType = SizeType.Absolute;
            tableLayoutCards.ColumnStyles[0].Width = 0;
        }

        lblCantidadClientes.Text = _clienteControlador.ContarClientes().ToString();
        lblCantidadMateriales.Text = _materialControlador.ContarMateriales().ToString();
        lblCantidadCotizaciones.Text = _cotizacionControlador.ContarCotizaciones(null).ToString();

        lblCantidadCotizacionesActivas.Text = _cotizacionControlador.ContarCotizaciones("Activa").ToString();
        lblCantidadCotizacionesInactivas.Text = _cotizacionControlador.ContarCotizaciones("Inactiva").ToString();

        lblCantidadFacturasPendientes.Text = _facturaControlador.ContarFacturas("Pendiente").ToString();
        lblCantidadFacturasPagadas.Text = _facturaControlador.ContarFacturas("Pagada").ToString();
        lblCantidadFacturasCanceladas.Text = _facturaControlador.ContarFacturas("Cancelada").ToString();

        CargarActividadReciente();
    }

    private void CargarActividadReciente()
    {
        var actividades = new List<ActividadItem>();

        foreach (var cliente in _clienteControlador.ObtenerClientes())
        {
            actividades.Add(new ActividadItem(
                cliente.FechaRegistro,
                TipoActividad.Cliente,
                "Cliente creado",
                cliente.NombreCompleto));
        }

        foreach (var cotizacion in _cotizacionControlador.ObtenerCotizaciones())
        {
            var cliente = cotizacion.Cliente?.NombreCompleto ?? "N/A";
            var material = cotizacion.Material?.Nombre ?? "N/A";
            actividades.Add(new ActividadItem(
                cotizacion.FechaCreacion,
                TipoActividad.Cotizacion,
                "Cotización creada",
                $"{cliente} — {material}"));
        }

        foreach (var factura in _facturaControlador.ListarFacturas())
        {
            var cliente = factura.Cliente?.NombreCompleto ?? "N/A";
            actividades.Add(new ActividadItem(
                factura.FechaEmision,
                TipoActividad.Factura,
                "Factura emitida",
                $"{cliente} · {factura.Estado}"));
        }

        if (EsAdmin)
        {
            foreach (var usuario in _usuarioControlador.ObtenerUsuarios())
            {
                actividades.Add(new ActividadItem(
                    usuario.FechaRegistro,
                    TipoActividad.Usuario,
                    "Usuario registrado",
                    usuario.NombreCompleto));
            }
        }

        var recientes = actividades
            .OrderByDescending(a => a.Fecha)
            .Take(MaxActividades)
            .ToList();

        foreach (var tarjeta in _tarjetasActividad)
            tarjeta.Ocultar();

        if (recientes.Count == 0)
        {
            lblSinActividad.Visible = true;
            return;
        }

        lblSinActividad.Visible = false;

        for (var i = 0; i < recientes.Count; i++)
        {
            var actividad = recientes[i];
            _tarjetasActividad[i].Mostrar(
                actividad.Titulo,
                actividad.Detalle,
                actividad.Fecha,
                ObtenerColorAcento(actividad.Tipo),
                ObtenerIcono(actividad.Tipo));
        }
    }

    private static Color ObtenerColorAcento(TipoActividad tipo) => tipo switch
    {
        TipoActividad.Cliente => Color.FromArgb(34, 197, 94),
        TipoActividad.Cotizacion => Color.FromArgb(99, 102, 241),
        TipoActividad.Factura => Color.FromArgb(245, 158, 11),
        TipoActividad.Usuario => Color.FromArgb(59, 93, 122),
        _ => Color.FromArgb(156, 163, 175)
    };

    private static string ObtenerIcono(TipoActividad tipo) => tipo switch
    {
        TipoActividad.Cliente => "icono-cliente-verde.png",
        TipoActividad.Cotizacion => "icono-cotizacion-morado.png",
        TipoActividad.Factura => "icono-factura-naranja.png",
        TipoActividad.Usuario => "icono-usuario-azul-oscuro.png",
        _ => "icono-home.png"
    };

    private void btnNuevaCotizacion_Click(object sender, EventArgs e)
    {
        var cotizacion = new CotizacionControl(_usuario);
        cotizacion.CotizacionGuardada += (_, _) =>
            HomeLayout.AbrirVista(new ListaCotizacionControl(_usuario));
        HomeLayout.AbrirVista(cotizacion);
    }

    private enum TipoActividad
    {
        Cliente,
        Cotizacion,
        Factura,
        Usuario
    }

    private sealed record ActividadItem(
        DateTime Fecha,
        TipoActividad Tipo,
        string Titulo,
        string Detalle);
}
