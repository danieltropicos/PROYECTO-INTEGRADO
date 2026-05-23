using Proyecto_Integrador.Modelos.Cotizaciones;

namespace Proyecto_Integrador.Vistas.Clientes
{
    public partial class MaterialForm : Form
    {
        public Material? MaterialCreado { get; private set; }

        public MaterialForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var material = new Material(txtNombre.Text.Trim(), decimal.Parse(txtValor.Text));
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
