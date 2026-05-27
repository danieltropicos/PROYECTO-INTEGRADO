using Proyecto_Integrador.Modelos.Facturas;
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

    public string ImprimirFactura(Factura factura)
    {
        var carpetaFacturas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Facturas");
        Directory.CreateDirectory(carpetaFacturas);

        var nombreArchivo = $"Factura_{factura.Id.ToString()[..8]}_{factura.FechaEmision:yyyyMMdd}.txt";
        var rutaArchivo = Path.Combine(carpetaFacturas, nombreArchivo);

        var cultura = new CultureInfo("es-CO");

        var contenido = $"""
        ══════════════════════════════════════════
                       FACTURA
        ══════════════════════════════════════════

        N° Factura:     {factura.Id}
        Fecha Emisión:  {factura.FechaEmision:dd/MM/yyyy HH:mm}
        Estado:         {factura.Estado}

        ──────────────────────────────────────────
        CLIENTE
        ──────────────────────────────────────────
        Nombre:         {factura.Cliente?.NombreCompleto ?? "N/A"}
        Documento:      {factura.Cliente?.Documento ?? "N/A"}
        Teléfono:       {factura.Cliente?.Telefono ?? "N/A"}
        Dirección:      {factura.Cliente?.Direccion ?? "N/A"}

        ──────────────────────────────────────────
        DETALLE DE COTIZACIÓN
        ──────────────────────────────────────────
        Material:       {factura.Cotizacion?.Material?.Nombre ?? "N/A"}
        Valor m³:       {factura.Cotizacion?.Material?.ValorMetroCubico.ToString("C0", cultura) ?? "$0"}
        Volumen:        {factura.Cotizacion?.VolumenCalculado.ToString("F4") ?? "0"} m³

        ──────────────────────────────────────────
        TOTAL
        ──────────────────────────────────────────
        Total:          {factura.Total.ToString("C0", cultura)}

        ══════════════════════════════════════════
        """;

        File.WriteAllText(rutaArchivo, contenido);
        return rutaArchivo;
    }
}
