using Proyecto_Integrador.Modelos.Cotizaciones;
using Proyecto_Integrador.Vistas.Cotizaciones.Validaciones;

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
            var mensaje = MaterialValidaciones.ValidarEntrada(
                txtNombre.Text,
                txtValor.Text,
                out var valor);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MaterialCreado = new Material(txtNombre.Text.Trim(), valor);
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
