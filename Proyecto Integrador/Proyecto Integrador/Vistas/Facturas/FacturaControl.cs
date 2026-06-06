using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Facturas;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Utilidades;
using System.Diagnostics;
using System.Globalization;

namespace Proyecto_Integrador.Vistas.Facturas;

public partial class FacturaControl : UserControl
{
    private readonly FacturaControlador facturaControlador;
    private readonly Usuario _usuario;
    private readonly ToolTip _toolTip = new();
    private List<Factura> _facturas = [];

    private static readonly string[] Estados = ["Pendiente", "Pagada", "Cancelada"];

    public FacturaControl(Usuario usuario)
    {
        _usuario = usuario;
        facturaControlador = new FacturaControlador();
        InitializeComponent();
        UiHelper.ConfigurarColumnasGrid(dgvFacturas, colIconoEstado, colIconoImprimir);
        colIconoEstado.Visible = EsAdmin;
        UiHelper.AjustarAnchosColumnas(dgvFacturas, colIconoEstado, colIconoImprimir);
        CargarFacturas();
    }

    private bool EsAdmin => _usuario.Rol.Nombre == "Admin";

    private void CargarFacturas()
    {
        _facturas = facturaControlador.ListarFacturas();
        dgvFacturas.Rows.Clear();

        var cultura = new CultureInfo("es-CO");

        foreach (var f in _facturas)
        {
            var indice = dgvFacturas.Rows.Add(
                f.Id,
                f.Cliente?.NombreCompleto ?? "N/A",
                f.Total.ToString("C0", cultura),
                f.FechaEmision.ToString("dd/MM/yyyy"),
                f.Estado);

            if (EsAdmin)
                dgvFacturas.Rows[indice].Cells[colIconoEstado.Index].Value = IconosAcciones.CambiarEstado;

            dgvFacturas.Rows[indice].Cells[colIconoImprimir.Index].Value = IconosAcciones.Imprimir;
        }
    }

    private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var factura = _facturas[e.RowIndex];

        if (e.ColumnIndex == colIconoEstado.Index && EsAdmin)
        {
            var siguiente = Estados[(Array.IndexOf(Estados, factura.Estado) + 1) % Estados.Length];

            if (MessageBox.Show(
                    $"¿Cambiar estado de \"{factura.Estado}\" a \"{siguiente}\"?",
                    "Cambiar estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            facturaControlador.CambiarEstado(factura, siguiente);
            CargarFacturas();
            MessageBox.Show($"Estado actualizado a \"{siguiente}\".", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (e.ColumnIndex == colIconoImprimir.Index)
        {
            ImprimirFactura(factura);
        }
    }

    private void ImprimirFactura(Factura factura)
    {
        try
        {
            UseWaitCursor = true;
            dgvFacturas.Enabled = false;

            var ruta = facturaControlador.ImprimirFactura(factura, rutaLogo: RecursosAplicacion.RutaLogoNavbar);

            if (MessageBox.Show("Factura PDF generada. ¿Desea abrirla?", "Factura impresa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(new ProcessStartInfo(ruta) { UseShellExecute = true });
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al generar la factura: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            UseWaitCursor = false;
            dgvFacturas.Enabled = true;
        }
    }

    private void dgvFacturas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
    {
        string ayuda = "";
        if (e.RowIndex >= 0)
        {
            if (e.ColumnIndex == colIconoEstado.Index) ayuda = "Cambiar estado";
            else if (e.ColumnIndex == colIconoImprimir.Index) ayuda = "Imprimir PDF";
        }

        _toolTip.SetToolTip(dgvFacturas, ayuda);
        dgvFacturas.Cursor = ayuda.Length > 0 ? Cursors.Hand : Cursors.Default;
    }
}
