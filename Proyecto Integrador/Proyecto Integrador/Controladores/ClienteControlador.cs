using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Repositorios;

namespace Proyecto_Integrador.Controladores;

public class ClienteControlador
{
    public readonly ClienteRepositorio clienteRepositorio;
    public ClienteControlador()
    {
        clienteRepositorio = new ClienteRepositorio();
    }

    public void AgregarCliente(Cliente cliente) =>
        clienteRepositorio.AgregarCliente(cliente);

    public List<Cliente> ObtenerClientes(string? filtro = null) =>
        clienteRepositorio.ObtenerClientes(filtro);

    public void ActualizarCliente(Guid id, Cliente cliente) =>
        clienteRepositorio.Actualizar(id, cliente);

    public int ContarClientes() =>
        clienteRepositorio.ContarClientes();
}
