using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Repositorios;

public class RolRepositorio
{
    private const string NombreArchivo = "roles.json";

    private readonly List<Rol> roles = [];

    public RolRepositorio()
    {
        CargarRoles();
    }

    public List<Rol> ObtenerRoles(string? filtro = null)
    {
        IEnumerable<Rol> resultado = roles;

        if (!string.IsNullOrWhiteSpace(filtro))
        {
            resultado = resultado.Where(r =>
                r.Nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase));
        }

        return resultado
            .OrderBy(r => r.Nombre, StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    private void GuardarRoles() =>
        AlmacenJsonCifrado.Guardar(NombreArchivo, roles);

    private void CargarRoles()
    {
        if (!AlmacenJsonCifrado.Existe(NombreArchivo))
        {
            roles.AddRange(
            [
                new Rol("Admin"),
                new Rol("Usuario")
            ]);
            GuardarRoles();
            return;
        }

        var rolesCargados = AlmacenJsonCifrado.Cargar<List<Rol>>(NombreArchivo);
        if (rolesCargados != null)
            roles.AddRange(rolesCargados);
    }
}
