using Proyecto_Integrador.Modelos.Facturas;
using Proyecto_Integrador.Servicios;

namespace Proyecto_Integrador.Repositorios;

public class FacturasRepositorio
{
    private const string NombreArchivo = "facturas.json";

    private List<Factura> facturas = [];

    public FacturasRepositorio()
    {
        Cargar();
    }

    private void Cargar()
    {
        var cargadas = AlmacenJsonCifrado.Cargar<List<Factura>>(NombreArchivo);
        if (cargadas == null)
            return;

        var clienteRepositorio = new ClienteRepositorio();
        foreach (var factura in cargadas)
        {
            var cliente = clienteRepositorio.ObtenerPorId(factura.ClienteId);
            if (cliente != null)
                factura.VincularCliente(cliente);

            facturas.Add(factura);
        }
    }

    private void Guardar() =>
        AlmacenJsonCifrado.Guardar(NombreArchivo, facturas);

    public void Agregar(Factura factura)
    {
        facturas.Add(factura);
        Guardar();
    }

    public List<Factura> Listar() => facturas;

    public int ContarFacturas(string? estado)
    {
        if (string.IsNullOrWhiteSpace(estado))
            return facturas.Count;

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
