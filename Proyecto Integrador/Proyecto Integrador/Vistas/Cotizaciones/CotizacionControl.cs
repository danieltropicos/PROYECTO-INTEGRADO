using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Cotizaciones;
using Proyecto_Integrador.Vistas.Cotizaciones.Validaciones;

namespace Proyecto_Integrador.Vistas.Cotizaciones;

public partial class CotizacionControl : UserControl
{
    private readonly MaterialControlador materialControlador;
    private readonly ClienteControlador clienteControlador;

    private readonly List<PuntoTerreno> _terrenoOriginal = [];
    private readonly List<PuntoTerreno> _terrenoFinal = [];

    private Terreno3DControl terrenoOriginal3D;
    private Terreno3DControl terrenoFinal3D;

    public CotizacionControl()
    {
        materialControlador = new MaterialControlador();
        clienteControlador = new ClienteControlador();

        InitializeComponent();

        cargarClientes();
        cargarMateriales();

        InicializarTerrenos();
        CargarDatosPrueba();
    }

    // =========================
    // INIT VIEW
    // =========================
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

    // =========================
    // VALIDAR / CALCULAR
    // =========================
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

        MessageBox.Show("Cotización lista para calcular", "OK",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // =========================
    // ORIGINAL POINTS
    // =========================
    private void btnAgregarOriginal_Click(object sender, EventArgs e) =>
        AgregarPunto(txtOrigX, txtOrigY, txtOrigZ, _terrenoOriginal, dataGridView1);

    private void btnQuitarOriginal_Click(object sender, EventArgs e) =>
        QuitarPuntoSeleccionado(_terrenoOriginal, dataGridView1);

    // =========================
    // FINAL POINTS
    // =========================
    private void btnAgregarFinal_Click(object sender, EventArgs e) =>
        AgregarPunto(txtFinalX, txtFinalY, txtFinalZ, _terrenoFinal, dataGridView2);

    private void btnQuitarFinal_Click(object sender, EventArgs e) =>
        QuitarPuntoSeleccionado(_terrenoFinal, dataGridView2);

    // =========================
    // CORE LOGIC
    // =========================
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

    // =========================
    // UPDATE VIEW
    // =========================
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

    // =========================
    // DATA LOAD
    // =========================
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

    // =========================
    // TEST DATA — 5 filas × 5 columnas para una malla completa
    // =========================
    private void CargarDatosPrueba()
    {
        _terrenoOriginal.Clear();
        _terrenoFinal.Clear();

        // ── Terreno Original: superficie con lomas suaves ────────
        _terrenoOriginal.AddRange(new[]
        {
            new PuntoTerreno(-40, -40,  3), new PuntoTerreno(-20, -40,  5), new PuntoTerreno(0, -40,  4), new PuntoTerreno(20, -40,  5), new PuntoTerreno(40, -40,  3),
            new PuntoTerreno(-40, -20,  6), new PuntoTerreno(-20, -20,  9), new PuntoTerreno(0, -20,  8), new PuntoTerreno(20, -20, 10), new PuntoTerreno(40, -20,  5),
            new PuntoTerreno(-40,   0,  7), new PuntoTerreno(-20,   0, 12), new PuntoTerreno(0,   0, 14), new PuntoTerreno(20,   0, 11), new PuntoTerreno(40,   0,  6),
            new PuntoTerreno(-40,  20,  5), new PuntoTerreno(-20,  20,  8), new PuntoTerreno(0,  20,  9), new PuntoTerreno(20,  20,  7), new PuntoTerreno(40,  20,  4),
            new PuntoTerreno(-40,  40,  3), new PuntoTerreno(-20,  40,  4), new PuntoTerreno(0,  40,  5), new PuntoTerreno(20,  40,  4), new PuntoTerreno(40,  40,  3),
        });

        // ── Terreno Final: hueco cuadrado con paredes rectas ─────
        // Borde exterior plano (Z=3), rampa al borde del hueco (Z=3→0),
        // paredes verticales simuladas por pendiente brusca, fondo plano (Z=-12)
        _terrenoFinal.Clear();

        _terrenoFinal.Clear();

        for (int y = -50; y <= 50; y += 10)
        {
            for (int x = -50; x <= 50; x += 10)
            {
                double z = 5;

                // Hueco cuadrado
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