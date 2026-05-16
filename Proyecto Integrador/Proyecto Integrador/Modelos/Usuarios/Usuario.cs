namespace Proyecto_Integrador.Modelos.Usuarios;

public class Usuario : Persona
{
    const string CONSTRASENA_TEMPORAL = "Temp1234!";
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
        ContrasenaEncriptada = HashContrasena(CONSTRASENA_TEMPORAL);
    }

    public void CambiarContrasena(string nuevaContrasena)
    {
        ContrasenaEncriptada = HashContrasena(nuevaContrasena);
    }

    private string HashContrasena(string contrasena)
    {
        return Convert.ToBase64String(
            System.Text.Encoding.UTF8
                .GetBytes(contrasena)
        );
    }
}