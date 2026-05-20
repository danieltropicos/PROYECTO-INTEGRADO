using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Utilidades;

namespace Proyecto_Integrador.Vistas.Usuarios;

public partial class RegistrarUsuariosControl : UserControl
{
    UsuarioControlador controladorUsuario = new UsuarioControlador();

    public RegistrarUsuariosControl()
    {
        InitializeComponent();

        BackColor = AppTheme.FondoPrincipal;
        PanelAdminUsuarios.BackColor = AppTheme.FondoPrincipal;
        UiHelper.EstilizarLabel(label1, esTitulo: true);
        UiHelper.EstilizarLabelsEn(tableLayoutFormulario);
        UiHelper.EstilizarTextBoxesEn(tableLayoutFormulario);
        UiHelper.EstilizarBotonPrimario(btnRegistrar);
        UiHelper.EstilizarBotonSecundario(btnLimpiar);
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        Rol nuevorol = new Rol("Usuario");
        Usuario usuarionuevo = new Usuario(txtNombreUsu.Text, txtApellidoUsu.Text, txtCorreoUsu.Text, txtTelefonoUsu.Text, txtDireccionUsu.Text, txtNombreUsuarioUsu.Text, txtContrasenaUsu.Text, nuevorol, true);
        controladorUsuario.AgregarUsuario(usuarionuevo);
        Limpiar();
    }

    private void Limpiar()
    {
        txtNombreUsu.Clear();
        txtApellidoUsu.Clear();
        txtCorreoUsu.Clear();
        txtTelefonoUsu.Clear();
        txtDireccionUsu.Clear();
        txtNombreUsuarioUsu.Clear();
        txtContrasenaUsu.Clear();
    }
}
