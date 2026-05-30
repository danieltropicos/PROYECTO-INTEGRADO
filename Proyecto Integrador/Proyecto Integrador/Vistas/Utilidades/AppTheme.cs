namespace Proyecto_Integrador.Vistas.Utilidades
{
    public static class AppTheme
    {
        public static Color AzulPrincipal => Color.FromArgb(0x1E, 0x3A, 0x5F);
        public static Color AzulSecundario => Color.FromArgb(0x3B, 0x5D, 0x7A);
        public static Color NaranjaPrincipal => Color.FromArgb(0xF5, 0x9E, 0x0B);
        public static Color NaranjaOscuro => Color.FromArgb(0xD9, 0x77, 0x06);
        public static Color FondoPrincipal => Color.FromArgb(0xF3, 0xF4, 0xF6);
        public static Color FondoSecundario => Color.FromArgb(0xE5, 0xE7, 0xEB);
        public static Color Blanco => Color.FromArgb(0xFF, 0xFF, 0xFF);
        public static Color TextoPrincipal => Color.FromArgb(0x11, 0x18, 0x27);
        public static Color TextoSecundario => Color.FromArgb(0x4B, 0x55, 0x63);
        public static Color VerdeExito => Color.FromArgb(0x16, 0xA3, 0x4A);
        public static Color RojoAlerta => Color.FromArgb(0xDC, 0x26, 0x26);

        public static Font FuenteTitulo => new("Segoe UI", 14F, FontStyle.Bold);
        public static Font FuenteSubtitulo => new("Segoe UI", 11F, FontStyle.Bold);
        public static Font FuenteNormal => new("Segoe UI", 10F, FontStyle.Regular);
        public static Font FuenteInput => new("Segoe UI", 10F, FontStyle.Regular);
        public static Font FuenteBoton => new("Segoe UI", 10F, FontStyle.Regular);

        public const int AlturaBoton = 42;
        public const int AnchoBoton = 150;
    }
}
