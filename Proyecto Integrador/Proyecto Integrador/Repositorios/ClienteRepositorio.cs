using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Repositorios;

public class ClienteRepositorio
{
    private const string NombreArchivo = "clientes.json";

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

    public Cliente? ObtenerPorId(Guid id) =>
        clientes.FirstOrDefault(c => c.Id == id);

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

    private void GuardarClientes() =>
        AlmacenJsonCifrado.Guardar(NombreArchivo, clientes);

    private void CargarClientes()
    {
        var clientesCargados = AlmacenJsonCifrado.Cargar<List<Cliente>>(NombreArchivo);
        if (clientesCargados != null)
            clientes.AddRange(clientesCargados);
    }
}
