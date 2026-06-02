using Proyecto_Integrador.Modelos.Usuarios;
using System.Text.Json;

namespace Proyecto_Integrador.Repositorios;

public class RolRepositorio
{
    const string CarpetaData = "Data";
    private static readonly string RutaArchivo =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CarpetaData, "roles.json");

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

    private void GuardarRoles()
    {
        Directory.CreateDirectory(CarpetaData);
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        using (var writer = new StreamWriter(RutaArchivo))
        {
            var json = JsonSerializer.Serialize(roles, options);
            writer.Write(json);
        }
    }

    private void CargarRoles()
    {
        if (!File.Exists(RutaArchivo))
        {
            roles.AddRange(
            [
                new Rol("Admin"),
                new Rol("Usuario")
            ]);
            GuardarRoles();
            return;
        }

        var opciones = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        using (var reader = new StreamReader(RutaArchivo))
        {
            var json = reader.ReadToEnd();
            var rolesCargados = JsonSerializer.Deserialize<List<Rol>>(json, opciones);
            if (rolesCargados != null)
            {
                roles.AddRange(rolesCargados);
            }
        }
    }
}
