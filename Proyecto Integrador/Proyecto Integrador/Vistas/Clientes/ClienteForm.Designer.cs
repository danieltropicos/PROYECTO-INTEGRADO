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
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Padding = new Padding(20);
            panelContenedor.Size = new Size(534, 380);
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
            groupBoxDatos.Location = new Point(20, 20);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Padding = new Padding(12, 8, 12, 12);
            groupBoxDatos.Size = new Size(494, 340);
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
            tableLayoutDatos.Location = new Point(12, 24);
            tableLayoutDatos.Name = "tableLayoutDatos";
            tableLayoutDatos.Padding = new Padding(4, 4, 4, 8);
            tableLayoutDatos.RowCount = 4;
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutDatos.Size = new Size(470, 244);
            tableLayoutDatos.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.FromArgb(75, 85, 99);
            label1.Location = new Point(7, 4);
            label1.Name = "label1";
            label1.Size = new Size(147, 44);
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
            textBoxNombre.Location = new Point(160, 7);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(148, 25);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BackColor = Color.White;
            textBoxApellido.BorderStyle = BorderStyle.FixedSingle;
            textBoxApellido.Dock = DockStyle.Fill;
            textBoxApellido.Font = new Font("Segoe UI", 10F);
            textBoxApellido.Location = new Point(314, 7);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(149, 25);
            textBoxApellido.TabIndex = 2;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(75, 85, 99);
            label2.Location = new Point(7, 48);
            label2.Name = "label2";
            label2.Size = new Size(147, 44);
            label2.TabIndex = 3;
            label2.Text = "Correo";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(75, 85, 99);
            label3.Location = new Point(7, 92);
            label3.Name = "label3";
            label3.Size = new Size(147, 44);
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
            textBoxTelefono.Location = new Point(160, 95);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(148, 25);
            textBoxTelefono.TabIndex = 7;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BackColor = Color.White;
            textBoxDireccion.BorderStyle = BorderStyle.FixedSingle;
            textBoxDireccion.Dock = DockStyle.Fill;
            textBoxDireccion.Font = new Font("Segoe UI", 10F);
            textBoxDireccion.Location = new Point(314, 95);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(149, 25);
            textBoxDireccion.TabIndex = 8;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(75, 85, 99);
            label4.Location = new Point(7, 136);
            label4.Name = "label4";
            label4.Size = new Size(147, 28);
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
            textBoxCorreo.Location = new Point(160, 51);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(303, 25);
            textBoxCorreo.TabIndex = 14;
            // 
            // textBoxDocumento
            // 
            textBoxDocumento.BackColor = Color.White;
            textBoxDocumento.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutDatos.SetColumnSpan(textBoxDocumento, 2);
            textBoxDocumento.Dock = DockStyle.Fill;
            textBoxDocumento.Font = new Font("Segoe UI", 10F);
            textBoxDocumento.Location = new Point(160, 139);
            textBoxDocumento.Name = "textBoxDocumento";
            textBoxDocumento.Size = new Size(303, 25);
            textBoxDocumento.TabIndex = 15;
            // 
            // flowLayoutPanelBotones
            // 
            flowLayoutPanelBotones.Controls.Add(btnCancelar);
            flowLayoutPanelBotones.Controls.Add(btnGuardar);
            flowLayoutPanelBotones.Dock = DockStyle.Bottom;
            flowLayoutPanelBotones.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBotones.Location = new Point(12, 268);
            flowLayoutPanelBotones.Name = "flowLayoutPanelBotones";
            flowLayoutPanelBotones.Padding = new Padding(0, 8, 0, 0);
            flowLayoutPanelBotones.Size = new Size(470, 60);
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
            btnCancelar.Location = new Point(325, 8);
            btnCancelar.Margin = new Padding(8, 0, 0, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 40);
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
            btnGuardar.Location = new Point(172, 8);
            btnGuardar.Margin = new Padding(8, 0, 0, 0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(145, 40);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // ClienteForm
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            CancelButton = btnCancelar;
            ClientSize = new Size(534, 380);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
