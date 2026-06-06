namespace Proyecto_Integrador.Vistas.Cotizaciones
{
    partial class CargarCoordenadasForm
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
            panelContenido = new Panel();
            txtJson = new TextBox();
            lblInstrucciones = new Label();
            panelBotones = new Panel();
            btnGuardar = new Button();
            btnCancelar = new Button();
            panelContenido.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.White;
            panelContenido.Controls.Add(txtJson);
            panelContenido.Controls.Add(lblInstrucciones);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 0);
            panelContenido.Margin = new Padding(0);
            panelContenido.Name = "panelContenido";
            panelContenido.Padding = new Padding(16);
            panelContenido.Size = new Size(684, 461);
            panelContenido.TabIndex = 0;
            // 
            // txtJson
            // 
            txtJson.AcceptsTab = true;
            txtJson.BorderStyle = BorderStyle.FixedSingle;
            txtJson.Dock = DockStyle.Fill;
            txtJson.Font = new Font("Consolas", 10F);
            txtJson.ForeColor = Color.FromArgb(17, 24, 39);
            txtJson.Location = new Point(16, 88);
            txtJson.Margin = new Padding(0);
            txtJson.Multiline = true;
            txtJson.Name = "txtJson";
            txtJson.ScrollBars = ScrollBars.Both;
            txtJson.Size = new Size(652, 357);
            txtJson.TabIndex = 1;
            txtJson.WordWrap = false;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.Dock = DockStyle.Top;
            lblInstrucciones.Font = new Font("Segoe UI", 9F);
            lblInstrucciones.ForeColor = Color.FromArgb(75, 85, 99);
            lblInstrucciones.Location = new Point(16, 16);
            lblInstrucciones.Margin = new Padding(0, 0, 0, 8);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(652, 72);
            lblInstrucciones.TabIndex = 0;
            lblInstrucciones.Text = "Pegue un arreglo JSON con las coordenadas del terreno.\r\nEjemplo: [{ \"X\": 0, \"Y\": 0, \"Z\": 10 }, { \"X\": 100, \"Y\": 50, \"Z\": 12 }]";
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(243, 244, 246);
            panelBotones.Controls.Add(btnGuardar);
            panelBotones.Controls.Add(btnCancelar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 461);
            panelBotones.Margin = new Padding(0);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(16, 12, 16, 12);
            panelBotones.Size = new Size(684, 60);
            panelBotones.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(245, 158, 11);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(572, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 36);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(229, 231, 235);
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.FromArgb(17, 24, 39);
            btnCancelar.Location = new Point(466, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // CargarCoordenadasForm
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            CancelButton = btnCancelar;
            ClientSize = new Size(684, 521);
            Controls.Add(panelContenido);
            Controls.Add(panelBotones);
            MinimumSize = new Size(560, 420);
            Name = "CargarCoordenadasForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cargar coordenadas";
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenido;
        private Label lblInstrucciones;
        private TextBox txtJson;
        private Panel panelBotones;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}
