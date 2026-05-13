namespace Proyecto_Integrador.Modelos.Cotizaciones;

public class DetalleCotizacion
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string NombreMaterial { get; private set; }
    public decimal Cantidad { get; private set; }
    public decimal PrecioUnitario { get; private set; }
    public decimal Subtotal => Cantidad * PrecioUnitario;

    public DetalleCotizacion( string nombreMaterial, decimal cantidad, decimal precioUnitario)
    {
        NombreMaterial = nombreMaterial;
        Cantidad = cantidad;
        PrecioUnitario = precioUnitario;
    }
}