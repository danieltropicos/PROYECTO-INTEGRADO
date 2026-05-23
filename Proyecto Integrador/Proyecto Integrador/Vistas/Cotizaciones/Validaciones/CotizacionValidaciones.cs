using System.Globalization;
using Proyecto_Integrador.Modelos.Cotizaciones;

namespace Proyecto_Integrador.Vistas.Cotizaciones.Validaciones;

internal static class CotizacionValidaciones
{
    private const int MinPuntosPorTerreno = 3;
    private const decimal CoordenadaMaxima = 1_000_000m;
    private const decimal CoordenadaMinima = -1_000_000m;

    public static string Validar(Cotizacion? cotizacion)
    {
        if (cotizacion is null)
            return "La cotización no puede ser nula.";

        if (cotizacion.Cliente is null)
            return "Debe seleccionar un cliente.";

        if (cotizacion.UsuarioCreador is null)
            return "El usuario creador es obligatorio.";

        if (cotizacion.Material is null)
            return "Debe seleccionar un material.";

        var errorMaterial = MaterialValidaciones.Validar(cotizacion.Material);
        if (!string.IsNullOrEmpty(errorMaterial))
            return errorMaterial;

        var errorOriginal = ValidarTerreno(cotizacion.TerrenoOriginal, "terreno original");
        if (!string.IsNullOrEmpty(errorOriginal))
            return errorOriginal;

        var errorFinal = ValidarTerreno(cotizacion.TerrenoFinal, "terreno final");
        if (!string.IsNullOrEmpty(errorFinal))
            return errorFinal;

        if (cotizacion.VolumenCalculado < 0)
            return "El volumen calculado no puede ser negativo.";

        return string.Empty;
    }

    public static string ValidarAntesDeCalcular(
        int indiceCliente,
        int indiceMaterial,
        IReadOnlyList<PuntoTerreno> terrenoOriginal,
        IReadOnlyList<PuntoTerreno> terrenoFinal)
    {
        if (indiceCliente < 0)
            return "Debe seleccionar un cliente.";

        if (indiceMaterial < 0)
            return "Debe seleccionar un material.";

        var errorOriginal = ValidarTerreno(terrenoOriginal, "terreno original");
        if (!string.IsNullOrEmpty(errorOriginal))
            return errorOriginal;

        var errorFinal = ValidarTerreno(terrenoFinal, "terreno final");
        if (!string.IsNullOrEmpty(errorFinal))
            return errorFinal;

        return string.Empty;
    }

    public static string ValidarCoordenadasEntrada(
        string xTexto,
        string yTexto,
        string zTexto,
        out decimal x,
        out decimal y,
        out decimal z)
    {
        x = 0;
        y = 0;
        z = 0;

        if (!TryParseCoordenada(xTexto, out x))
            return "La coordenada X debe ser un número válido.";

        if (!TryParseCoordenada(yTexto, out y))
            return "La coordenada Y debe ser un número válido.";

        if (!TryParseCoordenada(zTexto, out z))
            return "La coordenada Z debe ser un número válido.";

        return ValidarPunto(new PuntoTerreno(x, y, z));
    }

    public static string ValidarPunto(PuntoTerreno? punto)
    {
        if (punto is null)
            return "El punto no puede ser nulo.";

        if (!EsCoordenadaValida(punto.X))
            return "La coordenada X está fuera del rango permitido.";

        if (!EsCoordenadaValida(punto.Y))
            return "La coordenada Y está fuera del rango permitido.";

        if (!EsCoordenadaValida(punto.Z))
            return "La coordenada Z está fuera del rango permitido.";

        return string.Empty;
    }

    public static string ValidarTerreno(IReadOnlyList<PuntoTerreno>? puntos, string nombreTerreno)
    {
        if (puntos is null || puntos.Count == 0)
            return $"Debe agregar al menos un punto al {nombreTerreno}.";

        if (puntos.Count < MinPuntosPorTerreno)
            return $"El {nombreTerreno} debe tener al menos {MinPuntosPorTerreno} puntos.";

        foreach (var punto in puntos)
        {
            var errorPunto = ValidarPunto(punto);
            if (!string.IsNullOrEmpty(errorPunto))
                return errorPunto;
        }

        return string.Empty;
    }

    private static bool TryParseCoordenada(string texto, out decimal valor) =>
        decimal.TryParse(
            texto.Trim(),
            NumberStyles.Number,
            CultureInfo.CurrentCulture,
            out valor);

    private static bool EsCoordenadaValida(decimal valor) =>
        valor >= CoordenadaMinima && valor <= CoordenadaMaxima;
}
