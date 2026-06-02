using Proyecto_Integrador.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Proyecto_Integrador.Repositorios;

public class UsuarioRepositorio
{
    private static readonly string folder = "Data";
    public static readonly string filePath = Path.Combine(folder, "Usuarios.json");

    public List<Usuario> Leer(string? filtro = null)
    {
        List<Usuario> lista = new List<Usuario>();

        if (File.Exists(filePath))
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string json = sr.ReadToEnd();

                if (!string.IsNullOrWhiteSpace(json))
                {
                    lista = JsonSerializer.Deserialize<List<Usuario>>(json) ?? lista;
                }
            }
        }
        else
        {
            Directory.CreateDirectory(folder);
            File.WriteAllText(filePath, "[]");
        }

        if (!string.IsNullOrWhiteSpace(filtro))
        {
            lista = lista
                .Where(u =>
                    u.NombreCompleto.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    u.NombreUsuario.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        return lista
            .OrderBy(u => u.NombreCompleto, StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    public Usuario? ObtenerUsuarioPorNombreUsuario(string nombreDeUsuario)
    {
        return Leer().FirstOrDefault(x => x.NombreUsuario == nombreDeUsuario);
    }

    private void Guardar(List<Usuario> lista)
    {
        var opciones = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        using (StreamWriter sw = new StreamWriter(filePath))
        {
            string json = JsonSerializer.Serialize<List<Usuario>>(lista, opciones);
            sw.Write(json);
        }
    }

    public void Agregar(Usuario usuario)
    {
        List<Usuario> lista = Leer();
        lista.Add(usuario);
        Guardar(lista);
    }
    public void Actualizar(Guid id, Usuario nuevoModelo, string? contrasenaPlana = null)
    {
        var lista = Leer();
        var index = lista.FindIndex(u => u.Id == id);
        if (index < 0) return;

        var actual = lista[index];
        lista[index] = new Usuario(
            id,
            nuevoModelo.Nombre,
            nuevoModelo.Apellido,
            nuevoModelo.CorreoElectronico,
            nuevoModelo.Telefono,
            nuevoModelo.Direccion,
            nuevoModelo.NombreUsuario,
            actual.ContrasenaEncriptada,
            nuevoModelo.Rol,
            nuevoModelo.EsActivo,
            actual.FechaRegistro);

        if (!string.IsNullOrWhiteSpace(contrasenaPlana))
            lista[index].CambiarContrasena(contrasenaPlana);

        Guardar(lista);
    }
}
