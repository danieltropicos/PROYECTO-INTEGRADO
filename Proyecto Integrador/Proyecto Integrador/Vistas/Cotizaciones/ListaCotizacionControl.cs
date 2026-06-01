using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Cotizaciones;
using Proyecto_Integrador.Modelos.Facturas;
using Proyecto_Integrador.Modelos.Usuarios;
using System.Globalization;

namespace Proyecto_Integrador.Vistas.Cotizaciones;

public partial class ListaCotizacionControl : UserControl
{
    private readonly CotizacionControlador cotizacionControlador;
    private readonly FacturaControlador facturaControlador;
    private readonly Usuario _usuario;
    private List<Cotizacion> _cotizaciones = [];

    public event EventHandler? CrearCotizacionClick;

    public ListaCotizacionControl(Usuario usuario)
    {
        cotizacionControlador = new CotizacionControlador();
        facturaControlador = new FacturaControlador();
        _usuario = usuario;

        InitializeComponent();
        colInactivar.Visible = EsAdmin;
        CargarCotizaciones();
    }

    private bool EsAdmin => _usuario.Rol.Nombre == "Admin";

    public void CargarCotizaciones()
    {
        var filtro = txtBuscar.Text.Trim().ToLower();
        _cotizaciones = cotizacionControlador.ObtenerCotizaciones();

        if (!string.IsNullOrEmpty(filtro))
        {
            _cotizaciones = _cotizaciones.Where(c =>
                (c.Cliente?.NombreCompleto?.ToLower().Contains(filtro) ?? false) ||
                (c.Material?.Nombre?.ToLower().Contains(filtro) ?? false)
            ).ToList();
        }

        dgvCotizaciones.Rows.Clear();
        var cultura = new CultureInfo("es-CO");

        foreach (var c in _cotizaciones)
        {
            var activa = c.Estado == "Activa";

            dgvCotizaciones.Rows.Add(
                c.Id,
                c.Cliente?.NombreCompleto ?? "N/A",
                c.Material?.Nombre ?? "N/A",
                $"{c.VolumenCalculado:F2} m³",
                c.Total.ToString("C0", cultura),
                c.FechaCreacion.ToString("dd/MM/yyyy"),
                c.Estado,
                activa ? "Inactivar" : "Activar",
                activa ? "Generar Factura" : ""
            );
        }
    }

    private void btnCrearCotizacion_Click(object sender, EventArgs e)
    {
        CrearCotizacionClick?.Invoke(this, EventArgs.Empty);
    }

    private void txtBuscar_TextChanged(object sender, EventArgs e) => CargarCotizaciones();

    private void dgvCotizaciones_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (dgvCotizaciones.Columns[e.ColumnIndex].Name != "colAccion") return;

        var valor = e.FormattedValue?.ToString();
        if (!string.IsNullOrEmpty(valor)) return;

        e.Paint(
            e.ClipBounds,
            DataGridViewPaintParts.Background |
            DataGridViewPaintParts.Border |
            DataGridViewPaintParts.SelectionBackground);

        e.Handled = true;
    }

    private void dgvCotizaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var cotizacion = _cotizaciones[e.RowIndex];

        if (e.ColumnIndex == dgvCotizaciones.Columns["colInactivar"]!.Index)
        {
            if (!EsAdmin) return;

            if (cotizacion.Estado == "Activa")
            {
                var confirmar = MessageBox.Show(
                    $"¿Inactivar la cotización de {cotizacion.Cliente?.NombreCompleto}?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmar != DialogResult.Yes) return;

                cotizacionControlador.DesactivarCotizacion(cotizacion);
                MessageBox.Show(
                    "Cotización inactivada.",
                    "Listo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                var confirmar = MessageBox.Show(
                    $"¿Activar la cotización de {cotizacion.Cliente?.NombreCompleto}?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmar != DialogResult.Yes) return;

                cotizacionControlador.ActivarCotizacion(cotizacion);
                MessageBox.Show(
                    "Cotización activada.",
                    "Listo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            CargarCotizaciones();
        }
        else if (e.ColumnIndex == dgvCotizaciones.Columns["colAccion"]!.Index)
        {
            if (cotizacion.Estado != "Activa") return;

            var confirmar = MessageBox.Show(
                $"¿Generar factura para la cotización de {cotizacion.Cliente?.NombreCompleto}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            var factura = new Factura(cotizacion);
            facturaControlador.AgregarFactura(factura);

            MessageBox.Show(
                "Factura generada en estado Pendiente.",
                "Factura creada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
