using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Vistas.Clientes;

namespace Proyecto_Integrador.Vistas.Cotizaciones
{
    public partial class MaterialControl : UserControl
    {
        private readonly MaterialControlador _controlador = new();

        public MaterialControl()
        {
            InitializeComponent();
            CargarMateriales();
        }

        private void btnNuevoMaterial_Click(object sender, EventArgs e)
        {
            using var form = new MaterialForm();
            if (form.ShowDialog(FindForm()) != DialogResult.OK || form.MaterialCreado is null)
                return;

            _controlador.AgregarMaterial(form.MaterialCreado);
            CargarMateriales();
            MessageBox.Show("Material agregado exitosamente", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => CargarMateriales();

        private void CargarMateriales()
        {
            var filtro = txtBuscar.Text.Trim();
            var materiales = _controlador.ObtenerMateriales(
                string.IsNullOrEmpty(filtro) ? null : filtro);

            dgvMateriales.Rows.Clear();
            foreach (var material in materiales)
            {
                dgvMateriales.Rows.Add(
                    material.Nombre,
                    material.ValorMetroCubico.ToString("N2"));
            }
        }
    }
}
