using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Modelos.Usuarios;

public class Usuario : Persona
{
    public string NombreUsuario { get; private set; }
    public string ContrasenaEncriptada { get; private set; } = string.Empty;
    public Rol Rol { get; private set; }

    public Usuario(
        string nombre,
        string apellido,
        string correoElectronico,
        string telefono,
        string direccion,
        string nombreUsuario,
        Rol rol)
        : base(nombre, apellido, correoElectronico, telefono, direccion)
    {
        NombreUsuario = nombreUsuario;
        Rol = rol;
    }

    [JsonConstructor]
    public Usuario(
        Guid id,
        string nombre,
        string apellido,
        string correoElectronico,
        string telefono,
        string direccion,
        string nombreUsuario,
        string contrasenaEncriptada,
        Rol rol,
        bool esActivo,
        DateTime fechaRegistro)
        : base(id, nombre, apellido, correoElectronico, telefono, direccion, esActivo, fechaRegistro)
    {
        NombreUsuario = nombreUsuario;
        ContrasenaEncriptada = contrasenaEncriptada;
        Rol = rol;
    }

    public void EstablecerContrasena(string contrasenaPlana)
    {
        ContrasenaEncriptada = HashContrasena(contrasenaPlana);
    }

    public void CambiarContrasena(string nuevaContrasena) =>
        EstablecerContrasena(nuevaContrasena);

    public void ActualizarDatos(Usuario datos)
    {
        Nombre = datos.Nombre;
        Apellido = datos.Apellido;
        CorreoElectronico = datos.CorreoElectronico;
        Telefono = datos.Telefono;
        Direccion = datos.Direccion;
        NombreUsuario = datos.NombreUsuario;
        Rol = datos.Rol;
    }

    public bool ValidarContrasena(string contrasena) =>
        ContrasenaEncriptada == HashContrasena(contrasena);

    private static string HashContrasena(string contrasena)
    {
        using SHA256 sha256 = SHA256.Create();
        byte[] bytes = Encoding.UTF8.GetBytes(contrasena);
        byte[] hash = sha256.ComputeHash(bytes);

        StringBuilder sb = new();
        foreach (byte b in hash)
            sb.Append(b.ToString("x2"));

        return sb.ToString();
    }
}
