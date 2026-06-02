using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Utilidades;

namespace Proyecto_Integrador.Vistas.Clientes
{
    public partial class ClienteControl : UserControl
    {
        private readonly ClienteControlador _clienteControlador = new();
        private readonly ToolTip _toolTip = new();
        private List<Cliente> _clientes = [];

        public ClienteControl(Usuario _)
        {
            InitializeComponent();
            UiHelper.ConfigurarColumnasGrid(dgvClientes, colIconoEditar);
            CargarClientes();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e) =>
            AbrirFormularioCliente();

        private void AbrirFormularioCliente(Cliente? cliente = null)
        {
            var esEditar = cliente is not null;
            using var form = esEditar ? new ClienteForm(cliente!) : new ClienteForm();

            if (form.ShowDialog(FindForm()) != DialogResult.OK || form.Entidad is null)
                return;

            if (esEditar)
            {
                var actualizado = form.Entidad;
                actualizado.CambiarEstado(cliente!.EsActivo);
                _clienteControlador.ActualizarCliente(cliente.Id, actualizado);
                MessageBox.Show("Cliente actualizado exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _clienteControlador.AgregarCliente(form.Entidad);
                MessageBox.Show("Cliente agregado exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CargarClientes();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => CargarClientes();

        private void CargarClientes()
        {
            var filtro = txtBuscar.Text.Trim();
            _clientes = _clienteControlador.ObtenerClientes(
                string.IsNullOrEmpty(filtro) ? null : filtro);

            dgvClientes.Rows.Clear();
            foreach (var cliente in _clientes)
            {
                var indice = dgvClientes.Rows.Add(
                    cliente.Id,
                    cliente.NombreCompleto,
                    cliente.CorreoElectronico,
                    cliente.Telefono,
                    cliente.Direccion,
                    cliente.Documento);

                dgvClientes.Rows[indice].Cells[colIconoEditar.Index].Value = IconosAcciones.Editar;
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colIconoEditar.Index)
                AbrirFormularioCliente(_clientes[e.RowIndex]);
        }

        private void dgvClientes_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ayuda = "";
            if (e.RowIndex >= 0 && e.ColumnIndex == colIconoEditar.Index)
                ayuda = "Editar cliente";

            _toolTip.SetToolTip(dgvClientes, ayuda);
            dgvClientes.Cursor = ayuda.Length > 0 ? Cursors.Hand : Cursors.Default;
        }
    }
}
