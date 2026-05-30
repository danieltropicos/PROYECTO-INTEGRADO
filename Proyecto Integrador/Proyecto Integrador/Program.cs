using Proyecto_Integrador.Vistas.Login;
using QuestPDF.Infrastructure;

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
            QuestPDF.Settings.License = LicenseType.Community;
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}