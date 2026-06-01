namespace Proyecto_Integrador.Vistas.Utilidades
{
    public static class AppAssets
    {
        public const string CarpetaImagenes = "Recursos/Imagenes";
        public const string ArchivoLogoNavbar = "logo-navbar.png";
        public const string ArchivoLogoCentro = "logo-center.png";
        public const string ArchivoIconoCerrarSesion = "icono-cerrar-sesion.png";

        public static string RutaLogoNavbar =>
            Path.Combine(Application.StartupPath, CarpetaImagenes, ArchivoLogoNavbar);

        public static string RutaLogoCentro =>
            Path.Combine(Application.StartupPath, CarpetaImagenes, ArchivoLogoCentro);

        public static string RutaIconoCerrarSesion =>
            Path.Combine(Application.StartupPath, CarpetaImagenes, ArchivoIconoCerrarSesion);
    }
}
