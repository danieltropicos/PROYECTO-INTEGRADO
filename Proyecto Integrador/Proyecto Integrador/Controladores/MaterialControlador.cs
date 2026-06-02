using Proyecto_Integrador.Modelos.Cotizaciones;
using Proyecto_Integrador.Repositorios;

namespace Proyecto_Integrador.Controladores;

public class MaterialControlador
{
    private MaterialRepositorio materialRespositorio;
    public MaterialControlador()
    {
        materialRespositorio = new MaterialRepositorio();
    }

    public List<Material> ObtenerMateriales(string? filtro = null) =>
        materialRespositorio.ObtenerMateriales(filtro);

    public void AgregarMaterial(Material material) =>
        materialRespositorio.AgregarMaterial(material);

    public void ActualizarMaterial(Guid id, Material material) =>
        materialRespositorio.Actualizar(id, material);
}
