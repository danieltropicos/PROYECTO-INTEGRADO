namespace Proyecto_Integrador.Modelos.Cotizaciones;

public class Terreno
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public decimal Largo { get; set; }
    public decimal Ancho { get; set; }

    public List<PuntoTerreno> Puntos { get; set; } = new();

    public Terreno(decimal largo, decimal ancho)
    {
        Largo = largo;
        Ancho = ancho;
    }
}
