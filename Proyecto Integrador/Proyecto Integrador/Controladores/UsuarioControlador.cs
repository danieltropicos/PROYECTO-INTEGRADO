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

    public bool CambiarContrasena(Guid id, string contrasenaActual, string contrasenaNueva) =>
        usuarioRepositorio.CambiarContrasena(id, contrasenaActual, contrasenaNueva);

    public void AgregarUsuario(Usuario usuario)
    {
        usuarioRepositorio.Agregar(usuario);
    }

    public int ContarUsuarios() =>
        usuarioRepositorio.ContarUsuarios();

    public void ActualizarUsuario(Guid id, Usuario usuario, string? contrasenaPlana = null) =>
        usuarioRepositorio.Actualizar(id, usuario, contrasenaPlana);
}
