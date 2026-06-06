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

    public void DesactivarCotizacion(Cotizacion cotizacion)
    {
        cotizacion.Desactivar();
        cotizacionRepositorio.ActualizarCotizacion(cotizacion);
    }

    public void ActivarCotizacion(Cotizacion cotizacion)
    {
        cotizacion.Activar();
        cotizacionRepositorio.ActualizarCotizacion(cotizacion);
    }

    public int ContarCotizaciones(string? estado)
    {
        return cotizacionRepositorio.ContarCotizaciones(estado);
    }
}
