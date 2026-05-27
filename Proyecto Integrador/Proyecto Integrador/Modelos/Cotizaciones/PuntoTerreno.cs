using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Modelos.Cotizaciones;

public class PuntoTerreno
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    [JsonConstructor]
    public PuntoTerreno(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}
