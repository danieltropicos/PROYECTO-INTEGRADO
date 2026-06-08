using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Proyecto_Integrador.Validaciones
{
    internal class ValidarContraseña
    {
        public static bool EsValida(string contrasena)
        {
            if (contrasena.Length < 8)
            {
                MessageBox.Show(
                    "La contraseña debe tener al menos 8 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!contrasena.Any(char.IsUpper))
            {
                MessageBox.Show(
                    "La contraseña debe contener al menos una letra mayúscula.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!contrasena.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "La contraseña debe contener al menos un número.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(contrasena, @"[^a-zA-Z0-9]"))
            {
                MessageBox.Show(
                    "La contraseña debe contener al menos un carácter especial.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
