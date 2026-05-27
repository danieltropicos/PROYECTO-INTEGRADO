using Proyecto_Integrador.Modelos.Cotizaciones;
using System.Text.Json;

namespace Proyecto_Integrador.Repositorios;

public class MaterialRepositorio
{
    const string CarpetaData = "Data";
    private static readonly string RutaArchivo =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CarpetaData, "material.json");


    private readonly List<Material> materiales = [];

    public MaterialRepositorio()
    {
        CargarMateriales();
    }

    public List<Material> ObtenerMateriales(string? filtro = null)
    {
        IEnumerable<Material> resultado = materiales;

        if (!string.IsNullOrWhiteSpace(filtro))
        {
            resultado = resultado.Where(m =>
                m.Nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase));
        }

        return resultado
            .OrderBy(m => m.Nombre, StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    public void AgregarMaterial(Material material)
    {
        materiales.Add(material);
        GuardarMateriales();
    }

    private void GuardarMateriales()
    {
        Directory.CreateDirectory(CarpetaData);
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        using (var writer = new StreamWriter(RutaArchivo))
        {
            var json = JsonSerializer.Serialize(materiales, options);
            writer.Write(json);
        }
    }

    private void CargarMateriales()
    {
        if (!File.Exists(RutaArchivo)) return;

        var opciones = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        using (var reader = new StreamReader(RutaArchivo))
        {
            var json = reader.ReadToEnd();
            var materialesCargados = JsonSerializer.Deserialize<List<Material>>(json, opciones);
            if (materialesCargados != null)
            {
                materiales.AddRange(materialesCargados);
            }
        }
    }
}
