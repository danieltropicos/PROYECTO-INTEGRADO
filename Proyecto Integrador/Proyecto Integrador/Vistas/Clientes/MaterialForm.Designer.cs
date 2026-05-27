namespace Proyecto_Integrador.Vistas.Clientes
{
    partial class MaterialForm
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
            panelContenedor = new Panel();
            groupBoxDatos = new GroupBox();
            tableLayoutDatos = new TableLayoutPanel();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblValor = new Label();
            txtValor = new TextBox();
            flowLayoutPanelBotones = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panelContenedor.SuspendLayout();
            groupBoxDatos.SuspendLayout();
            tableLayoutDatos.SuspendLayout();
            flowLayoutPanelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(243, 244, 246);
            panelContenedor.Controls.Add(groupBoxDatos);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Padding = new Padding(16);
            panelContenedor.Size = new Size(420, 220);
            panelContenedor.TabIndex = 0;
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.BackColor = Color.White;
            groupBoxDatos.Controls.Add(tableLayoutDatos);
            groupBoxDatos.Controls.Add(flowLayoutPanelBotones);
            groupBoxDatos.Dock = DockStyle.Fill;
            groupBoxDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxDatos.ForeColor = Color.FromArgb(30, 58, 95);
            groupBoxDatos.Location = new Point(16, 16);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Padding = new Padding(12, 8, 12, 12);
            groupBoxDatos.Size = new Size(388, 188);
            groupBoxDatos.TabIndex = 0;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "Nuevo material";
            // 
            // tableLayoutDatos
            // 
            tableLayoutDatos.ColumnCount = 2;
            tableLayoutDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDatos.Controls.Add(lblNombre, 0, 0);
            tableLayoutDatos.Controls.Add(txtNombre, 1, 0);
            tableLayoutDatos.Controls.Add(lblValor, 0, 1);
            tableLayoutDatos.Controls.Add(txtValor, 1, 1);
            tableLayoutDatos.Dock = DockStyle.Fill;
            tableLayoutDatos.Location = new Point(12, 24);
            tableLayoutDatos.Name = "tableLayoutDatos";
            tableLayoutDatos.Padding = new Padding(4);
            tableLayoutDatos.RowCount = 2;
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutDatos.Size = new Size(364, 74);
            tableLayoutDatos.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Segoe UI", 9F);
            lblNombre.ForeColor = Color.FromArgb(75, 85, 99);
            lblNombre.Location = new Point(7, 4);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(104, 36);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Dock = DockStyle.Fill;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(117, 7);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(240, 25);
            txtNombre.TabIndex = 1;
            // 
            // lblValor
            // 
            lblValor.Dock = DockStyle.Fill;
            lblValor.Font = new Font("Segoe UI", 9F);
            lblValor.ForeColor = Color.FromArgb(75, 85, 99);
            lblValor.Location = new Point(7, 40);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(104, 36);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor m³";
            lblValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtValor
            // 
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Dock = DockStyle.Fill;
            txtValor.Font = new Font("Segoe UI", 10F);
            txtValor.Location = new Point(117, 43);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(240, 25);
            txtValor.TabIndex = 3;
            // 
            // flowLayoutPanelBotones
            // 
            flowLayoutPanelBotones.Controls.Add(btnCancelar);
            flowLayoutPanelBotones.Controls.Add(btnGuardar);
            flowLayoutPanelBotones.Dock = DockStyle.Bottom;
            flowLayoutPanelBotones.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBotones.Location = new Point(12, 98);
            flowLayoutPanelBotones.Name = "flowLayoutPanelBotones";
            flowLayoutPanelBotones.Padding = new Padding(0, 8, 0, 0);
            flowLayoutPanelBotones.Size = new Size(364, 78);
            flowLayoutPanelBotones.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(229, 231, 235);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.FromArgb(17, 24, 39);
            btnCancelar.Location = new Point(241, 11);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(245, 158, 11);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(110, 8);
            btnGuardar.Margin = new Padding(0, 0, 8, 0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // MaterialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 220);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MaterialForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo material";
            panelContenedor.ResumeLayout(false);
            groupBoxDatos.ResumeLayout(false);
            tableLayoutDatos.ResumeLayout(false);
            tableLayoutDatos.PerformLayout();
            flowLayoutPanelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private GroupBox groupBoxDatos;
        private TableLayoutPanel tableLayoutDatos;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblValor;
        private TextBox txtValor;
        private FlowLayoutPanel flowLayoutPanelBotones;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}
