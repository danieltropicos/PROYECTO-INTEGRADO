using Proyecto_Integrador.Vistas;
using Proyecto_Integrador.Vistas.Cotizaciones;
using Proyecto_Integrador.Vistas.Layout;
using Proyecto_Integrador.Vistas.Login;

namespace Proyecto_Integrador
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}