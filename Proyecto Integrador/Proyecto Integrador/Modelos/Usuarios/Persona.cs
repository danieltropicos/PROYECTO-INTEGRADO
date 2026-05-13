namespace Proyecto_Integrador.Modelos.Usuarios;

public abstract class Persona
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Nombre { get; protected set; }
    public string Apellido { get; protected set; }
    public string CorreoElectronico { get; protected set; }
    public string Telefono { get; protected set; }
    public string Direccion { get; protected set; }
    public bool EsActivo { get; protected set; } = true;
    public DateTime FechaRegistro { get; protected set; } = DateTime.Now;

    protected Persona(
        string nombre,
        string apellido,
        string correoElectronico,
        string telefono,
        string direccion)
    {
        Nombre = nombre;
        Apellido = apellido;
        CorreoElectronico = correoElectronico;
        Telefono = telefono;
        Direccion = direccion;
    }

    public void Activar()
    {
        EsActivo = true;
    }

    public void Desactivar()
    {
        EsActivo = false;
    }
}