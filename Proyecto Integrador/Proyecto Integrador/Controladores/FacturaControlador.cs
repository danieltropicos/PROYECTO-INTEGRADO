using Proyecto_Integrador.Modelos.Facturas;
using Proyecto_Integrador.Repositorios;

namespace Proyecto_Integrador.Controladores;

public class FacturaControlador
{
    private readonly FacturasRepositorio facturaRepositorio;

    public FacturaControlador()
    {
        facturaRepositorio = new FacturasRepositorio();
    }

    public void AgregarFactura(Factura factura)
    {
        facturaRepositorio.Agregar(factura);
    }

    public List<Factura> ListarFacturas()
    {
        return facturaRepositorio.Listar();
    }

    public void CambiarEstado(Factura factura, string nuevoEstado)
    {
        factura.CambiarEstado(nuevoEstado);
        facturaRepositorio.Actualizar(factura);
    }

    public string ImprimirFactura(
        Factura factura,
        byte[]? imgTerreno = null,
        string? rutaLogo = null)
    { 
        return facturaRepositorio.ImprimirFactura(factura, imgTerreno, rutaLogo);
    }
}
    