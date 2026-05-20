using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Utilidades;

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

        BackColor = AppTheme.FondoPrincipal;
        tableLayoutPanel1.BackColor = AppTheme.FondoPrincipal;
        tableLayoutPanel2.BackColor = AppTheme.FondoPrincipal;
        panel2.BackColor = AppTheme.FondoPrincipal;
        UiHelper.EstilizarGroupBox(groupBox1);
        UiHelper.EstilizarGroupBox(groupBox2);
        UiHelper.EstilizarGroupBox(groupBox3);
        UiHelper.EstilizarGroupBox(groupBox4);
        UiHelper.EstilizarLabel(label1);
        UiHelper.EstilizarLabel(label2);
        UiHelper.EstilizarLabel(label3);
        UiHelper.EstilizarLabel(label4);
        UiHelper.EstilizarLabel(label6);
        UiHelper.EstilizarComboBox(comboBoxClientes);
        UiHelper.EstilizarComboBox(comboBoxMateriales);
        UiHelper.EstilizarTextBox(textBox1);
        UiHelper.EstilizarTablaCotizacion(dataGridView1);
        UiHelper.EstilizarTablaCotizacion(dataGridView2);
        UiHelper.EstilizarBotonPrimario(button1);

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
        comboBoxMateriales.Items.AddRange(materiales.ToArray());
    }

    private void cargarClientes()
    {
        var clientes = clienteControlador.ObtenerClientes();
        comboBoxClientes.Items.Clear();
        comboBoxClientes.Items.AddRange(clientes.Select(c => c.NombreCompleto).ToArray());
    }
}
