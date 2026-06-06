using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Proyecto_Integrador.Vistas.Login
{
    public class PanelLateralLogin : Panel
    {
        private static readonly Color AzulMarca = Color.FromArgb(15, 35, 65);
        private static readonly Color GrisFormulario = Color.FromArgb(237, 241, 245);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image? ImagenMaquina { get; set; }

        public PanelLateralLogin()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            BackColor = GrisFormulario;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            using (var brushGris = new SolidBrush(GrisFormulario))
                g.FillRectangle(brushGris, ClientRectangle);

            var path = CrearFormaChevron(Width, Height);

            using (var brushAzul = new SolidBrush(AzulMarca))
                g.FillPath(brushAzul, path);

            if (ImagenMaquina is not null)
                DibujarFondoMaquina(g, path);
        }

        private static GraphicsPath CrearFormaChevron(int ancho, int alto)
        {
            var punta = Math.Max(32, (int)(ancho * 0.08));

            var path = new GraphicsPath();
            path.AddPolygon(
            [
                new Point(0, 0),
                new Point(ancho, 0),
                new Point(ancho - punta, alto / 2),
                new Point(ancho, alto),
                new Point(0, alto)
            ]);
            return path;
        }

        private void DibujarFondoMaquina(Graphics g, GraphicsPath clip)
        {
            var estado = g.Save();
            g.SetClip(clip);

            var destino = ClientRectangle;
            DibujarImagenCover(g, ImagenMaquina!, destino);

            using var overlayAzul = new LinearGradientBrush(
                destino,
                Color.FromArgb(145, 15, 35, 65),
                Color.FromArgb(255, 15, 35, 65),
                LinearGradientMode.Vertical);
            g.FillRectangle(overlayAzul, destino);

            g.Restore(estado);
        }

        private static void DibujarImagenCover(Graphics g, Image imagen, Rectangle destino)
        {
            var ratioImagen = (float)imagen.Width / imagen.Height;
            var ratioDestino = (float)destino.Width / destino.Height;

            Rectangle origen;
            if (ratioImagen > ratioDestino)
            {
                var anchoOrigen = (int)(imagen.Height * ratioDestino);
                var xOrigen = (imagen.Width - anchoOrigen) / 2;
                origen = new Rectangle(xOrigen, 0, anchoOrigen, imagen.Height);
            }
            else
            {
                var altoOrigen = (int)(imagen.Width / ratioDestino);
                var yOrigen = (imagen.Height - altoOrigen) / 2;
                origen = new Rectangle(0, yOrigen, imagen.Width, altoOrigen);
            }

            g.DrawImage(imagen, destino, origen, GraphicsUnit.Pixel);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using var brushGris = new SolidBrush(GrisFormulario);
            e.Graphics.FillRectangle(brushGris, ClientRectangle);
        }
    }
}
