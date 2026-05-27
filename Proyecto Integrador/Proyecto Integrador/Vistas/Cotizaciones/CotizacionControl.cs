using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Cotizaciones;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Cotizaciones.Validaciones;
using System.Globalization;

namespace Proyecto_Integrador.Vistas.Cotizaciones;

public partial class CotizacionControl : UserControl
{
    private readonly MaterialControlador materialControlador;
    private readonly ClienteControlador clienteControlador;
    private readonly CotizacionControlador cotizacionControlador;

    private readonly List<PuntoTerreno> _terrenoOriginal = [];
    private readonly List<PuntoTerreno> _terrenoFinal = [];

    private Terreno3DControl terrenoOriginal3D = null!;
    private Terreno3DControl terrenoFinal3D = null!;

    private Usuario? _usuario;
    private double _ultimoVolumen;

    public event EventHandler? CotizacionGuardada;

    public CotizacionControl()
    {
        materialControlador = new MaterialControlador();
        clienteControlador = new ClienteControlador();
        cotizacionControlador = new CotizacionControlador();

        InitializeComponent();

        cargarClientes();
        cargarMateriales();

        InicializarTerrenos();
        CargarDatosPrueba();
    }

    public CotizacionControl(Usuario usuario) : this()
    {
        _usuario = usuario;
    }

