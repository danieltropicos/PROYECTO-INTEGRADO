namespace Proyecto_Integrador.Vistas.Utilidades;

/// <summary>
/// Iconos de las tablas. Se cargan una vez desde Recursos/Imagenes.
/// </summary>
public static class IconosAcciones
{
    public static Image? Editar { get; } = Cargar(RecursosAplicacion.ArchivoIconoEditar);
    public static Image? Activo { get; } = Cargar(RecursosAplicacion.ArchivoIconoActivo);
    public static Image? Inactivo { get; } = Cargar(RecursosAplicacion.ArchivoIconoInactivo);
    public static Image? GenerarFactura { get; } = Cargar(RecursosAplicacion.ArchivoIconoGenerarFactura);
    public static Image? Imprimir { get; } = Cargar(RecursosAplicacion.ArchivoIconoImprimir);
    public static Image? CambiarEstadoPendiente { get; } =
        Cargar(RecursosAplicacion.ArchivoIconoCambiarEstadoPendiente);

    public static Image? CambiarEstadoPagado { get; } =
        Cargar(RecursosAplicacion.ArchivoIconoCambiarEstadoPagado);

    public static Image? CambiarEstadoCancelado { get; } =
        Cargar(RecursosAplicacion.ArchivoIconoCambiarEstadoCancelado);

    public static Image? IconoCambiarEstadoFactura(string estado) => estado switch
    {
        "Pagada" => CambiarEstadoPagado,
        "Cancelada" => CambiarEstadoCancelado,
        _ => CambiarEstadoPendiente
    };
    public static Image? VerGrafica { get; } = Cargar(RecursosAplicacion.ArchivoIconoCotizacion);

    private static Image? Cargar(string archivo)
    {
        var ruta = RecursosAplicacion.Ruta(archivo);
        if (!File.Exists(ruta)) return null;

        try
        {
            return Image.FromFile(ruta);
        }
        catch
        {
            return null;
        }
    }
}
