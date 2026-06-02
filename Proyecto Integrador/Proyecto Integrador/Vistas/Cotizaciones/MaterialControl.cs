using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Cotizaciones;
using Proyecto_Integrador.Vistas.Clientes;
using Proyecto_Integrador.Vistas.Utilidades;

namespace Proyecto_Integrador.Vistas.Cotizaciones
{
    public partial class MaterialControl : UserControl
    {
        private readonly MaterialControlador _controlador = new();
        private readonly ToolTip _toolTip = new();
        private List<Material> _materiales = [];

        public MaterialControl()
        {
            InitializeComponent();
            UiHelper.ConfigurarColumnasGrid(dgvMateriales, colIconoEditar);
            CargarMateriales();
        }

        private void btnNuevoMaterial_Click(object sender, EventArgs e) =>
            AbrirFormularioMaterial();

        private void AbrirFormularioMaterial(Material? material = null)
        {
            var esEditar = material is not null;
            using var form = esEditar ? new MaterialForm(material!) : new MaterialForm();

            if (form.ShowDialog(FindForm()) != DialogResult.OK || form.Entidad is null)
                return;

            if (esEditar)
            {
                _controlador.ActualizarMaterial(material!.Id, form.Entidad);
                MessageBox.Show("Material actualizado exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _controlador.AgregarMaterial(form.Entidad);
                MessageBox.Show("Material agregado exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CargarMateriales();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => CargarMateriales();

        private void CargarMateriales()
        {
            var filtro = txtBuscar.Text.Trim();
            _materiales = _controlador.ObtenerMateriales(
                string.IsNullOrEmpty(filtro) ? null : filtro);

            dgvMateriales.Rows.Clear();
            foreach (var material in _materiales)
            {
                var indice = dgvMateriales.Rows.Add(
                    material.Id,
                    material.Nombre,
                    material.ValorMetroCubicoFormateado);

                dgvMateriales.Rows[indice].Cells[colIconoEditar.Index].Value = IconosAcciones.Editar;
            }
        }

        private void dgvMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == colIconoEditar.Index)
                AbrirFormularioMaterial(_materiales[e.RowIndex]);
        }

        private void dgvMateriales_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ayuda = e.RowIndex >= 0 && e.ColumnIndex == colIconoEditar.Index ? "Editar material" : "";
            _toolTip.SetToolTip(dgvMateriales, ayuda);
            dgvMateriales.Cursor = ayuda.Length > 0 ? Cursors.Hand : Cursors.Default;
        }
    }
}
