using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Repositorios;

public class UsuarioRepositorio
{
    private const string NombreArchivo = "usuarios.json";

    public List<Usuario> Leer(string? filtro = null)
    {
        if (!AlmacenJsonCifrado.Existe(NombreArchivo))
            AlmacenJsonCifrado.Guardar(NombreArchivo, CrearUsuariosIniciales());

        var lista = AlmacenJsonCifrado.Cargar<List<Usuario>>(NombreArchivo) ?? [];

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

    public int ContarUsuarios() => Leer().Count;

    public Usuario? ObtenerUsuarioPorNombreUsuario(string nombreDeUsuario) =>
        Leer().FirstOrDefault(x => x.NombreUsuario == nombreDeUsuario);

    private void Guardar(List<Usuario> lista) =>
        AlmacenJsonCifrado.Guardar(NombreArchivo, lista);

    public void Agregar(Usuario usuario)
    {
        var lista = AlmacenJsonCifrado.Cargar<List<Usuario>>(NombreArchivo) ?? [];
        lista.Add(usuario);
        Guardar(lista);
    }

    public void Actualizar(Guid id, Usuario datos, string? contrasenaPlana = null)
    {
        var lista = AlmacenJsonCifrado.Cargar<List<Usuario>>(NombreArchivo) ?? [];
        var index = lista.FindIndex(u => u.Id == id);
        if (index < 0)
            return;

        var actual = lista[index];
        actual.ActualizarDatos(datos);

        if (!string.IsNullOrWhiteSpace(contrasenaPlana))
            actual.CambiarContrasena(contrasenaPlana);

        Guardar(lista);
    }

    private static List<Usuario> CrearUsuariosIniciales() =>
    [
        CrearUsuarioInicial(
            "Admin",
            "Sistema",
            "admin@gmail.com",
            "3000000000",
            "Sin dirección",
            "admin",
            "1234",
            new Rol("Admin")),
        CrearUsuarioInicial(
            "Usuario",
            "Prueba",
            "usuario@gmail.com",
            "3000000001",
            "Sin dirección",
            "usuario",
            "1234",
            new Rol("Usuario"))
    ];

    private static Usuario CrearUsuarioInicial(
        string nombre,
        string apellido,
        string correo,
        string telefono,
        string direccion,
        string nombreUsuario,
        string contrasena,
        Rol rol)
    {
        var usuario = new Usuario(nombre, apellido, correo, telefono, direccion, nombreUsuario, rol);
        usuario.EstablecerContrasena(contrasena);
        return usuario;
    }
}
