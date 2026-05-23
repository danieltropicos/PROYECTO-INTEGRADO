using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Cotizaciones;
using Proyecto_Integrador.Vistas.Cotizaciones.Validaciones;
using ScottPlot;
using ScottPlot.WinForms;

namespace Proyecto_Integrador.Vistas.Cotizaciones;

public partial class CotizacionControl : UserControl
{
    private readonly MaterialControlador materialControlador;
    private readonly ClienteControlador clienteControlador;
    private readonly List<PuntoTerreno> _terrenoOriginal = [];
    private readonly List<PuntoTerreno> _terrenoFinal = [];

    private FormsPlot formsPlot;

    public CotizacionControl()
    {
        materialControlador = new MaterialControlador();
        clienteControlador = new ClienteControlador();
        InitializeComponent();
        cargarClientes();
        cargarMateriales();
        InicializarGrafica();
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
            MessageBox.Show(mensaje, "Cotización incompleta",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
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
            txtX.Text, txtY.Text, txtZ.Text, out var x, out var y, out var z);

        if (!string.IsNullOrEmpty(mensaje))
        {
            MessageBox.Show(mensaje, "Coordenadas inválidas",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        lista.Add(new PuntoTerreno(x, y, z));
        RefrescarGrid(lista, grid);
        GraficarTerrenos(_terrenoOriginal, _terrenoFinal);
        txtX.Clear();
        txtY.Clear();
        txtZ.Clear();
        txtX.Focus();
    }

    private  void QuitarPuntoSeleccionado(List<PuntoTerreno> lista, DataGridView grid)
    {
        if (grid.CurrentRow is null || grid.CurrentRow.Index < 0)
        {
            MessageBox.Show(
                "Seleccione un punto en la tabla para quitarlo.",
                "Sin selección",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        lista.RemoveAt(grid.CurrentRow.Index);

        RefrescarGrid(lista, grid);
        GraficarTerrenos(_terrenoOriginal, _terrenoFinal);
    }

    private void RefrescarGrid(List<PuntoTerreno> puntos, DataGridView grid)
    {
        grid.Rows.Clear();
        foreach (var punto in puntos)
            grid.Rows.Add(punto.X, punto.Y, punto.Z);
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
        comboBoxClientes.Items.AddRange(clientes.Select(c => c.NombreCompleto).ToArray());
    }

    private void comboBoxMateriales_SelectedIndexChanged(object sender, EventArgs e)
    {
        var materialSeleccionado = comboBoxMateriales.SelectedItem as Material;
        textBox1.Text = materialSeleccionado?.ValorMetroCubicoFormateado ?? "";
    }

    private void InicializarGrafica()
    {
        formsPlot = new FormsPlot();

        formsPlot.Dock = DockStyle.Fill;

        panelGrafica.Controls.Add(formsPlot);

        formsPlot.Plot.Title("Perfil del Terreno");
        formsPlot.Plot.XLabel("Distancia");
        formsPlot.Plot.YLabel("Altura");

        formsPlot.Refresh();
    }

    private void GraficarTerrenos(
    List<PuntoTerreno> original,
    List<PuntoTerreno> final)
    {
        formsPlot.Plot.Clear();

        double[] xOriginal = original.Select(p => (double)p.X).ToArray();
        double[] zOriginal = original.Select(p => (double)p.Z).ToArray();

        double[] xFinal = final.Select(p => (double)p.X).ToArray();
        double[] zFinal = final.Select(p => (double)p.Z).ToArray();

        formsPlot.Plot.Add.Scatter(xOriginal, zOriginal);

        formsPlot.Plot.Add.Scatter(xFinal, zFinal);

        formsPlot.Plot.Title("Comparación de Terrenos");

        formsPlot.Refresh();
    }
}
