using System.Text.Json;
using Proyecto_Integrador.Modelos.Cotizaciones;
using Proyecto_Integrador.Vistas.Cotizaciones.Validaciones;

namespace Proyecto_Integrador.Vistas.Cotizaciones;

public partial class CargarCoordenadasForm : Form
{
    private static readonly JsonSerializerOptions OpcionesJson = new()
    {
        PropertyNameCaseInsensitive = true,
        WriteIndented = true
    };

    public IReadOnlyList<PuntoTerreno> Puntos { get; private set; } = [];

    public CargarCoordenadasForm(string jsonInicial = "")
    {
        InitializeComponent();
        txtJson.Text = jsonInicial;
        txtJson.Select(0, 0);
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        List<PuntoTerreno>? puntos;
        try
        {
            puntos = JsonSerializer.Deserialize<List<PuntoTerreno>>(txtJson.Text, OpcionesJson);
        }
        catch (JsonException ex)
        {
            MessageBox.Show($"JSON inválido: {ex.Message}", "Coordenadas inválidas",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (puntos is null || puntos.Count == 0)
        {
            MessageBox.Show("Ingrese al menos un punto en el arreglo JSON.",
                "Coordenadas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        for (var i = 0; i < puntos.Count; i++)
        {
            var error = CotizacionValidaciones.ValidarPunto(puntos[i]);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Punto {i + 1}: {error}", "Coordenadas inválidas",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        Puntos = puntos;
        DialogResult = DialogResult.OK;
        Close();
    }
}
