using Proyecto_Integrador.Modelos.Cotizaciones;
using Proyecto_Integrador.Repositorios;

namespace Proyecto_Integrador.Controladores;

public class CotizacionControlador
{
    private readonly CotizacionRepositorio cotizacionRepositorio;
    public CotizacionControlador()
    {
        cotizacionRepositorio = new CotizacionRepositorio();
    }

    public void AgregarCotizacion(Cotizacion cotizacion)
    {
        cotizacionRepositorio.AgregarCotizacion(cotizacion);
    }

    public List<Cotizacion> ObtenerCotizaciones()
    {
        return cotizacionRepositorio.ObtenerCotizaciones();
    }
}
