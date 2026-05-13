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
        return Convert.ToBase64String(
            System.Text.Encoding.UTF8
                .GetBytes(contrasena)
        );
    }
}