using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Facturas;
using System.Globalization;

namespace Proyecto_Integrador.Vistas.Facturas;

public partial class FacturaControl : UserControl
{
    private readonly FacturaControlador facturaControlador;
    private List<Factura> _facturas;

    private static readonly string[] Estados = ["Pendiente", "Pagada", "Cancelada"];

    public FacturaControl()
    {
        facturaControlador = new FacturaControlador();
        InitializeComponent();
        CargarFacturas();
    }

    private void CargarFacturas()
    {
        _facturas = facturaControlador.ListarFacturas();
        dgvFacturas.Rows.Clear();

        var cultura = new CultureInfo("es-CO");

        foreach (var f in _facturas)
        {
            dgvFacturas.Rows.Add(
                f.Id,
                f.Cliente?.NombreCompleto ?? "N/A",
                f.Total.ToString("C0", cultura),
                f.FechaEmision.ToString("dd/MM/yyyy"),
                f.Estado
            );
        }
    }

    private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (e.ColumnIndex != dgvFacturas.Columns["colCambiarEstado"].Index) return;

        var factura = _facturas[e.RowIndex];

        var estadoActualIndex = Array.IndexOf(Estados, factura.Estado);
        var siguienteIndex = (estadoActualIndex + 1) % Estados.Length;
        var nuevoEstado = Estados[siguienteIndex];

        var confirmar = MessageBox.Show(
            $"¿Cambiar estado de \"{factura.Estado}\" a \"{nuevoEstado}\"?",
            "Cambiar estado",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmar != DialogResult.Yes) return;

        facturaControlador.CambiarEstado(factura, nuevoEstado);
        CargarFacturas();

        MessageBox.Show(
            $"Estado actualizado a \"{nuevoEstado}\".",
            "Éxito",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
}
