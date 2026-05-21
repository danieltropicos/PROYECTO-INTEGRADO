using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Vistas.Clientes
{
    public partial class ClienteForm : Form
    {
        public Cliente? ClienteCreado { get; private set; }

        public ClienteForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(textBoxDocumento.Text))
            {
                MessageBox.Show("Complete nombre, apellido y documento.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClienteCreado = new Cliente(
                textBoxNombre.Text.Trim(),
                textBoxApellido.Text.Trim(),
                textBoxCorreo.Text.Trim(),
                textBoxTelefono.Text.Trim(),
                textBoxDireccion.Text.Trim(),
                textBoxDocumento.Text.Trim());

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
