using Proyecto_Integrador.Modelos.Facturas;
using Proyecto_Integrador.Servicios;
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

    public int ContarFacturas(string estado)
    {
        if(!string.IsNullOrEmpty(estado))
        {
            return facturas.Count;
        }
        return facturas.Count(x => x.Estado == estado);
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
        byte[]? imgTerreno = null,
        string? rutaLogo = null)
    {
        var cotizacion = factura.Cotizacion;

        imgTerreno ??= cotizacion?.Terreno is { Count: >= 3 } terreno
            ? TerrenoImagenCapturaServicio.Capturar(terreno)
            : null;

        return FacturaPdfGeneradorServicio.Generar(
            factura,
            imgTerreno,
            rutaLogo);
    }
}
