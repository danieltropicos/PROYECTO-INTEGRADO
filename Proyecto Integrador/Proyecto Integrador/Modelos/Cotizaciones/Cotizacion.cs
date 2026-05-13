using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Modelos.Cotizaciones;

public class Cotizacion
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Cliente Cliente { get; private set; }
    public Usuario UsuarioCreador { get; private set; }
    public decimal Largo { get; private set; }
    public decimal Ancho { get; private set; }
    public List<PuntoTerreno> Puntos { get; private set; } = new();
    public decimal Volumen { get; private set; }
    public DateTime FechaCreacion { get; private set; } = DateTime.Now;
    public List<DetalleCotizacion> Detalles { get; private set; } = new();
    public decimal Total { get; private set; }

    public Cotizacion(Cliente cliente, Usuario usuarioCreador, decimal largo, decimal ancho)
    {
        Cliente = cliente;
        UsuarioCreador = usuarioCreador;
        Largo = largo;
        Ancho = ancho;
    }

    public void AgregarPunto(PuntoTerreno punto)
    {
        Puntos.Add(punto);
    }

    public void EstablecerVolumen(decimal volumen)
    {
        Volumen = volumen;
    }

    public void AgregarDetalle(DetalleCotizacion detalle)
    {
        Detalles.Add(detalle);
        CalcularTotal();
    }

    private void CalcularTotal()
    {
        Total = Detalles.Sum(d => d.Subtotal);
    }
}
