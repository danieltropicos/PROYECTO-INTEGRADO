using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Vistas.Clientes
{
    public partial class ClienteControl : UserControl
    {
        private readonly ClienteControlador _clienteControlador = new();
        private readonly Usuario _usuario;
        private List<Cliente> _clientes = [];

        public ClienteControl(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            colCambiarEstado.Visible = EsAdmin;
            CargarClientes();
        }

        private bool EsAdmin => _usuario.Rol.Nombre == "Admin";

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
            _clientes = _clienteControlador.ObtenerTodosClientes(
                string.IsNullOrEmpty(filtro) ? null : filtro);

            dgvClientes.Rows.Clear();
            foreach (var cliente in _clientes)
            {
                dgvClientes.Rows.Add(
                    cliente.Id,
                    cliente.NombreCompleto,
                    cliente.CorreoElectronico,
                    cliente.Telefono,
                    cliente.Direccion,
                    cliente.Documento,
                    cliente.EsActivo ? "Activo" : "Inactivo",
                    cliente.EsActivo ? "Inactivar" : "Activar"
                );
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!EsAdmin) return;
            if (e.ColumnIndex != dgvClientes.Columns["colCambiarEstado"]!.Index) return;

            var cliente = _clientes[e.RowIndex];
            var accion = cliente.EsActivo ? "inactivar" : "activar";

            var confirmar = MessageBox.Show(
                $"¿Desea {accion} a {cliente.NombreCompleto}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            cliente.CambiarEstado(!cliente.EsActivo);
            _clienteControlador.ActualizarCliente(cliente);
            CargarClientes();

            MessageBox.Show(
                $"Cliente {(cliente.EsActivo ? "activado" : "inactivado")}.",
                "Listo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
