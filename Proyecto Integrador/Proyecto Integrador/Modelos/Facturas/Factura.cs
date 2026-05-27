using System.Text.Json.Serialization;
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
    public string Estado { get; private set; }

    public Factura(Cotizacion cotizacion)
    {
        Cotizacion = cotizacion;
        Cliente = cotizacion.Cliente;
        Total = cotizacion.Total;
        Estado = "Pendiente";
    }

    [JsonConstructor]
    public Factura(Guid id, Cotizacion cotizacion, Cliente cliente, DateTime fechaEmision, decimal total, string estado)
    {
        Id = id;
        Cotizacion = cotizacion;
        Cliente = cliente;
        FechaEmision = fechaEmision;
        Total = total;
        Estado = estado;
    }

    public void CambiarEstado(string nuevoEstado)
    {
        Estado = nuevoEstado;
    }
}
