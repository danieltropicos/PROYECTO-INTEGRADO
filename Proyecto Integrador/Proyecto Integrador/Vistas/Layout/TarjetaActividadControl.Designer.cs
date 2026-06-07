namespace Proyecto_Integrador.Vistas.Layout
{
    partial class TarjetaActividadControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            tableLayoutTarjeta = new TableLayoutPanel();
            panelAcento = new Panel();
            picIcono = new PictureBox();
            panelTexto = new TableLayoutPanel();
            lblTitulo = new Label();
            lblDetalle = new Label();
            lblFecha = new Label();
            tableLayoutTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcono).BeginInit();
            panelTexto.SuspendLayout();
            SuspendLayout();
            //
            // tableLayoutTarjeta
            //
            tableLayoutTarjeta.ColumnCount = 3;
            tableLayoutTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4F));
            tableLayoutTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutTarjeta.Controls.Add(panelAcento, 0, 0);
            tableLayoutTarjeta.Controls.Add(picIcono, 1, 0);
            tableLayoutTarjeta.Controls.Add(panelTexto, 2, 0);
            tableLayoutTarjeta.Dock = DockStyle.Fill;
            tableLayoutTarjeta.Location = new Point(0, 0);
            tableLayoutTarjeta.Margin = new Padding(0);
            tableLayoutTarjeta.Name = "tableLayoutTarjeta";
            tableLayoutTarjeta.RowCount = 1;
            tableLayoutTarjeta.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutTarjeta.Size = new Size(450, 72);
            tableLayoutTarjeta.TabIndex = 0;
            //
            // panelAcento
            //
            panelAcento.BackColor = Color.FromArgb(34, 197, 94);
            panelAcento.Dock = DockStyle.Fill;
            panelAcento.Location = new Point(0, 0);
            panelAcento.Margin = new Padding(0);
            panelAcento.Name = "panelAcento";
            panelAcento.Size = new Size(4, 72);
            panelAcento.TabIndex = 0;
            //
            // picIcono
            //
            picIcono.Dock = DockStyle.Fill;
            picIcono.Location = new Point(4, 0);
            picIcono.Margin = new Padding(8, 10, 4, 10);
            picIcono.Name = "picIcono";
            picIcono.Size = new Size(40, 52);
            picIcono.SizeMode = PictureBoxSizeMode.Zoom;
            picIcono.TabIndex = 1;
            picIcono.TabStop = false;
            //
            // panelTexto
            //
            panelTexto.ColumnCount = 1;
            panelTexto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelTexto.Controls.Add(lblTitulo, 0, 0);
            panelTexto.Controls.Add(lblDetalle, 0, 1);
            panelTexto.Controls.Add(lblFecha, 0, 2);
            panelTexto.Dock = DockStyle.Fill;
            panelTexto.Location = new Point(56, 0);
            panelTexto.Margin = new Padding(4, 10, 10, 10);
            panelTexto.Name = "panelTexto";
            panelTexto.RowCount = 3;
            panelTexto.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panelTexto.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelTexto.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panelTexto.Size = new Size(394, 62);
            panelTexto.TabIndex = 2;
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 58, 95);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(0, 0, 0, 2);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(120, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Actividad";
            //
            // lblDetalle
            //
            lblDetalle.AutoEllipsis = true;
            lblDetalle.Dock = DockStyle.Fill;
            lblDetalle.Font = new Font("Segoe UI", 9F);
            lblDetalle.ForeColor = Color.FromArgb(75, 85, 99);
            lblDetalle.Location = new Point(0, 25);
            lblDetalle.Margin = new Padding(0);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(394, 20);
            lblDetalle.TabIndex = 1;
            lblDetalle.Text = "Detalle";
            //
            // lblFecha
            //
            lblFecha.AutoSize = true;
            lblFecha.Dock = DockStyle.Bottom;
            lblFecha.Font = new Font("Segoe UI", 8.5F);
            lblFecha.ForeColor = Color.FromArgb(156, 163, 175);
            lblFecha.Location = new Point(0, 45);
            lblFecha.Margin = new Padding(0, 4, 0, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(120, 17);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "01/01/2026 · 00:00";
            //
            // TarjetaActividadControl
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            Controls.Add(tableLayoutTarjeta);
            Margin = new Padding(0, 0, 0, 8);
            Name = "TarjetaActividadControl";
            Size = new Size(450, 72);
            tableLayoutTarjeta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picIcono).EndInit();
            panelTexto.ResumeLayout(false);
            panelTexto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutTarjeta;
        private Panel panelAcento;
        private PictureBox picIcono;
        private TableLayoutPanel panelTexto;
        private Label lblTitulo;
        private Label lblDetalle;
        private Label lblFecha;
    }
}
