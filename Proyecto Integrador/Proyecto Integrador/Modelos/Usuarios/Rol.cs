namespace Proyecto_Integrador.Modelos.Usuarios;

public class Rol
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Nombre { get; private set; }

    public Rol(string nombre)
    {
        Nombre = nombre;
    }
}
