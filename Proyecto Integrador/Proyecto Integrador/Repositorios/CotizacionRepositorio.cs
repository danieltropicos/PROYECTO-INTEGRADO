using Proyecto_Integrador.Modelos.Cotizaciones;

namespace Proyecto_Integrador.Repositorios;

public class CotizacionRepositorio
{
    private const string NombreArchivo = "cotizaciones.json";

    private readonly List<Cotizacion> cotizaciones = [];

    public CotizacionRepositorio()
    {
        CargarCotizaciones();
    }

    public void AgregarCotizacion(Cotizacion cotizacion)
    {
        cotizaciones.Add(cotizacion);
        GuardarCotizaciones();
    }

    public List<Cotizacion> ObtenerCotizaciones() => cotizaciones;

    public int ContarCotizaciones(string? estado)
    {
        if (string.IsNullOrWhiteSpace(estado))
            return cotizaciones.Count;

        return cotizaciones.Count(x => x.Estado == estado);
    }

    public void ActualizarCotizacion(Cotizacion cotizacion)
    {
        var index = cotizaciones.FindIndex(c => c.Id == cotizacion.Id);
        if (index >= 0)
        {
            cotizaciones[index] = cotizacion;
            GuardarCotizaciones();
        }
    }

    private void GuardarCotizaciones() =>
        AlmacenJsonCifrado.Guardar(NombreArchivo, cotizaciones);

    private void CargarCotizaciones()
    {
        var cotizacionesCargadas = AlmacenJsonCifrado.Cargar<List<Cotizacion>>(NombreArchivo);
        if (cotizacionesCargadas != null)
            cotizaciones.AddRange(cotizacionesCargadas);
    }
}
