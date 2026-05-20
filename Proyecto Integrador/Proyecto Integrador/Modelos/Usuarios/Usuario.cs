using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;

namespace Proyecto_Integrador.Modelos.Usuarios;

public class Usuario : Persona
{
    public string NombreUsuario { get; private set; }
    public string ContrasenaEncriptada { get; private set; }
    public Rol Rol { get; private set; }

    [JsonConstructor]
    public Usuario(
        Guid id,                        
        string nombre,
        string apellido,
        string correoElectronico,
        string telefono,
        string direccion,
        bool esActivo,                  
        DateTime fechaRegistro,         
        string nombreUsuario,
        string contrasenaEncriptada,
        Rol rol)
        : base(
            id,                         
            nombre,
            apellido,
            correoElectronico,
            telefono,
            direccion,
            esActivo,
            fechaRegistro)
    {
        NombreUsuario = nombreUsuario;
        ContrasenaEncriptada = contrasenaEncriptada;
        Rol = rol;
    }

    //  usuarios nuevos
    public Usuario(
        string nombre,
        string apellido,
        string correoElectronico,
        string telefono,
        string direccion,
        string nombreUsuario,
        string contrasena,
        Rol rol,
        bool encriptar)
        : base(
            nombre,
            apellido,
            correoElectronico,
            telefono,
            direccion)
    {
        NombreUsuario = nombreUsuario;
        Rol = rol;
        ContrasenaEncriptada = HashContrasena(contrasena);
    }
    

    public void CambiarContrasena(string nuevaContrasena)
    {
        ContrasenaEncriptada = HashContrasena(nuevaContrasena);
    }

    public bool ValidarContrasena(string contrasena)
    {
        return ContrasenaEncriptada ==
            HashContrasena(contrasena);
    }

    private string HashContrasena(string contrasena)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(contrasena);
            byte[] hash = sha256.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();

            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}