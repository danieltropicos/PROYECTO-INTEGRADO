namespace Proyecto_Integrador.Vistas.Clientes
{
    partial class ClienteForm
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
            label1 = new Label();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxTelefono = new TextBox();
            textBoxDireccion = new TextBox();
            label4 = new Label();
            textBoxCorreo = new TextBox();
            textBoxDocumento = new TextBox();
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
            panelContenedor.Margin = new Padding(3, 4, 3, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Padding = new Padding(23, 27, 23, 27);
            panelContenedor.Size = new Size(610, 507);
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
            groupBoxDatos.Location = new Point(23, 27);
            groupBoxDatos.Margin = new Padding(3, 4, 3, 4);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Padding = new Padding(14, 11, 14, 16);
            groupBoxDatos.Size = new Size(564, 453);
            groupBoxDatos.TabIndex = 0;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "Nuevo cliente";
            // 
            // tableLayoutDatos
            // 
            tableLayoutDatos.ColumnCount = 3;
            tableLayoutDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutDatos.Controls.Add(label1, 0, 0);
            tableLayoutDatos.Controls.Add(textBoxNombre, 1, 0);
            tableLayoutDatos.Controls.Add(textBoxApellido, 2, 0);
            tableLayoutDatos.Controls.Add(label2, 0, 1);
            tableLayoutDatos.Controls.Add(label3, 0, 2);
            tableLayoutDatos.Controls.Add(textBoxTelefono, 1, 2);
            tableLayoutDatos.Controls.Add(textBoxDireccion, 2, 2);
            tableLayoutDatos.Controls.Add(label4, 0, 3);
            tableLayoutDatos.Controls.Add(textBoxCorreo, 1, 1);
            tableLayoutDatos.Controls.Add(textBoxDocumento, 1, 3);
            tableLayoutDatos.Dock = DockStyle.Fill;
            tableLayoutDatos.Location = new Point(14, 31);
            tableLayoutDatos.Margin = new Padding(3, 4, 3, 4);
            tableLayoutDatos.Name = "tableLayoutDatos";
            tableLayoutDatos.Padding = new Padding(5, 5, 5, 11);
            tableLayoutDatos.RowCount = 4;
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutDatos.Size = new Size(536, 334);
            tableLayoutDatos.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.FromArgb(75, 85, 99);
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(169, 59);
            label1.TabIndex = 0;
            label1.Text = "Nombre y Apellido";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.White;
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Dock = DockStyle.Fill;
            textBoxNombre.Font = new Font("Segoe UI", 10F);
            textBoxNombre.Location = new Point(183, 9);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(169, 30);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BackColor = Color.White;
            textBoxApellido.BorderStyle = BorderStyle.FixedSingle;
            textBoxApellido.Dock = DockStyle.Fill;
            textBoxApellido.Font = new Font("Segoe UI", 10F);
            textBoxApellido.Location = new Point(358, 9);
            textBoxApellido.Margin = new Padding(3, 4, 3, 4);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(170, 30);
            textBoxApellido.TabIndex = 2;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(75, 85, 99);
            label2.Location = new Point(8, 64);
            label2.Name = "label2";
            label2.Size = new Size(169, 59);
            label2.TabIndex = 3;
            label2.Text = "Correo";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(75, 85, 99);
            label3.Location = new Point(8, 123);
            label3.Name = "label3";
            label3.Size = new Size(169, 59);
            label3.TabIndex = 6;
            label3.Text = "Teléfono y Dirección";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.BackColor = Color.White;
            textBoxTelefono.BorderStyle = BorderStyle.FixedSingle;
            textBoxTelefono.Dock = DockStyle.Fill;
            textBoxTelefono.Font = new Font("Segoe UI", 10F);
            textBoxTelefono.Location = new Point(183, 127);
            textBoxTelefono.Margin = new Padding(3, 4, 3, 4);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(169, 30);
            textBoxTelefono.TabIndex = 7;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BackColor = Color.White;
            textBoxDireccion.BorderStyle = BorderStyle.FixedSingle;
            textBoxDireccion.Dock = DockStyle.Fill;
            textBoxDireccion.Font = new Font("Segoe UI", 10F);
            textBoxDireccion.Location = new Point(358, 127);
            textBoxDireccion.Margin = new Padding(3, 4, 3, 4);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(170, 30);
            textBoxDireccion.TabIndex = 8;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(75, 85, 99);
            label4.Location = new Point(8, 182);
            label4.Name = "label4";
            label4.Size = new Size(168, 37);
            label4.TabIndex = 11;
            label4.Text = "Documento";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BackColor = Color.White;
            textBoxCorreo.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutDatos.SetColumnSpan(textBoxCorreo, 2);
            textBoxCorreo.Dock = DockStyle.Fill;
            textBoxCorreo.Font = new Font("Segoe UI", 10F);
            textBoxCorreo.Location = new Point(183, 68);
            textBoxCorreo.Margin = new Padding(3, 4, 3, 4);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(345, 30);
            textBoxCorreo.TabIndex = 14;
            // 
            // textBoxDocumento
            // 
            textBoxDocumento.BackColor = Color.White;
            textBoxDocumento.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutDatos.SetColumnSpan(textBoxDocumento, 2);
            textBoxDocumento.Dock = DockStyle.Fill;
            textBoxDocumento.Font = new Font("Segoe UI", 10F);
            textBoxDocumento.Location = new Point(183, 186);
            textBoxDocumento.Margin = new Padding(3, 4, 3, 4);
            textBoxDocumento.Name = "textBoxDocumento";
            textBoxDocumento.Size = new Size(345, 30);
            textBoxDocumento.TabIndex = 15;
            // 
            // flowLayoutPanelBotones
            // 
            flowLayoutPanelBotones.Controls.Add(btnCancelar);
            flowLayoutPanelBotones.Controls.Add(btnGuardar);
            flowLayoutPanelBotones.Dock = DockStyle.Bottom;
            flowLayoutPanelBotones.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBotones.Location = new Point(14, 365);
            flowLayoutPanelBotones.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelBotones.Name = "flowLayoutPanelBotones";
            flowLayoutPanelBotones.Padding = new Padding(0, 11, 0, 0);
            flowLayoutPanelBotones.Size = new Size(536, 72);
            flowLayoutPanelBotones.TabIndex = 1;
            flowLayoutPanelBotones.WrapContents = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(229, 231, 235);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.FromArgb(17, 24, 39);
            btnCancelar.Location = new Point(370, 11);
            btnCancelar.Margin = new Padding(9, 0, 0, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 53);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(245, 158, 11);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 119, 6);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(195, 11);
            btnGuardar.Margin = new Padding(9, 0, 0, 0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(166, 53);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // ClienteForm
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            CancelButton = btnCancelar;
            ClientSize = new Size(610, 507);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClienteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar cliente";
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
        private Label label1;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private Label label2;
        private Label label3;
        private TextBox textBoxTelefono;
        private TextBox textBoxDireccion;
        private Label label4;
        private TextBox textBoxCorreo;
        private TextBox textBoxDocumento;
        private FlowLayoutPanel flowLayoutPanelBotones;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}
