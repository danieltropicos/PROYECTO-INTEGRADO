using System.Globalization;
using Proyecto_Integrador.Modelos.Cotizaciones;

namespace Proyecto_Integrador.Vistas.Cotizaciones.Validaciones;

internal static class MaterialValidaciones
{
    private const int MaxLongitudNombre = 100;
    private const decimal ValorMaximoMetroCubico = 999_999_999m;

    public static string Validar(Material? material)
    {
        if (material is null)
            return "El material no puede ser nulo.";

        if (string.IsNullOrWhiteSpace(material.Nombre))
            return "El nombre es obligatorio.";

        if (material.Nombre.Length > MaxLongitudNombre)
            return $"El nombre no puede tener más de {MaxLongitudNombre} caracteres.";

        if (material.ValorMetroCubico < 0)
            return "El valor por m³ no puede ser negativo.";

        if (material.ValorMetroCubico > ValorMaximoMetroCubico)
            return "El valor por m³ es demasiado alto.";

        return string.Empty;
    }

    public static string ValidarEntrada(string nombre, string valorTexto, out decimal valorMetroCubico)
    {
        valorMetroCubico = 0;

        var materialTemporal = new Material(nombre.Trim(), 0);
        var errorNombre = ValidarNombre(materialTemporal.Nombre);
        if (!string.IsNullOrEmpty(errorNombre))
            return errorNombre;

        if (string.IsNullOrWhiteSpace(valorTexto))
            return "El valor por m³ es obligatorio.";

        if (!decimal.TryParse(
                valorTexto.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out valorMetroCubico))
            return "Ingrese un valor por m³ numérico válido.";

        materialTemporal.ValorMetroCubico = valorMetroCubico;
        return Validar(materialTemporal);
    }

    private static string ValidarNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            return "El nombre es obligatorio.";

        if (nombre.Length > MaxLongitudNombre)
            return $"El nombre no puede tener más de {MaxLongitudNombre} caracteres.";

        return string.Empty;
    }
}
