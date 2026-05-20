namespace Proyecto_Integrador.Repositorios;

public class MaterialRepositorio
{
    private readonly List<string> materiales;

    public MaterialRepositorio()
    {
        materiales = new List<string>()
        {
            "Areana",
            "Cemento",
            "Grava",
            "Ladrillo"
        };
    }

    public List<string> ObtenerMateriales() => materiales;
}
