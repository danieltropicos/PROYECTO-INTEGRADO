namespace Proyecto_Integrador.Vistas.Utilidades;

/// <summary>
/// Iconos de las tablas. Se cargan una vez desde Recursos/Imagenes.
/// </summary>
public static class IconosAcciones
{
    public static Image? Editar { get; } = Cargar(AppAssets.ArchivoIconoEditar);
    public static Image? Activar { get; } = Cargar(AppAssets.ArchivoIconoActivar);
    public static Image? Inactivar { get; } = Cargar(AppAssets.ArchivoIconoInactivar);
    public static Image? GenerarFactura { get; } = Cargar(AppAssets.ArchivoIconoGenerarFactura);
    public static Image? Imprimir { get; } = Cargar(AppAssets.ArchivoIconoImprimir);
    public static Image? CambiarEstado { get; } = Cargar(AppAssets.ArchivoIconoCambiarEstado);

    private static Image? Cargar(string archivo)
    {
        var ruta = AppAssets.Ruta(archivo);
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
