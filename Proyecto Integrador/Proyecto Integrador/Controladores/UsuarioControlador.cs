using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Repositorios;

namespace Proyecto_Integrador.Controladores;

public class UsuarioControlador
{
    private readonly UsuarioRepositorio usuarioRepositorio;

    public UsuarioControlador()
    {
        usuarioRepositorio = new UsuarioRepositorio();
    }

    public List<Usuario> ObtenerUsuarios(string? filtro = null) =>
        usuarioRepositorio.Leer(filtro);

    public Usuario? ObtenerUsuarioPorNombreUsuario(string nombreDeUsuario) =>
        usuarioRepositorio.ObtenerUsuarioPorNombreUsuario(nombreDeUsuario);

    public void AgregarUsuario(Usuario usuario)
    {
        usuarioRepositorio.Agregar(usuario);
    }

    public void ActualizarUsuario(Usuario usuario)
    {
        usuarioRepositorio.Actualizar(usuario);
    }
}
