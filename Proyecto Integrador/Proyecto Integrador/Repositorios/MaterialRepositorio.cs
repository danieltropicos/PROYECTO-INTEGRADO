using Proyecto_Integrador.Modelos.Cotizaciones;

namespace Proyecto_Integrador.Repositorios;

public class MaterialRepositorio
{
    private const string NombreArchivo = "material.json";

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

    public int ContarMateriales() => materiales.Count;

    public void AgregarMaterial(Material material)
    {
        materiales.Add(material);
        GuardarMateriales();
    }

    public void Actualizar(Guid id, Material nuevoModelo)
    {
        var index = materiales.FindIndex(m => m.Id == id);
        if (index < 0) return;

        materiales[index] = new Material(id, nuevoModelo.Nombre, nuevoModelo.ValorMetroCubico);
        GuardarMateriales();
    }

    private void GuardarMateriales() =>
        AlmacenJsonCifrado.Guardar(NombreArchivo, materiales);

    private void CargarMateriales()
    {
        var materialesCargados = AlmacenJsonCifrado.Cargar<List<Material>>(NombreArchivo);
        if (materialesCargados != null)
            materiales.AddRange(materialesCargados);
    }
}
