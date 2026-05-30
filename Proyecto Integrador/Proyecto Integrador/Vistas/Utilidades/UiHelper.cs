using System.Drawing.Drawing2D;

namespace Proyecto_Integrador.Vistas.Utilidades
{
    public static class UiHelper
    {
        private static readonly Color AzulPrincipal = Color.FromArgb(30, 58, 95);
        private static readonly Color AzulSecundario = Color.FromArgb(59, 93, 122);
        private static readonly Color NaranjaPrincipal = Color.FromArgb(245, 158, 11);
        private static readonly Color NaranjaOscuro = Color.FromArgb(217, 119, 6);
        private static readonly Color GrisBoton = Color.FromArgb(229, 231, 235);
        private static readonly Color GrisBotonHover = Color.FromArgb(209, 213, 219);
        private static readonly Font FuenteBoton = new("Segoe UI", 10F);

        public static void MarcarBotonSidebarActivo(Button? activo, params Button[] todos)
        {
            foreach (var boton in todos)
            {
                bool esActivo = boton == activo;
                boton.BackColor = esActivo ? AzulSecundario : AzulPrincipal;
                boton.Font = esActivo ? new Font(FuenteBoton, FontStyle.Bold) : FuenteBoton;
            }
        }

        public static void EstilizarBotonPrimario(Button boton, int radio = 10)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = NaranjaPrincipal;
            boton.ForeColor = Color.White;
            boton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;
            boton.UseVisualStyleBackColor = false;
            boton.FlatAppearance.MouseOverBackColor = NaranjaOscuro;
            AplicarEsquinasRedondeadas(boton, radio);
        }

        public static void EstilizarBotonSecundario(Button boton, int radio = 10)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = GrisBoton;
            boton.ForeColor = Color.FromArgb(17, 24, 39);
            boton.Font = new Font("Segoe UI", 10F);
            boton.Cursor = Cursors.Hand;
            boton.UseVisualStyleBackColor = false;
            boton.FlatAppearance.MouseOverBackColor = GrisBotonHover;
            AplicarEsquinasRedondeadas(boton, radio);
        }

        public static void EstilizarBotonNavbar(Button boton, int radio = 8)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = AzulSecundario;
            boton.ForeColor = Color.White;
            boton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            boton.Cursor = Cursors.Hand;
            boton.UseVisualStyleBackColor = false;
            boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 110, 140);
            AplicarEsquinasRedondeadas(boton, radio);
        }

        public static void EstilizarPanelTarjeta(Panel panel, int radio = 12)
        {
            panel.BackColor = Color.White;
            AplicarEsquinasRedondeadas(panel, radio);
        }

        public static void EstilizarEtiquetaRol(Label label, int radio = 8)
        {
            label.BackColor = NaranjaPrincipal;
            label.ForeColor = Color.White;
            label.Padding = new Padding(12, 6, 12, 6);
            label.AutoSize = true;
            AplicarEsquinasRedondeadas(label, radio);
        }

        public static void AplicarEsquinasRedondeadas(Control control, int radio)
        {
            void Actualizar()
            {
                if (control.Width <= 0 || control.Height <= 0)
                    return;

                using var path = CrearRutaRedondeada(control.ClientRectangle, radio);
                control.Region = new Region(path);
            }

            control.Resize += (_, _) => Actualizar();
            control.HandleCreated += (_, _) => Actualizar();
            if (control.IsHandleCreated)
                Actualizar();
        }

        private static GraphicsPath CrearRutaRedondeada(Rectangle bounds, int radio)
        {
            int diametro = radio * 2;
            var path = new GraphicsPath();

            if (bounds.Width < diametro || bounds.Height < diametro)
            {
                path.AddRectangle(bounds);
                return path;
            }

            path.AddArc(bounds.Left, bounds.Top, diametro, diametro, 180, 90);
            path.AddArc(bounds.Right - diametro, bounds.Top, diametro, diametro, 270, 90);
            path.AddArc(bounds.Right - diametro, bounds.Bottom - diametro, diametro, diametro, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - diametro, diametro, diametro, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
