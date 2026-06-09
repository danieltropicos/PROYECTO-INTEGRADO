using System.Text.Json.Serialization;
using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Modelos.Cotizaciones;

public class Cotizacion
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Cliente Cliente { get; private set; }
    public Usuario UsuarioCreador { get; private set; }

    [JsonPropertyName("TerrenoOriginal")]
    public List<PuntoTerreno> Terreno { get; private set; } = new();

    public Material Material { get; private set; }
    public decimal VolumenCalculado { get; private set; }
    public string Estado { get; private set; }
    public decimal SubTotal => VolumenCalculado * Material.ValorMetroCubico;
    public decimal Iva => SubTotal * 0.19m;
    public decimal Total => SubTotal + Iva;
   
    public DateTime FechaCreacion { get; private set; } = DateTime.Now;

    public Cotizacion(
        Cliente cliente,
        Usuario usuarioCreador,
        Material material)
    {
        Cliente = cliente;
        UsuarioCreador = usuarioCreador;
        Material = material;
        Estado = "Activa";
    }

    [JsonConstructor]
    public Cotizacion(
        Guid id,
        Cliente cliente,
        Usuario usuarioCreador,
        List<PuntoTerreno> terreno,
        Material material,
        decimal volumenCalculado,
        string estado,
        DateTime fechaCreacion)
    {
        Id = id;
        Cliente = cliente;
        UsuarioCreador = usuarioCreador;
        Terreno = terreno ?? new();
        Material = material;
        VolumenCalculado = volumenCalculado;
        Estado = estado;
        FechaCreacion = fechaCreacion;
    }

    public void Activar()
    {
        Estado = "Activa";
    }

    public void Desactivar()
    {
        Estado = "Inactiva";
    }

    public void AgregarPunto(PuntoTerreno punto)
    {
        Terreno.Add(punto);
    }

    public void EstablecerVolumen(decimal volumen)
    {
        VolumenCalculado = volumen;
    }

    public void EstablecerTerreno(List<PuntoTerreno> terreno)
    {
        Terreno = new List<PuntoTerreno>(terreno);
    }
}
