namespace Proyecto_Integrador.Vistas.Utilidades
{
    public static class AppAssets
    {
        public const string CarpetaImagenes = "Recursos/Imagenes";
        public const string ArchivoLogoNavbar = "logo-navbar.png";
        public const string ArchivoLogoCentro = "logo-center.png";
        public const string ArchivoIconoCerrarSesion = "icono-cerrar-sesion.png";
        public const string ArchivoIconoEditar = "icono-editar.png";
        public const string ArchivoIconoActivo = "icono-activo.png";
        public const string ArchivoIconoInactivo = "icono-inactivo.png";
        public const string ArchivoIconoGenerarFactura = "icono-generar-factura.png";
        public const string ArchivoIconoImprimir = "icono-imprimir.png";
        public const string ArchivoIconoCambiarEstado = "icono-cambiar-estado.png";
        public const string ArchivoOjoAbierto = "ojoAbierto.jpg";
        public const string ArchivoOjoCerrado = "ojoCerrado.jpg";

        public static string Ruta(string archivo) =>
            Path.Combine(Application.StartupPath, CarpetaImagenes, archivo);

        public static string RutaLogoNavbar => Ruta(ArchivoLogoNavbar);
        public static string RutaLogoCentro => Ruta(ArchivoLogoCentro);
        public static string RutaIconoCerrarSesion => Ruta(ArchivoIconoCerrarSesion);
    }
}
