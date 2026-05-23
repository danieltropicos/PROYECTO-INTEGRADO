using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Cotizaciones;

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
    }

    private void cargarMateriales()
    {
        var materiales = materialControlador.ObtenerMateriales();
        comboBoxMateriales.Items.Clear();
        comboBoxMateriales.DisplayMember = nameof(Material.Nombre);
        comboBoxMateriales.ValueMember = nameof(Material.Id);
        comboBoxMateriales.DataSource = materiales;
    }

    private void cargarClientes()
    {
        var clientes = clienteControlador.ObtenerClientes();
        comboBoxClientes.Items.Clear();
        comboBoxClientes.Items.AddRange(clientes.Select(c => c.NombreCompleto).ToArray());
    }
}
