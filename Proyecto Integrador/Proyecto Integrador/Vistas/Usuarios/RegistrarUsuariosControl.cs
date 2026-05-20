using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;

namespace Proyecto_Integrador.Vistas.Usuarios;

public partial class RegistrarUsuariosControl : UserControl
{
    UsuarioControlador controladorUsuario = new UsuarioControlador();

    public RegistrarUsuariosControl()
    {
        InitializeComponent();
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