    private void InicializarTerrenos()
    {
        terrenoOriginal3D = new Terreno3DControl(Terreno3DControl.TipoTerreno.Original)
        {
            Dock = DockStyle.Fill
        };

        panelGraficaOriginal.Controls.Clear();
        panelGraficaOriginal.Controls.Add(terrenoOriginal3D);

        terrenoFinal3D = new Terreno3DControl(Terreno3DControl.TipoTerreno.Final)
        {
            Dock = DockStyle.Fill
        };

        panelGraficaFinal.Controls.Clear();
        panelGraficaFinal.Controls.Add(terrenoFinal3D);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var mensaje = CotizacionValidaciones.ValidarAntesDeCalcular(
            comboBoxClientes.SelectedIndex,
            comboBoxMateriales.SelectedIndex,
            _terrenoOriginal,
            _terrenoFinal);

        if (!string.IsNullOrEmpty(mensaje))
        {
            MessageBox.Show(
                mensaje,
                "Cotización incompleta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        try
        {
            List<double[]> puntosInicio = ObtenerPuntosTerreno(dataGridView1);
            List<double[]> puntosFinal = ObtenerPuntosTerreno(dataGridView2);

            double volumen = CalcularVolumenExcavacion(puntosInicio, puntosFinal);
            _ultimoVolumen = volumen;

            MessageBox.Show(
                $"Volumen de excavación: {volumen:F4} m³",
                "Resultado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            label5.Text = $"{volumen.ToString("F4", CultureInfo.CurrentCulture)} m³";

            var materialSeleccionado = comboBoxMateriales.SelectedItem as Material;
            decimal precioMetroCubico = materialSeleccionado?.ValorMetroCubico ?? 0;
            decimal costoTotal = (decimal)volumen * precioMetroCubico;
            label7.Text = costoTotal.ToString("C0", new CultureInfo("es-CO"));

            btnGuardarCotizacion.Visible = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnGuardarCotizacion_Click(object sender, EventArgs e)
    {
        try
        {
            var clientes = clienteControlador.ObtenerClientes();
            var cliente = clientes[comboBoxClientes.SelectedIndex];
            var material = comboBoxMateriales.SelectedItem as Material
                ?? throw new InvalidOperationException("Seleccione un material.");

            var cotizacion = new Cotizacion(cliente, _usuario!, material);
            cotizacion.EstablecerVolumen((decimal)_ultimoVolumen);
            cotizacion.EstablecerTerrenos(_terrenoOriginal, _terrenoFinal);

            cotizacionControlador.AgregarCotizacion(cotizacion);

            MessageBox.Show(
                "Cotización guardada exitosamente.",
                "Guardado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            btnGuardarCotizacion.Visible = false;
            CotizacionGuardada?.Invoke(this, EventArgs.Empty);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnAgregarOriginal_Click(object sender, EventArgs e) =>
        AgregarPunto(txtOrigX, txtOrigY, txtOrigZ, _terrenoOriginal, dataGridView1);

    private void btnQuitarOriginal_Click(object sender, EventArgs e) =>
        QuitarPuntoSeleccionado(_terrenoOriginal, dataGridView1);

    private void btnAgregarFinal_Click(object sender, EventArgs e) =>
        AgregarPunto(txtFinalX, txtFinalY, txtFinalZ, _terrenoFinal, dataGridView2);

    private void btnQuitarFinal_Click(object sender, EventArgs e) =>
        QuitarPuntoSeleccionado(_terrenoFinal, dataGridView2);

    private void AgregarPunto(
        TextBox txtX,
        TextBox txtY,
        TextBox txtZ,
        List<PuntoTerreno> lista,
        DataGridView grid)
    {
        var mensaje = CotizacionValidaciones.ValidarCoordenadasEntrada(
            txtX.Text, txtY.Text, txtZ.Text,
            out var x, out var y, out var z);

        if (!string.IsNullOrEmpty(mensaje))
        {
            MessageBox.Show(mensaje, "Coordenadas inválidas",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        lista.Add(new PuntoTerreno(x, y, z));

        RefrescarGrid(lista, grid);
        ActualizarGrafica();

        txtX.Clear();
        txtY.Clear();
        txtZ.Clear();
        txtX.Focus();
    }

    private void QuitarPuntoSeleccionado(
        List<PuntoTerreno> lista,
        DataGridView grid)
    {
        if (grid.CurrentRow is null || grid.CurrentRow.Index < 0)
        {
            MessageBox.Show("Seleccione un punto.", "Sin selección",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        lista.RemoveAt(grid.CurrentRow.Index);

        RefrescarGrid(lista, grid);
        ActualizarGrafica();
    }

    private void ActualizarGrafica()
    {
        terrenoOriginal3D.ActualizarTerreno(_terrenoOriginal);
        terrenoFinal3D.ActualizarTerreno(_terrenoFinal);
    }

    private void RefrescarGrid(List<PuntoTerreno> puntos, DataGridView grid)
    {
        grid.Rows.Clear();
        foreach (var p in puntos)
            grid.Rows.Add(p.X, p.Y, p.Z);
    }

    private void cargarMateriales()
    {
        var materiales = materialControlador.ObtenerMateriales();

        comboBoxMateriales.Items.Clear();
        comboBoxMateriales.DisplayMember = nameof(Material.Nombre);
        comboBoxMateriales.ValueMember = nameof(Material.Id);
        comboBoxMateriales.DataSource = materiales;
        comboBoxMateriales.SelectedIndex = -1;
    }

    private void cargarClientes()
    {
        var clientes = clienteControlador.ObtenerClientes();

        comboBoxClientes.Items.Clear();
        comboBoxClientes.Items.AddRange(
            clientes.Select(c => c.NombreCompleto).ToArray());
    }

    private void comboBoxMateriales_SelectedIndexChanged(object sender, EventArgs e)
    {
        var material = comboBoxMateriales.SelectedItem as Material;
        textBox1.Text = material?.ValorMetroCubicoFormateado ?? "";
    }

    private List<double[]> ObtenerPuntosTerreno(DataGridView dgv)
    {
        List<double[]> puntos = new List<double[]>();

        foreach (DataGridViewRow fila in dgv.Rows)
        {
            if (fila.IsNewRow)
                continue;

            double x = Convert.ToDouble(fila.Cells[0].Value);
            double y = Convert.ToDouble(fila.Cells[1].Value);
            double z = Convert.ToDouble(fila.Cells[2].Value);

            puntos.Add(new double[] { x, y, z });
        }

        return puntos;
    }

    private double CalcularVolumenExcavacion(
        List<double[]> puntosInicio,
        List<double[]> puntosFinal)
    {
        var xs = puntosInicio.Select(p => p[0]).Distinct().OrderBy(v => v).ToList();
        var ys = puntosInicio.Select(p => p[1]).Distinct().OrderBy(v => v).ToList();

        if (xs.Count < 2 || ys.Count < 2)
            throw new InvalidOperationException(
                "Se necesitan al menos 2 valores distintos de X e Y para integrar.");

        var zInicio = puntosInicio.ToDictionary(
            p => $"{p[0].ToString(CultureInfo.InvariantCulture)}_{p[1].ToString(CultureInfo.InvariantCulture)}",
            p => p[2]);

        var zFinal = puntosFinal.ToDictionary(
            p => $"{p[0].ToString(CultureInfo.InvariantCulture)}_{p[1].ToString(CultureInfo.InvariantCulture)}",
            p => p[2]);

        double ObtenerDeltaZ(double x, double y)
        {
            string clave = $"{x.ToString(CultureInfo.InvariantCulture)}_{y.ToString(CultureInfo.InvariantCulture)}";

            if (!zInicio.TryGetValue(clave, out double zi))
                throw new KeyNotFoundException(
                    $"No se encontró punto de inicio para ({x}, {y})");
            if (!zFinal.TryGetValue(clave, out double zf))
                throw new KeyNotFoundException(
                    $"No se encontró punto final para ({x}, {y})");

            double delta = zi - zf;
            return delta < 0 ? 0 : delta;
        }

        double volumenTotal = 0.0;

        for (int i = 0; i < xs.Count - 1; i++)
        {
            for (int j = 0; j < ys.Count - 1; j++)
            {
                double x0 = xs[i], x1 = xs[i + 1];
                double y0 = ys[j], y1 = ys[j + 1];

                double dx = x1 - x0;
                double dy = y1 - y0;

                double z00 = ObtenerDeltaZ(x0, y0);
                double z10 = ObtenerDeltaZ(x1, y0);
                double z01 = ObtenerDeltaZ(x0, y1);
                double z11 = ObtenerDeltaZ(x1, y1);

                double zPromedio = (z00 + z10 + z01 + z11) / 4.0;
                double volumenCelda = zPromedio * dx * dy;

                volumenTotal += volumenCelda;
            }
        }

        return volumenTotal;
    }

    private void CargarDatosPrueba()
    {
        _terrenoOriginal.Clear();
        _terrenoFinal.Clear();

        _terrenoOriginal.AddRange(new[]
        {
            new PuntoTerreno(-40, -40,  3), new PuntoTerreno(-20, -40,  5), new PuntoTerreno(0, -40,  4), new PuntoTerreno(20, -40,  5), new PuntoTerreno(40, -40,  3),
            new PuntoTerreno(-40, -20,  6), new PuntoTerreno(-20, -20,  9), new PuntoTerreno(0, -20,  8), new PuntoTerreno(20, -20, 10), new PuntoTerreno(40, -20,  5),
            new PuntoTerreno(-40,   0,  7), new PuntoTerreno(-20,   0, 12), new PuntoTerreno(0,   0, 14), new PuntoTerreno(20,   0, 11), new PuntoTerreno(40,   0,  6),
            new PuntoTerreno(-40,  20,  5), new PuntoTerreno(-20,  20,  8), new PuntoTerreno(0,  20,  9), new PuntoTerreno(20,  20,  7), new PuntoTerreno(40,  20,  4),
            new PuntoTerreno(-40,  40,  3), new PuntoTerreno(-20,  40,  4), new PuntoTerreno(0,  40,  5), new PuntoTerreno(20,  40,  4), new PuntoTerreno(40,  40,  3),
        });

        _terrenoFinal.Clear();

        for (int y = -50; y <= 50; y += 10)
        {
            for (int x = -50; x <= 50; x += 10)
            {
                double z = 5;

                if (x >= -20 && x <= 20 &&
                    y >= -20 && y <= 20)
                {
                    z = -20;
                }

                _terrenoFinal.Add(
                    new PuntoTerreno(x, y, z));
            }
        }

        RefrescarGrid(_terrenoOriginal, dataGridView1);
        RefrescarGrid(_terrenoFinal, dataGridView2);
        ActualizarGrafica();
    }
}
