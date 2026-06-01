using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Utilidades;

namespace Proyecto_Integrador.Vistas.Usuarios
{
    public partial class PerfilUsuarioControl : UserControl
    {
        public PerfilUsuarioControl(Usuario usuario)
        {
            InitializeComponent();
            UiHelper.EstilizarPanelTarjeta(panelTarjeta);
            UiHelper.EstilizarEtiquetaRol(lblRol);
            CargarDatos(usuario);
        }

        private void CargarDatos(Usuario usuario)
        {
            lblNombreValor.Text = usuario.NombreCompleto;
            lblUsuarioValor.Text = usuario.NombreUsuario;
            lblCorreoValor.Text = usuario.CorreoElectronico;
            lblTelefonoValor.Text = usuario.Telefono;
            lblDireccionValor.Text = usuario.Direccion;
            lblRol.Text = usuario.Rol.Nombre;

            if (usuario.EsActivo)
            {
                lblEstadoValor.Text = "Activo";
                lblEstadoValor.ForeColor = Color.FromArgb(22, 163, 74);
            }
            else
            {
                lblEstadoValor.Text = "Inactivo";
                lblEstadoValor.ForeColor = Color.FromArgb(220, 38, 38);
            }
        }
    }
}
