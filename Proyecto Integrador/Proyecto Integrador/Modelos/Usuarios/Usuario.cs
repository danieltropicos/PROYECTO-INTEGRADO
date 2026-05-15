using System.Security.Cryptography;
using System.Text;

namespace Proyecto_Integrador.Modelos.Usuarios;

public class Usuario : Persona
{
    const string CONSTRASENA_TEMPORAL = "Temp1234!";
    public string NombreUsuario { get; private set; }
    public Rol Rol { get; private set; }
    private string ContrasenaEncriptada { get; set; }
    public bool DebeCambiarContrasena { get; private set; }

    public Usuario(
        string nombre,
        string apellido,
        string correoElectronico,
        string telefono,
        string direccion,
        string nombreUsuario,
        Rol rol)

        : base(
            nombre,
            apellido,
            correoElectronico,
            telefono,
            direccion)
    {
        NombreUsuario = nombreUsuario;
        Rol = rol;
        ContrasenaEncriptada = HashContrasena(CONSTRASENA_TEMPORAL);
    }

    public void CambiarContrasena(string nuevaContrasena)
    {
        ContrasenaEncriptada = HashContrasena(nuevaContrasena);
        DebeCambiarContrasena = false;
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