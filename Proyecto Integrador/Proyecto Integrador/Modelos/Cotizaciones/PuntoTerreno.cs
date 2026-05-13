namespace Proyecto_Integrador.Modelos.Cotizaciones;

public class PuntoTerreno
{
    public decimal X { get; set; }
    public decimal Y { get; set; }
    public decimal Z { get; set; }

    public PuntoTerreno(decimal x, decimal y, decimal z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}
