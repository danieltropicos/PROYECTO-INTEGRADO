using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Validaciones;

namespace Proyecto_Integrador.Vistas.Clientes
{
    public partial class ClienteForm : Form
    {
        public bool EsEditar { get; private set; }
        public Cliente? Entidad { get; private set; }

        public ClienteForm()
        {
            InitializeComponent();
            Text = "Nuevo cliente";
            btnGuardar.Text = "Guardar";
        }

        public ClienteForm(Cliente cliente) : this()
        {
            EsEditar = true;
            Text = "Editar cliente";
            btnGuardar.Text = "Actualizar";

            textBoxNombre.Text = cliente.Nombre;
            textBoxApellido.Text = cliente.Apellido;
            textBoxCorreo.Text = cliente.CorreoElectronico;
            textBoxTelefono.Text = cliente.Telefono;
            textBoxDireccion.Text = cliente.Direccion;
            textBoxDocumento.Text = cliente.Documento;
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

            Entidad = new Cliente(
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
