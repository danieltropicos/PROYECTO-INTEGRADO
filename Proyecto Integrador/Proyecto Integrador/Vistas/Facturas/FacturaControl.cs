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
    private List<Factura> _facturas = [];

    private static readonly string[] Estados = ["Pendiente", "Pagada", "Cancelada"];

    public FacturaControl(Usuario usuario)
    {
        _usuario = usuario;
        facturaControlador = new FacturaControlador();
        InitializeComponent();
        colCambiarEstado.Visible = EsAdmin;
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

        var factura = _facturas[e.RowIndex];

        if (e.ColumnIndex == dgvFacturas.Columns["colCambiarEstado"]!.Index)
        {
            if (!EsAdmin) return;

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
        else if (e.ColumnIndex == dgvFacturas.Columns["colImprimir"]!.Index)
        {
            try
            {
                UseWaitCursor = true;
                dgvFacturas.Enabled = false;

                var ruta = facturaControlador.ImprimirFactura(factura, rutaLogo: AppAssets.RutaLogoNavbar);

                var abrir = MessageBox.Show(
                    $"Factura PDF generada. ¿Desea abrirla?",
                    "Factura impresa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (abrir == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo(ruta)
                    {
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al generar la factura: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
                dgvFacturas.Enabled = true;
            }
        }
    }
}
