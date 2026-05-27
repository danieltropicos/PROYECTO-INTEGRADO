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
        CargarCotizaciones();
    }

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
            dgvCotizaciones.Rows.Add(
                c.Id,
                c.Cliente?.NombreCompleto ?? "N/A",
                c.Material?.Nombre ?? "N/A",
                $"{c.VolumenCalculado:F2} m³",
                c.Total.ToString("C0", cultura),
                c.FechaCreacion.ToString("dd/MM/yyyy"),
                c.Estado
            );
        }
    }

    private void btnCrearCotizacion_Click(object sender, EventArgs e)
    {
        CrearCotizacionClick?.Invoke(this, EventArgs.Empty);
    }

    private void txtBuscar_TextChanged(object sender, EventArgs e) => CargarCotizaciones();

    private void dgvCotizaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (e.ColumnIndex != dgvCotizaciones.Columns["colAccion"].Index) return;

        var cotizacion = _cotizaciones[e.RowIndex];

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
