namespace Proyecto_Integrador.Vistas.Clientes
{
    partial class ClienteControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxTelefono = new TextBox();
            textBoxDireccion = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanelAcciones = new FlowLayoutPanel();
            textBoxCorreo = new TextBox();
            textBoxDocumento = new TextBox();
            dgvClientes = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colDocumento = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvClientes, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.BackColor = Color.FromArgb(243, 244, 246);
            tableLayoutPanel1.Size = new Size(545, 581);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.BackColor = Color.FromArgb(243, 244, 246);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 351);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 227);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.BackColor = Color.White;
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(30, 58, 95);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Cliente";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxNombre, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxApellido, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(textBoxTelefono, 1, 2);
            tableLayoutPanel2.Controls.Add(textBoxDireccion, 2, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(flowLayoutPanelAcciones, 1, 4);
            tableLayoutPanel2.Controls.Add(textBoxCorreo, 1, 1);
            tableLayoutPanel2.Controls.Add(textBoxDocumento, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(8, 4, 8, 8);
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel2.SetColumnSpan(flowLayoutPanelAcciones, 2);
            tableLayoutPanel2.Size = new Size(533, 205);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = false;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(75, 85, 99);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 41);
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
            textBoxNombre.Location = new Point(180, 3);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(171, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BackColor = Color.White;
            textBoxApellido.BorderStyle = BorderStyle.FixedSingle;
            textBoxApellido.Dock = DockStyle.Fill;
            textBoxApellido.Font = new Font("Segoe UI", 10F);
            textBoxApellido.Location = new Point(357, 3);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(173, 23);
            textBoxApellido.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = false;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(75, 85, 99);
            label2.Location = new Point(3, 41);
            label2.Name = "label2";
            label2.Size = new Size(171, 40);
            label2.TabIndex = 3;
            label2.Text = "Correo";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = false;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(75, 85, 99);
            label3.Location = new Point(3, 81);
            label3.Name = "label3";
            label3.Size = new Size(171, 40);
            label3.TabIndex = 6;
            label3.Text = "Telefono y Dirección";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.BackColor = Color.White;
            textBoxTelefono.BorderStyle = BorderStyle.FixedSingle;
            textBoxTelefono.Dock = DockStyle.Fill;
            textBoxTelefono.Font = new Font("Segoe UI", 10F);
            textBoxTelefono.Location = new Point(180, 84);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(171, 23);
            textBoxTelefono.TabIndex = 7;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BackColor = Color.White;
            textBoxDireccion.BorderStyle = BorderStyle.FixedSingle;
            textBoxDireccion.Dock = DockStyle.Fill;
            textBoxDireccion.Font = new Font("Segoe UI", 10F);
            textBoxDireccion.Location = new Point(357, 84);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(173, 23);
            textBoxDireccion.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = false;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(75, 85, 99);
            label4.Location = new Point(3, 121);
            label4.Name = "label4";
            label4.Size = new Size(171, 40);
            label4.TabIndex = 11;
            label4.Text = "Documento";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelAcciones
            // 
            flowLayoutPanelAcciones.Controls.Add(button2);
            flowLayoutPanelAcciones.Controls.Add(button1);
            flowLayoutPanelAcciones.Dock = DockStyle.Fill;
            flowLayoutPanelAcciones.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelAcciones.Location = new Point(184, 200);
            flowLayoutPanelAcciones.Name = "flowLayoutPanelAcciones";
            flowLayoutPanelAcciones.Padding = new Padding(0, 8, 0, 0);
            flowLayoutPanelAcciones.Size = new Size(341, 48);
            flowLayoutPanelAcciones.TabIndex = 16;
            flowLayoutPanelAcciones.WrapContents = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(245, 158, 11);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 119, 6);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(188, 11);
            button1.Margin = new Padding(8, 0, 0, 0);
            button1.Name = "button1";
            button1.Size = new Size(150, 42);
            button1.TabIndex = 12;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(229, 231, 235);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.FromArgb(17, 24, 39);
            button2.Location = new Point(30, 11);
            button2.Margin = new Padding(8, 0, 0, 0);
            button2.Name = "button2";
            button2.Size = new Size(150, 42);
            button2.TabIndex = 13;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBoxCorreo
            // 
            tableLayoutPanel2.SetColumnSpan(textBoxCorreo, 2);
            textBoxCorreo.BackColor = Color.White;
            textBoxCorreo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCorreo.Dock = DockStyle.Fill;
            textBoxCorreo.Font = new Font("Segoe UI", 10F);
            textBoxCorreo.Location = new Point(180, 44);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(350, 23);
            textBoxCorreo.TabIndex = 14;
            // 
            // textBoxDocumento
            // 
            tableLayoutPanel2.SetColumnSpan(textBoxDocumento, 2);
            textBoxDocumento.BackColor = Color.White;
            textBoxDocumento.BorderStyle = BorderStyle.FixedSingle;
            textBoxDocumento.Dock = DockStyle.Fill;
            textBoxDocumento.Font = new Font("Segoe UI", 10F);
            textBoxDocumento.Location = new Point(180, 124);
            textBoxDocumento.Name = "textBoxDocumento";
            textBoxDocumento.Size = new Size(350, 23);
            textBoxDocumento.TabIndex = 15;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(243, 244, 246);
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 95);
            dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 58, 95);
            dgvClientes.ColumnHeadersHeight = 36;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.DefaultCellStyle.BackColor = Color.White;
            dgvClientes.DefaultCellStyle.ForeColor = Color.FromArgb(17, 24, 39);
            dgvClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 93, 122);
            dgvClientes.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.FromArgb(229, 231, 235);
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colNombre, colCorreo, colTelefono, colDireccion, colDocumento, colAcciones });
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.Location = new Point(3, 3);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(539, 342);
            dgvClientes.TabIndex = 1;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colCorreo
            // 
            colCorreo.HeaderText = "Correo";
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            // 
            // colDireccion
            // 
            colDireccion.HeaderText = "Dirección";
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // colDocumento
            // 
            colDocumento.HeaderText = "documento";
            colDocumento.Name = "colDocumento";
            colDocumento.ReadOnly = true;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Activo";
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            // 
            // ClienteControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(tableLayoutPanel1);
            Name = "ClienteControl";
            Size = new Size(545, 581);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private Label label2;
        private Label label3;
        private TextBox textBoxTelefono;
        private TextBox textBoxDireccion;
        private Label label4;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanelAcciones;
        private TextBox textBoxCorreo;
        private TextBox textBoxDocumento;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colDocumento;
        private DataGridViewTextBoxColumn colAcciones;
    }
}
