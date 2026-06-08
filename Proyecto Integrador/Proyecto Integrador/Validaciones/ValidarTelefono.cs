using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Validaciones
{
    internal class ValidarTelefono
    {
        public static bool EsValido(string telefono)
        {
            if (!telefono.All(char.IsDigit))
            {
                MessageBox.Show(
                    "El teléfono solo puede contener números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
