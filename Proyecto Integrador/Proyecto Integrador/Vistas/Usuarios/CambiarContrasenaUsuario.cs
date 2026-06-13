using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Validaciones;

namespace Proyecto_Integrador.Vistas.Usuarios;

public partial class CambiarContrasenaUsuario : Form
{
    private readonly Usuario _usuario;
    private readonly UsuarioControlador _controlador = new();

    public CambiarContrasenaUsuario(Usuario usuario)
    {
        _usuario = usuario;
        InitializeComponent();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        var actual = txtContrasenaActual.Text;
        var nueva = txtContrasenaNueva.Text;
        var confirmar = txtConfirmarContrasena.Text;

        if (!ValidarCambioContrasena.EsValido(actual, nueva, confirmar))
            return;

        if (!_controlador.CambiarContrasena(_usuario.Id, actual, nueva))
        {
            MessageBox.Show(
                "La contraseña actual no es correcta.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        MessageBox.Show(
            "Contraseña actualizada correctamente.",
            "Éxito",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
