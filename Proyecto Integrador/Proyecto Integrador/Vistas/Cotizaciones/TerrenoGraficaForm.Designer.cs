namespace Proyecto_Integrador.Vistas.Cotizaciones
{
    partial class TerrenoGraficaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelGrafica = new Panel();
            SuspendLayout();
            // 
            // panelGrafica
            // 
            panelGrafica.BackColor = Color.White;
            panelGrafica.Dock = DockStyle.Fill;
            panelGrafica.Location = new Point(0, 0);
            panelGrafica.Margin = new Padding(0);
            panelGrafica.Name = "panelGrafica";
            panelGrafica.Padding = new Padding(8);
            panelGrafica.Size = new Size(984, 661);
            panelGrafica.TabIndex = 0;
            // 
            // TerrenoGraficaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(984, 661);
            Controls.Add(panelGrafica);
            MinimumSize = new Size(720, 480);
            Name = "TerrenoGraficaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gráfica del terreno";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGrafica;
    }
}
