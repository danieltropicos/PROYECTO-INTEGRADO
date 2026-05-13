namespace Proyecto_Integrador.Modelos.Usuarios;

public class Cliente : Persona
{
    public string Documento { get; private set; }

    public Cliente(
        string nombre,
        string apellido,
        string correoElectronico,
        string telefono,
        string direccion,
        string documento)

        : base(
            nombre,
            apellido,
            correoElectronico,
            telefono,
            direccion)
    {
        Documento = documento;
    }
}