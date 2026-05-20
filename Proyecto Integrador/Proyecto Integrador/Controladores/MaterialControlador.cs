using Proyecto_Integrador.Repositorios;

namespace Proyecto_Integrador.Controladores;

public class MaterialControlador
{
    private MaterialRepositorio materialRespositorio;
    public MaterialControlador()
    {
        materialRespositorio = new MaterialRepositorio();
    }
    public List<string> ObtenerMateriales() => materialRespositorio.ObtenerMateriales();
}
