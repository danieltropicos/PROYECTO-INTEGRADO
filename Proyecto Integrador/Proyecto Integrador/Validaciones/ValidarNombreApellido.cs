using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Validaciones
{
    internal class ValidarNombreApellido
    {
        public static bool EsValido(string nombre)
        {
            if (nombre.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "El nombre o apellido no puede contener números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
