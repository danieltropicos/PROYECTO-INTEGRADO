using System.Security.Cryptography;
using System.Text;

namespace Proyecto_Integrador.Modelos.Usuarios;

public class Usuario : Persona
{
    private const string CONTRASENA_TEMPORAL = "Temp1234!";
    public string NombreUsuario { get; private set; }
    public string ContrasenaEncriptada { get; private set; }
    public Rol Rol { get; private set; }

    [JsonConstructor]
    public Usuario(
        string nombre,
        string apellido,
        string correoElectronico,
        string telefono,
        string direccion,
        string nombreUsuario,
        string contrasenaUsuario
        )

        : base(
            nombre,
            apellido,
            correoElectronico,
            telefono,
            direccion)
    {
        NombreUsuario = nombreUsuario;
        Rol = rol;

        ContrasenaEncriptada = HashContrasena(CONTRASENA_TEMPORAL);
        DebeCambiarContrasena = true;
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