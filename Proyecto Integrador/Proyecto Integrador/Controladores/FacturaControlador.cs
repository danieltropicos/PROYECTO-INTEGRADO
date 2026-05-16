using Proyecto_Integrador.Modelos.Facturas;
using Proyecto_Integrador.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Controladores
{
    internal class FacturaControlador
    {
        FacturasRepositorio facturaRepositorio;

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
    }
}
