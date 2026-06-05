using Proyecto_Integrador.Calculo_Volumen;
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

    private readonly List<PuntoTerreno> _terreno = [];

    private Terreno3DControl terreno3D = null!;

    private Usuario? _usuario;
    private double _ultimoVolumen;

    public event EventHandler? CotizacionGuardada;
    CalculoVolumenCodigo _calculo = new CalculoVolumenCodigo();


    public CotizacionControl()
    {
        materialControlador = new MaterialControlador();
        clienteControlador = new ClienteControlador();
        cotizacionControlador = new CotizacionControlador();

        InitializeComponent();

        cargarClientes();
        cargarMateriales();

        InicializarTerreno();
        CargarDatosPrueba();
    }

    public CotizacionControl(Usuario usuario) : this()
    {
        _usuario = usuario;
    }

    private void InicializarTerreno()
    {
        terreno3D = new Terreno3DControl
        {
            Dock = DockStyle.Fill
        };

        panelGrafica.Controls.Clear();
        panelGrafica.Controls.Add(terreno3D);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var mensaje = CotizacionValidaciones.ValidarAntesDeCalcular(
            comboBoxClientes.SelectedIndex,
            comboBoxMateriales.SelectedIndex,
            _terreno); 

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
            double volumen = _calculo.CalcularVolumenExcavacion(puntosInicio);
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
            cotizacion.EstablecerTerreno(_terreno);

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
        AgregarPunto(txtOrigX, txtOrigY, txtOrigZ, _terreno, dataGridView1);

    private void btnQuitarOriginal_Click(object sender, EventArgs e) =>
        QuitarPuntoSeleccionado(_terreno, dataGridView1);

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
        terreno3D.ActualizarTerreno(_terreno);
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


    private void CargarDatosPrueba()
    {
        _terreno.Clear();

        for (int y = 0; y <= 200; y += 10)
        {
            for (int x = 0; x <= 200; x += 10)
            {
                double cx = 100;
                double cy = 100;

                double d = Math.Sqrt(
                    Math.Pow(x - cx, 2) +
                    Math.Pow(y - cy, 2));

                double borde = 20 - (d * 0.05);
                double crater = -80 * Math.Exp(-(d * d) / 1500);
                double ondulacion =
                    4 * Math.Sin(x * 0.08) +
                    3 * Math.Cos(y * 0.06);

                double z = borde + crater + ondulacion;

                _terreno.Add(
                    new PuntoTerreno(x, y, Math.Round(z, 2)));
            }
        }

        RefrescarGrid(_terreno, dataGridView1);
        ActualizarGrafica();
    }
}
