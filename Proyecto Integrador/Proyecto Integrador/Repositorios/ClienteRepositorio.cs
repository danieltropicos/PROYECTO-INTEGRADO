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

    public List<Cliente> ObtenerClientes() => clientes;

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
