using Proyecto_Integrador.Modelos.Usuarios;
using System.Text.Json;

namespace Proyecto_Integrador.Repositorios;

public class RolRepositorio
{
    private static readonly string Carpeta = "Data";
    private static readonly string RutaArchivo = Path.Combine(Carpeta, "Roles.json");

    public List<Rol> ObtenerRoles()
    {
        if (!File.Exists(RutaArchivo))
        {
            Directory.CreateDirectory(Carpeta);
            var rolesIniciales = new List<Rol>
            {
                new("Admin"),
                new("Usuario")
            };
            Guardar(rolesIniciales);
            return Ordenar(rolesIniciales);
        }

        using var reader = new StreamReader(RutaArchivo);
        var json = reader.ReadToEnd();
        if (string.IsNullOrWhiteSpace(json))
            return [];

        var roles = JsonSerializer.Deserialize<List<Rol>>(json) ?? [];
        return Ordenar(roles);
    }

    private static List<Rol> Ordenar(List<Rol> roles) =>
        roles.OrderBy(r => r.Nombre, StringComparer.OrdinalIgnoreCase).ToList();

    private static void Guardar(List<Rol> roles)
    {
        var opciones = new JsonSerializerOptions { WriteIndented = true };
        using var writer = new StreamWriter(RutaArchivo);
        writer.Write(JsonSerializer.Serialize(roles, opciones));
    }
}
