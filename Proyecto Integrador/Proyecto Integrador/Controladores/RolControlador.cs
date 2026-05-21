using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Repositorios;

namespace Proyecto_Integrador.Controladores;

public class RolControlador
{
    private readonly RolRepositorio _repositorio = new();

    public List<Rol> ObtenerRoles() => _repositorio.ObtenerRoles();
}
