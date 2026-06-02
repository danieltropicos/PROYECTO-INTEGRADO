using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Repositorios;

namespace Proyecto_Integrador.Controladores;

public class RolControlador
{
    private readonly RolRepositorio rolRepositorio;

    public RolControlador()
    {
        rolRepositorio = new RolRepositorio();
    }

    public List<Rol> ObtenerRoles(string? filtro = null) =>
        rolRepositorio.ObtenerRoles(filtro);
}
