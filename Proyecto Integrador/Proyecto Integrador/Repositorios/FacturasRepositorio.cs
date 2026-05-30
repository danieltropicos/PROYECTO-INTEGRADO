using Proyecto_Integrador.Modelos.Facturas;
using Proyecto_Integrador.Services;
using Proyecto_Integrador.Vistas.Cotizaciones;
using System.Globalization;
using System.Text.Json;

namespace Proyecto_Integrador.Repositorios;

public class FacturasRepositorio
{
    private static readonly string CarpetaData = "Data";
    private static readonly string RutaArchivo =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CarpetaData, "facturas.json");

    private List<Factura> facturas = [];

    public FacturasRepositorio()
    {
        Cargar();
    }

    private void Cargar()
    {
        if (!File.Exists(RutaArchivo)) return;

        var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        using var reader = new StreamReader(RutaArchivo);
        var json = reader.ReadToEnd();
        var cargadas = JsonSerializer.Deserialize<List<Factura>>(json, opciones);
        if (cargadas != null)
            facturas.AddRange(cargadas);
    }

    private void Guardar()
    {
        Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CarpetaData));

        var opciones = new JsonSerializerOptions { WriteIndented = true };
        using var writer = new StreamWriter(RutaArchivo);
        var json = JsonSerializer.Serialize(facturas, opciones);
        writer.Write(json);
    }

    public void Agregar(Factura factura)
    {
        facturas.Add(factura);
        Guardar();
    }

    public List<Factura> Listar()
    {
        return facturas;
    }

    public void Actualizar(Factura factura)
    {
        var index = facturas.FindIndex(f => f.Id == factura.Id);
        if (index >= 0)
        {
            facturas[index] = factura;
            Guardar();
        }
    }

    public string ImprimirFactura(
        Factura factura,
        byte[]? imgTerrenoOriginal = null,
        byte[]? imgTerrenoFinal = null,
        string? rutaLogo = null)
    {
        var cotizacion = factura.Cotizacion;

        imgTerrenoOriginal ??= cotizacion?.TerrenoOriginal is { Count: >= 3 } original
            ? TerrenoImagenCapturaService.Capturar(original, Terreno3DControl.TipoTerreno.Original)
            : null;

        imgTerrenoFinal ??= cotizacion?.TerrenoFinal is { Count: >= 3 } final
            ? TerrenoImagenCapturaService.Capturar(final, Terreno3DControl.TipoTerreno.Final)
            : null;

        return FacturaPdfGeneradorService.Generar(
            factura,
            imgTerrenoOriginal,
            imgTerrenoFinal,
            rutaLogo);
    }
}
