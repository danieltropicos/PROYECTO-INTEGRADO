namespace Proyecto_Integrador.Vistas.Layout;

public partial class TarjetaActividadControl : UserControl
{
    private static readonly Color ColorBorde = Color.FromArgb(229, 231, 235);

    public TarjetaActividadControl()
    {
        InitializeComponent();
        Paint += (_, e) =>
        {
            using var borde = new Pen(ColorBorde);
            e.Graphics.DrawRectangle(borde, 0, 0, Width - 1, Height - 1);
        };
    }

    public void Mostrar(string titulo, string detalle, DateTime fecha, Color colorAcento, string nombreIcono)
    {
        lblTitulo.Text = titulo;
        lblDetalle.Text = detalle;
        lblFecha.Text = fecha.ToString("dd/MM/yyyy · HH:mm");
        panelAcento.BackColor = colorAcento;
        picIcono.ImageLocation = $"Recursos\\Imagenes\\{nombreIcono}";
        Visible = true;
    }

    public void Ocultar() => Visible = false;
}
