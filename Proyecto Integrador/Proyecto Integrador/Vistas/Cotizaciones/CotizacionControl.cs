using Proyecto_Integrador.Controladores;
using System.Globalization;

namespace Proyecto_Integrador.Vistas.Cotizaciones;

public partial class CotizacionControl : UserControl
{
    private MaterialControlador materialControlador;
    private ClienteControlador clienteControlador;

    public CotizacionControl()
    {
        materialControlador = new MaterialControlador();
        clienteControlador = new ClienteControlador();
        InitializeComponent();
        cargarClientes();
        cargarMateriales();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            List<double[]> puntosInicio = ObtenerPuntosTerreno(dataGridView1);
            List<double[]> puntosFinal = ObtenerPuntosTerreno(dataGridView2);

            double volumen = CalcularVolumenExcavacion(puntosInicio, puntosFinal);

            MessageBox.Show(
                $"Volumen de excavación: {volumen:F4} m³",
                "Resultado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            labelVolumen.Text = $"{volumen.ToString("F4", CultureInfo.CurrentCulture)} m³";
            labelTotal.Text = (volumen * int.Parse(txtBoxValorM3.Text)).ToString("F2", CultureInfo.CurrentCulture);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       

    }

    private void cargarMateriales()
    {
        var materiales = materialControlador.ObtenerMateriales();
        comboBoxMateriales.Items.Clear();
        comboBoxMateriales.Items.AddRange(materiales.ToArray());
    }

    private void cargarClientes()
    {
        var clientes = clienteControlador.ObtenerClientes();
        comboBoxClientes.Items.Clear();
        comboBoxClientes.Items.AddRange(clientes.Select(c => c.NombreCompleto).ToArray());
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
    // ─── 1. Construir la malla (grilla regular) ───────────────────────────────
    var xs = puntosInicio.Select(p => p[0]).Distinct().OrderBy(v => v).ToList();
    var ys = puntosInicio.Select(p => p[1]).Distinct().OrderBy(v => v).ToList();

    if (xs.Count < 2 || ys.Count < 2)
        throw new InvalidOperationException(
            "Se necesitan al menos 2 valores distintos de X e Y para integrar.");

    // ─── 2. Mapear Z en diccionarios con cultura invariante ───────────────────
    var zInicio = puntosInicio.ToDictionary(
        p => $"{p[0].ToString(CultureInfo.InvariantCulture)}_{p[1].ToString(CultureInfo.InvariantCulture)}",
        p => p[2]);

    var zFinal = puntosFinal.ToDictionary(
        p => $"{p[0].ToString(CultureInfo.InvariantCulture)}_{p[1].ToString(CultureInfo.InvariantCulture)}",
        p => p[2]);

    // ─── 3. Calcular diferencia de Z en cada nodo ─────────────────────────────
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
        return delta < 0 ? 0 : delta; // Solo excavación (corte positivo)
    }

    // ─── 4. Integración doble — Regla del Trapecio 2D ─────────────────────────
    //
    //   V = ∫∫ ΔZ(x,y) dA  ≈  Σᵢ Σⱼ [ (ΔZ₀₀ + ΔZ₁₀ + ΔZ₀₁ + ΔZ₁₁) / 4 ] · Δx · Δy

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

}
