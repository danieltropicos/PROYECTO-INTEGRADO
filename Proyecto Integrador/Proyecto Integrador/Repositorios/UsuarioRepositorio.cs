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

    public void Actualizar(Guid id, Usuario nuevoModelo, string? contrasenaPlana = null)
    {
        var lista = AlmacenJsonCifrado.Cargar<List<Usuario>>(NombreArchivo) ?? [];
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

    private static List<Usuario> CrearUsuariosIniciales() =>
    [
        new Usuario(
            "Admin",
            "Sistema",
            "admin@gmail.com",
            "3000000000",
            "Sin dirección",
            "admin",
            "1234",
            new Rol("Admin")),
        new Usuario(
            "Usuario",
            "Prueba",
            "usuario@gmail.com",
            "3000000001",
            "Sin dirección",
            "usuario",
            "1234",
            new Rol("Usuario"))
    ];
}
