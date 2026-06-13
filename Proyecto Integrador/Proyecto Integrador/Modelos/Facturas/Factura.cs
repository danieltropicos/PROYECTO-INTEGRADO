using Proyecto_Integrador.Modelos.Cotizaciones;
using Proyecto_Integrador.Modelos.Usuarios;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Modelos.Facturas;

public class Factura
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Cotizacion Cotizacion { get; private set; }
    public Guid ClienteId { get; private set; }

    [JsonIgnore]
    public Cliente? Cliente { get; private set; }

    public DateTime FechaEmision { get; private set; } = DateTime.Now;
    public decimal Total { get; private set; }
    public decimal Subtotal { get; private set; }
    public decimal Iva { get; private set; }
    public string Estado { get; private set; }

    public Factura(Cotizacion cotizacion)
    {
        Cotizacion = cotizacion;
        ClienteId = cotizacion.ClienteId;
        Cliente = cotizacion.Cliente;
        Subtotal = cotizacion.SubTotal;
        Total = cotizacion.Total;
        Iva = cotizacion.Iva;
        Estado = "Pendiente";
    }

    [JsonConstructor]
    public Factura(
        Guid id,
        Cotizacion cotizacion,
        Guid clienteId,
        DateTime fechaEmision,
        decimal subtotal,
        decimal total,
        decimal iva,
        string estado)
    {
        Id = id;
        Cotizacion = cotizacion;
        ClienteId = clienteId;
        FechaEmision = fechaEmision;
        Subtotal = subtotal;
        Total = total;
        Iva = iva;
        Estado = estado;
    }

    public void VincularCliente(Cliente cliente)
    {
        if (cliente.Id != ClienteId)
            return;

        Cliente = cliente;
        Cotizacion.VincularCliente(cliente);
    }

    public void CambiarEstado(string nuevoEstado) => Estado = nuevoEstado;
}
