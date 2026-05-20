namespace Proyecto_Integrador.Utilidades
{
    public static class UiHelper
    {
        private static readonly Color AzulPrincipal = Color.FromArgb(30, 58, 95);
        private static readonly Color AzulSecundario = Color.FromArgb(59, 93, 122);
        private static readonly Font FuenteBoton = new("Segoe UI", 10F);

        public static void MarcarBotonSidebarActivo(Button activo, params Button[] todos)
        {
            foreach (var boton in todos)
            {
                bool esActivo = boton == activo;
                boton.BackColor = esActivo ? AzulSecundario : AzulPrincipal;
                boton.Font = esActivo ? new Font(FuenteBoton, FontStyle.Bold) : FuenteBoton;
            }
        }
    }
}
