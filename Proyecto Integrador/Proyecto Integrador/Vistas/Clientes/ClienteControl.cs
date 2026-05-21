using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Vistas.Clientes
{
    public partial class ClienteControl : UserControl
    {
        private readonly ClienteControlador _clienteControlador = new();

        public ClienteControl()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            using var form = new ClienteForm();
            if (form.ShowDialog(FindForm()) != DialogResult.OK || form.ClienteCreado is null)
                return;

            _clienteControlador.AgregarCliente(form.ClienteCreado);
            CargarClientes();
            MessageBox.Show("Cliente agregado exitosamente", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => CargarClientes();

        private void CargarClientes()
        {
            var filtro = txtBuscar.Text.Trim();
            var clientes = _clienteControlador.ObtenerClientes(
                string.IsNullOrEmpty(filtro) ? null : filtro);

            dgvClientes.Rows.Clear();
            foreach (var cliente in clientes)
            {
                dgvClientes.Rows.Add(
                    cliente.NombreCompleto,
                    cliente.CorreoElectronico,
                    cliente.Telefono,
                    cliente.Direccion,
                    cliente.Documento,
                    cliente.EsActivo);
            }
        }
    }
}
