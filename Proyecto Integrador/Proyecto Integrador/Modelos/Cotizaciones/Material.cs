using System.Globalization;
using System.Text.Json.Serialization;

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

    [JsonConstructor]
    public Material(Guid id, string nombre, decimal valorMetroCubico)
    {
        Id = id;
        Nombre = nombre;
        ValorMetroCubico = valorMetroCubico;
    }

    public string ValorMetroCubicoFormateado =>
        ValorMetroCubico.ToString("C0", new CultureInfo("es-CO"));
}
