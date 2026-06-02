using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Cotizaciones;
using Proyecto_Integrador.Modelos.Facturas;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Utilidades;
using System.Globalization;

namespace Proyecto_Integrador.Vistas.Cotizaciones;

public partial class ListaCotizacionControl : UserControl
{
    private readonly CotizacionControlador cotizacionControlador;
    private readonly FacturaControlador facturaControlador;
    private readonly Usuario _usuario;
    private readonly ToolTip _toolTip = new();
    private List<Cotizacion> _cotizaciones = [];

    public event EventHandler? CrearCotizacionClick;

    public ListaCotizacionControl(Usuario usuario)
    {
        cotizacionControlador = new CotizacionControlador();
        facturaControlador = new FacturaControlador();
        _usuario = usuario;

        InitializeComponent();
        UiHelper.ConfigurarColumnasGrid(dgvCotizaciones, colIconoEstado, colIconoFactura);
        colIconoEstado.Visible = EsAdmin;
        UiHelper.AjustarAnchosColumnas(dgvCotizaciones, colIconoEstado, colIconoFactura);
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
            var indice = dgvCotizaciones.Rows.Add(
                c.Id,
                c.Cliente?.NombreCompleto ?? "N/A",
                c.Material?.Nombre ?? "N/A",
                $"{c.VolumenCalculado:F2} m³",
                c.Total.ToString("C0", cultura),
                c.FechaCreacion.ToString("dd/MM/yyyy"),
                c.Estado);

            if (EsAdmin)
            {
                dgvCotizaciones.Rows[indice].Cells[colIconoEstado.Index].Value =
                    activa ? IconosAcciones.Inactivar : IconosAcciones.Activar;
            }

            dgvCotizaciones.Rows[indice].Cells[colIconoFactura.Index].Value =
                activa ? IconosAcciones.GenerarFactura : null;
        }
    }

    private void btnCrearCotizacion_Click(object sender, EventArgs e) =>
        CrearCotizacionClick?.Invoke(this, EventArgs.Empty);

    private void txtBuscar_TextChanged(object sender, EventArgs e) => CargarCotizaciones();

    private void dgvCotizaciones_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var cotizacion = _cotizaciones[e.RowIndex];

        if (e.ColumnIndex == colIconoEstado.Index && EsAdmin)
        {
            if (cotizacion.Estado == "Activa")
            {
                if (MessageBox.Show(
                        $"¿Inactivar la cotización de {cotizacion.Cliente?.NombreCompleto}?",
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                cotizacionControlador.DesactivarCotizacion(cotizacion);
                MessageBox.Show("Cotización inactivada.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show(
                        $"¿Activar la cotización de {cotizacion.Cliente?.NombreCompleto}?",
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                cotizacionControlador.ActivarCotizacion(cotizacion);
                MessageBox.Show("Cotización activada.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CargarCotizaciones();
        }
        else if (e.ColumnIndex == colIconoFactura.Index && cotizacion.Estado == "Activa")
        {
            if (MessageBox.Show(
                    $"¿Generar factura para la cotización de {cotizacion.Cliente?.NombreCompleto}?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            facturaControlador.AgregarFactura(new Factura(cotizacion));
            MessageBox.Show("Factura generada en estado Pendiente.", "Factura creada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarCotizaciones();
        }
    }

    private void dgvCotizaciones_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
    {
        string ayuda = "";
        if (e.RowIndex >= 0)
        {
            if (e.ColumnIndex == colIconoEstado.Index) ayuda = "Activar o inactivar";
            else if (e.ColumnIndex == colIconoFactura.Index) ayuda = "Generar factura";
        }

        _toolTip.SetToolTip(dgvCotizaciones, ayuda);
        dgvCotizaciones.Cursor = ayuda.Length > 0 ? Cursors.Hand : Cursors.Default;
    }
}
