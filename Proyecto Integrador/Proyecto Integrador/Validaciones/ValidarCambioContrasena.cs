namespace Proyecto_Integrador.Validaciones;

internal static class ValidarCambioContrasena
{
    public static bool EsValido(string contrasenaActual, string contrasenaNueva, string confirmarContrasena)
    {
        if (string.IsNullOrWhiteSpace(contrasenaActual) ||
            string.IsNullOrWhiteSpace(contrasenaNueva) ||
            string.IsNullOrWhiteSpace(confirmarContrasena))
        {
            MessageBox.Show(
                "Complete todos los campos.",
                "Datos incompletos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }

        if (contrasenaNueva != confirmarContrasena)
        {
            MessageBox.Show(
                "La nueva contraseña y la confirmación no coinciden.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }

        if (contrasenaActual == contrasenaNueva)
        {
            MessageBox.Show(
                "La nueva contraseña debe ser diferente a la actual.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }

        return ValidarContraseña.EsValida(contrasenaNueva);
    }
}
