using Proyecto_Integrador.Modelos.Cotizaciones;
using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Modelos.Facturas;

public class Factura
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Cotizacion Cotizacion { get; private set; }
    public Cliente Cliente { get; private set; }
    public DateTime FechaEmision { get; private set; } = DateTime.Now;
    public decimal Total { get; private set; }

    public Factura(Cotizacion cotizacion)
    {
        Cotizacion = cotizacion;
        Cliente = cotizacion.Cliente;
        Total = cotizacion.Total;
    }
}
