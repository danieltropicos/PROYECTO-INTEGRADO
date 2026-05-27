using System.Text.Json.Serialization;
using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Modelos.Cotizaciones;

public class Cotizacion
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Cliente Cliente { get; private set; }
    public Usuario UsuarioCreador { get; private set; }
    public List<PuntoTerreno> TerrenoOriginal { get; private set; } = new();
    public List<PuntoTerreno> TerrenoFinal { get; private set; } = new();
    public Material Material { get; private set; }
    public decimal VolumenCalculado { get; private set; }
    public string Estado { get; private set; }
    public decimal Total => VolumenCalculado * Material.ValorMetroCubico;

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
        List<PuntoTerreno> terrenoOriginal,
        List<PuntoTerreno> terrenoFinal,
        Material material,
        decimal volumenCalculado,
        string estado,
        DateTime fechaCreacion)
    {
        Id = id;
        Cliente = cliente;
        UsuarioCreador = usuarioCreador;
        TerrenoOriginal = terrenoOriginal ?? new();
        TerrenoFinal = terrenoFinal ?? new();
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

    public void AgregarPuntoOriginal(PuntoTerreno punto)
    {
        TerrenoOriginal.Add(punto);
    }

    public void AgregarPuntoFinal(PuntoTerreno punto)
    {
        TerrenoFinal.Add(punto);
    }

    public void EstablecerVolumen(decimal volumen)
    {
        VolumenCalculado = volumen;
    }

    public void EstablecerTerrenos(List<PuntoTerreno> original, List<PuntoTerreno> final_)
    {
        TerrenoOriginal = new List<PuntoTerreno>(original);
        TerrenoFinal = new List<PuntoTerreno>(final_);
    }
}
