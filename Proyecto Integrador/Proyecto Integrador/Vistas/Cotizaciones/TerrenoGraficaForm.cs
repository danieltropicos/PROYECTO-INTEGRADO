using Proyecto_Integrador.Modelos.Cotizaciones;

namespace Proyecto_Integrador.Vistas.Cotizaciones;

public partial class TerrenoGraficaForm : Form
{
    private readonly Terreno3DControl _terreno3D = new() { Dock = DockStyle.Fill };

    public TerrenoGraficaForm(IReadOnlyList<PuntoTerreno> puntos, string titulo)
    {
        InitializeComponent();
        Text = titulo;

        panelGrafica.Controls.Add(_terreno3D);
        _terreno3D.ActualizarTerreno(puntos);
    }
}
