namespace Proyecto_Integrador.Vistas.Utilidades
{
    public static class RecursosAplicacion
    {
        public const string CarpetaImagenes = "Recursos/Imagenes";
        public const string ArchivoLogoNavbar = "logo-navbar.png";
        public const string ArchivoIconoCerrarSesion = "icono-cerrar-sesion.png";
        public const string ArchivoIconoEditar = "icono-editar.png";
        public const string ArchivoIconoActivo = "icono-activo.png";
        public const string ArchivoIconoInactivo = "icono-inactivo.png";
        public const string ArchivoIconoGenerarFactura = "icono-generar-factura.png";
        public const string ArchivoIconoImprimir = "icono-imprimir.png";
        public const string ArchivoIconoCambiarEstadoPendiente = "icono-cambiar-estado-pendiente.png";
        public const string ArchivoIconoCambiarEstadoPagado = "icono-cambiar-estado-pagado.png";
        public const string ArchivoIconoCambiarEstadoCancelado = "icono-cambiar-estado-cancelado.png";
        public const string ArchivoIconoCotizacion = "icono-ver-cotizacion.png";
        public const string ArchivoOjoAbierto = "ojoAbierto.jpg";
        public const string ArchivoOjoCerrado = "ojoCerrado.jpg";

        // Login
        public const string ArchivoLoginFondoMaquina = "login-fondo-maquina.jpg";
        public const string ArchivoLoginLogoGeoterra = "login-logo-geoterra.png";
        public const string ArchivoLoginFondoDerecho = "login-fondo-derecho.png";
        public const string ArchivoLoginIconoFormulario = "login-icono-formulario.png";
        public const string ArchivoIconoEscudo = "icono-escudo.png";

        public static string Ruta(string archivo) =>
            Path.Combine(Application.StartupPath, CarpetaImagenes, archivo);

        public static string RutaLogoNavbar => Ruta(ArchivoLogoNavbar);
        public static string RutaIconoCerrarSesion => Ruta(ArchivoIconoCerrarSesion);
    }
}
