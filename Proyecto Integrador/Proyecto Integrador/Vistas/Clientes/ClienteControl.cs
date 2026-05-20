using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Vistas.Clientes
{
    public partial class ClienteControl : UserControl
    {
        private readonly ClienteControlador clienteRepositorio;
        public ClienteControl()
        {
            clienteRepositorio = new ClienteControlador();

            InitializeComponent();
            cargarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente(
                textBoxNombre.Text,
                textBoxApellido.Text,
                textBoxCorreo.Text,
                textBoxTelefono.Text,
                textBoxDireccion.Text,
                textBoxDocumento.Text
            );

            clienteRepositorio.AgregarCliente(cliente);
            cargarClientes();
            limpiarCampos();
            MessageBox.Show("Cliente agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpiarCampos()
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxCorreo.Text = "";
            textBoxTelefono.Text = "";
            textBoxDireccion.Text = "";
            textBoxDocumento.Text = "";
        }

        private void cargarClientes()
        {
            dgvClientes.Rows.Clear();
            var clientes = clienteRepositorio.ObtenerClientes();

            foreach (var cliente in clientes)
            {
                dgvClientes.Rows.Add(
                    cliente.NombreCompleto,
                    cliente.CorreoElectronico,
                    cliente.Telefono,
                    cliente.Direccion,
                    cliente.Documento,
                    cliente.EsActivo
                );
            }
        }
    }
}
