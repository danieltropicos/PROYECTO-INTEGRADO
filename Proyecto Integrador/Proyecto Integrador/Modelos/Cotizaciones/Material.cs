namespace Proyecto_Integrador.Modelos.Cotizaciones;

public class Material
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; set; }
    public decimal ValorMetroCubico { get; set; }

    public Material(string nombre, decimal valorMetroCubico)
    {
        Nombre = nombre;
        ValorMetroCubico = valorMetroCubico;
    }

    public override string ToString() => Nombre;
}
