using Proyecto_Integrador.Modelos.Cotizaciones;
using System.Globalization;

namespace Proyecto_Integrador.Vistas.Clientes
{
    public partial class MaterialForm : Form
    {
        public bool EsEditar { get; private set; }
        public Material? Entidad { get; private set; }

        public MaterialForm()
        {
            InitializeComponent();
            Text = "Nuevo material";
            btnGuardar.Text = "Guardar";
        }

        public MaterialForm(Material material) : this()
        {
            EsEditar = true;
            Text = "Editar material";
            btnGuardar.Text = "Actualizar";

            txtNombre.Text = material.Nombre;
            txtValor.Text = material.ValorMetroCubico.ToString("0");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtValor.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out var valor) || valor < 0)
            {
                MessageBox.Show("Ingrese un valor por m³ válido.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Entidad = new Material(txtNombre.Text.Trim(), valor);
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
