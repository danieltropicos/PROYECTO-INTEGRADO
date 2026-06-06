using Proyecto_Integrador.Modelos.Usuarios;
using System.Text.Json;

namespace Proyecto_Integrador.Repositorios;

public class ClienteRepositorio
{
    const string CarpetaData = "Data";
    private static readonly string RutaArchivo =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CarpetaData, "clientes.json");

    private readonly List<Cliente> clientes = [];

    public ClienteRepositorio()
    {
        CargarClientes();
    }

    public void AgregarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
        GuardarClientes();
    }

    public List<Cliente> ObtenerClientes(string? filtro = null)
    {
        IEnumerable<Cliente> resultado = clientes.Where(c => c.EsActivo);

        if (!string.IsNullOrWhiteSpace(filtro))
        {
            resultado = resultado.Where(c =>
                c.NombreCompleto.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                c.Nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                c.Apellido.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                c.Documento.Contains(filtro, StringComparison.OrdinalIgnoreCase));
        }

        return resultado
            .OrderBy(c => c.NombreCompleto, StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    public int ContarClientes() => clientes.Count(c => c.EsActivo);

    public void Actualizar(Guid id, Cliente nuevoModelo)
    {
        var index = clientes.FindIndex(c => c.Id == id);
        if (index < 0) return;

        var actual = clientes[index];
        clientes[index] = new Cliente(
            id,
            nuevoModelo.Nombre,
            nuevoModelo.Apellido,
            nuevoModelo.CorreoElectronico,
            nuevoModelo.Telefono,
            nuevoModelo.Direccion,
            nuevoModelo.Documento,
            nuevoModelo.EsActivo,
            actual.FechaRegistro);

        GuardarClientes();
    }

    private void GuardarClientes()
    {
        Directory.CreateDirectory(CarpetaData);
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        using (var writer = new StreamWriter(RutaArchivo))
        {
            var json = JsonSerializer.Serialize(clientes, options);
            writer.Write(json);
        }
    }

    private void CargarClientes()
    {
        if (!File.Exists(RutaArchivo)) return;

        var opciones = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        using (var reader = new StreamReader(RutaArchivo))
        {
            var json = reader.ReadToEnd();
            var clientesCargados = JsonSerializer.Deserialize<List<Cliente>>(json, opciones);
            if (clientesCargados != null)
            {
                clientes.AddRange(clientesCargados);
            }
        }
    }
}
