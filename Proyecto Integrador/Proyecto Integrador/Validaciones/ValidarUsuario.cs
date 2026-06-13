namespace Proyecto_Integrador.Validaciones;

internal static class ValidarUsuario
{
    public static bool EsValidoParaGuardar(
        string nombre,
        string apellido,
        string nombreUsuario,
        bool esNuevo,
        string contrasena)
    {
        if (string.IsNullOrWhiteSpace(nombre) ||
            string.IsNullOrWhiteSpace(apellido) ||
            string.IsNullOrWhiteSpace(nombreUsuario))
        {
            MessageBox.Show(
                "Complete los campos obligatorios.",
                "Datos incompletos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }

        if (!ValidarNombreApellido.EsValido(nombre))
            return false;

        if (!ValidarNombreApellido.EsValido(apellido))
            return false;

        if (esNuevo && string.IsNullOrWhiteSpace(contrasena))
        {
            MessageBox.Show(
                "Ingrese la contraseña.",
                "Datos incompletos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }

        if (esNuevo && !ValidarContraseña.EsValida(contrasena))
            return false;

        return true;
    }
}
