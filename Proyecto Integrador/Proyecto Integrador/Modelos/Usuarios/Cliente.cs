using System.Text.Json.Serialization;

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
        : base(nombre, apellido, correoElectronico, telefono, direccion)
    {
        Documento = documento;
    }

    [JsonConstructor]
    public Cliente(
        Guid id,
        string nombre,
        string apellido,
        string correoElectronico,
        string telefono,
        string direccion,
        string documento,
        bool esActivo,
        DateTime fechaRegistro)
        : base(id, nombre, apellido, correoElectronico, telefono, direccion, esActivo, fechaRegistro)
    {
        Documento = documento;
    }
}
