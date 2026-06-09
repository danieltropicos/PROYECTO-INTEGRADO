namespace Proyecto_Integrador.Vistas.Cotizaciones
{
    partial class CotizacionControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelGrafica = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            comboBoxClientes = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBoxMateriales = new ComboBox();
            groupBox2 = new GroupBox();
            tableLayoutTerreno = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            colX1 = new DataGridViewTextBoxColumn();
            colY1 = new DataGridViewTextBoxColumn();
            colZ1 = new DataGridViewTextBoxColumn();
            flowEntradaOriginal = new FlowLayoutPanel();
            lblOrigX = new Label();
            txtOrigX = new TextBox();
            lblOrigY = new Label();
            txtOrigY = new TextBox();
            lblOrigZ = new Label();
            txtOrigZ = new TextBox();
            btnCargarCoordenadas = new Button();
            btnAgregarOriginal = new Button();
            btnQuitarOriginal = new Button();
            groupBox4 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            btnGuardarCotizacion = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutTerreno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowEntradaOriginal.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(243, 244, 246);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(panelGrafica, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1222, 788);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelGrafica
            // 
            panelGrafica.BackColor = Color.White;
            panelGrafica.Dock = DockStyle.Fill;
            panelGrafica.Location = new Point(491, 4);
            panelGrafica.Margin = new Padding(3, 4, 3, 4);
            panelGrafica.Name = "panelGrafica";
            panelGrafica.Padding = new Padding(11, 13, 11, 13);
            panelGrafica.Size = new Size(728, 780);
            panelGrafica.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(243, 244, 246);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox4, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 211F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Size = new Size(482, 780);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            tableLayoutPanel2.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(30, 58, 95);
            groupBox1.Location = new Point(3, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(476, 203);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Generales";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(comboBoxClientes, 1, 0);
            tableLayoutPanel3.Controls.Add(textBox1, 1, 2);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(comboBoxMateriales, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 24);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(5, 3, 5, 5);
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel3.Size = new Size(470, 175);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.FromArgb(75, 85, 99);
            label1.Location = new Point(8, 3);
            label1.Name = "label1";
            label1.Size = new Size(120, 53);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.BackColor = Color.White;
            comboBoxClientes.Dock = DockStyle.Fill;
            comboBoxClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClientes.Font = new Font("Segoe UI", 10F);
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(134, 7);
            comboBoxClientes.Margin = new Padding(3, 4, 3, 4);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(328, 31);
            comboBoxClientes.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(134, 113);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 30);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.ForeColor = Color.FromArgb(75, 85, 99);
            label3.Location = new Point(8, 109);
            label3.Name = "label3";
            label3.Size = new Size(120, 61);
            label3.TabIndex = 4;
            label3.Text = "Valor m³";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.ForeColor = Color.FromArgb(75, 85, 99);
            label2.Location = new Point(8, 56);
            label2.Name = "label2";
            label2.Size = new Size(120, 53);
            label2.TabIndex = 6;
            label2.Text = "Material";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxMateriales
            // 
            comboBoxMateriales.BackColor = Color.White;
            comboBoxMateriales.Dock = DockStyle.Fill;
            comboBoxMateriales.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMateriales.Font = new Font("Segoe UI", 10F);
            comboBoxMateriales.FormattingEnabled = true;
            comboBoxMateriales.Location = new Point(134, 60);
            comboBoxMateriales.Margin = new Padding(3, 4, 3, 4);
            comboBoxMateriales.Name = "comboBoxMateriales";
            comboBoxMateriales.Size = new Size(328, 31);
            comboBoxMateriales.TabIndex = 7;
            comboBoxMateriales.SelectedIndexChanged += comboBoxMateriales_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            tableLayoutPanel2.SetColumnSpan(groupBox2, 2);
            groupBox2.Controls.Add(tableLayoutTerreno);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(30, 58, 95);
            groupBox2.Location = new Point(3, 215);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(476, 333);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Coordenadas del Terreno";
            // 
            // tableLayoutTerreno
            // 
            tableLayoutTerreno.ColumnCount = 1;
            tableLayoutTerreno.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutTerreno.Controls.Add(dataGridView1, 0, 0);
            tableLayoutTerreno.Controls.Add(flowEntradaOriginal, 0, 1);
            tableLayoutTerreno.Dock = DockStyle.Fill;
            tableLayoutTerreno.Location = new Point(3, 24);
            tableLayoutTerreno.Margin = new Padding(3, 4, 3, 4);
            tableLayoutTerreno.Name = "tableLayoutTerreno";
            tableLayoutTerreno.RowCount = 2;
            tableLayoutTerreno.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutTerreno.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutTerreno.Size = new Size(470, 305);
            tableLayoutTerreno.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 244, 246);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 36;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colX1, colY1, colZ1 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 93, 122);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(229, 231, 235);
            dataGridView1.Location = new Point(3, 4);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(464, 238);
            dataGridView1.TabIndex = 0;
            // 
            // colX1
            // 
            colX1.HeaderText = "X";
            colX1.MinimumWidth = 6;
            colX1.Name = "colX1";
            colX1.ReadOnly = true;
            // 
            // colY1
            // 
            colY1.HeaderText = "Y";
            colY1.MinimumWidth = 6;
            colY1.Name = "colY1";
            colY1.ReadOnly = true;
            // 
            // colZ1
            // 
            colZ1.HeaderText = "Z";
            colZ1.MinimumWidth = 6;
            colZ1.Name = "colZ1";
            colZ1.ReadOnly = true;
            // 
            // flowEntradaOriginal
            // 
            flowEntradaOriginal.Controls.Add(lblOrigX);
            flowEntradaOriginal.Controls.Add(txtOrigX);
            flowEntradaOriginal.Controls.Add(lblOrigY);
            flowEntradaOriginal.Controls.Add(txtOrigY);
            flowEntradaOriginal.Controls.Add(lblOrigZ);
            flowEntradaOriginal.Controls.Add(txtOrigZ);
            flowEntradaOriginal.Controls.Add(btnCargarCoordenadas);
            flowEntradaOriginal.Controls.Add(btnAgregarOriginal);
            flowEntradaOriginal.Controls.Add(btnQuitarOriginal);
            flowEntradaOriginal.Dock = DockStyle.Fill;
            flowEntradaOriginal.Location = new Point(3, 250);
            flowEntradaOriginal.Margin = new Padding(3, 4, 3, 4);
            flowEntradaOriginal.Name = "flowEntradaOriginal";
            flowEntradaOriginal.Padding = new Padding(0, 5, 0, 0);
            flowEntradaOriginal.Size = new Size(464, 51);
            flowEntradaOriginal.TabIndex = 1;
            // 
            // lblOrigX
            // 
            lblOrigX.AutoSize = true;
            lblOrigX.Font = new Font("Segoe UI", 9F);
            lblOrigX.ForeColor = Color.FromArgb(75, 85, 99);
            lblOrigX.Location = new Point(0, 13);
            lblOrigX.Margin = new Padding(0, 8, 5, 0);
            lblOrigX.Name = "lblOrigX";
            lblOrigX.Size = new Size(18, 20);
            lblOrigX.TabIndex = 0;
            lblOrigX.Text = "X";
            // 
            // txtOrigX
            // 
            txtOrigX.BorderStyle = BorderStyle.FixedSingle;
            txtOrigX.Font = new Font("Segoe UI", 9F);
            txtOrigX.Location = new Point(23, 9);
            txtOrigX.Margin = new Padding(0, 4, 9, 0);
            txtOrigX.Name = "txtOrigX";
            txtOrigX.Size = new Size(66, 27);
            txtOrigX.TabIndex = 1;
            // 
            // lblOrigY
            // 
            lblOrigY.AutoSize = true;
            lblOrigY.Font = new Font("Segoe UI", 9F);
            lblOrigY.ForeColor = Color.FromArgb(75, 85, 99);
            lblOrigY.Location = new Point(98, 13);
            lblOrigY.Margin = new Padding(0, 8, 5, 0);
            lblOrigY.Name = "lblOrigY";
            lblOrigY.Size = new Size(17, 20);
            lblOrigY.TabIndex = 2;
            lblOrigY.Text = "Y";
            // 
            // txtOrigY
            // 
            txtOrigY.BorderStyle = BorderStyle.FixedSingle;
            txtOrigY.Font = new Font("Segoe UI", 9F);
            txtOrigY.Location = new Point(120, 9);
            txtOrigY.Margin = new Padding(0, 4, 9, 0);
            txtOrigY.Name = "txtOrigY";
            txtOrigY.Size = new Size(66, 27);
            txtOrigY.TabIndex = 3;
            // 
            // lblOrigZ
            // 
            lblOrigZ.AutoSize = true;
            lblOrigZ.Font = new Font("Segoe UI", 9F);
            lblOrigZ.ForeColor = Color.FromArgb(75, 85, 99);
            lblOrigZ.Location = new Point(195, 13);
            lblOrigZ.Margin = new Padding(0, 8, 5, 0);
            lblOrigZ.Name = "lblOrigZ";
            lblOrigZ.Size = new Size(18, 20);
            lblOrigZ.TabIndex = 4;
            lblOrigZ.Text = "Z";
            // 
            // txtOrigZ
            // 
            txtOrigZ.BorderStyle = BorderStyle.FixedSingle;
            txtOrigZ.Font = new Font("Segoe UI", 9F);
            txtOrigZ.Location = new Point(218, 9);
            txtOrigZ.Margin = new Padding(0, 4, 9, 0);
            txtOrigZ.Name = "txtOrigZ";
            txtOrigZ.Size = new Size(66, 27);
            txtOrigZ.TabIndex = 5;
            // 
            // btnCargarCoordenadas
            // 
            btnCargarCoordenadas.BackColor = Color.FromArgb(59, 93, 122);
            btnCargarCoordenadas.FlatAppearance.BorderSize = 0;
            btnCargarCoordenadas.FlatStyle = FlatStyle.Flat;
            btnCargarCoordenadas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCargarCoordenadas.ForeColor = Color.White;
            btnCargarCoordenadas.Location = new Point(293, 8);
            btnCargarCoordenadas.Margin = new Padding(0, 3, 7, 0);
            btnCargarCoordenadas.Name = "btnCargarCoordenadas";
            btnCargarCoordenadas.Size = new Size(110, 35);
            btnCargarCoordenadas.TabIndex = 6;
            btnCargarCoordenadas.Text = "Cargar JSON";
            btnCargarCoordenadas.UseVisualStyleBackColor = false;
            btnCargarCoordenadas.Click += btnCargarCoordenadas_Click;
            // 
            // btnAgregarOriginal
            // 
            btnAgregarOriginal.BackColor = Color.FromArgb(245, 158, 11);
            btnAgregarOriginal.FlatAppearance.BorderSize = 0;
            btnAgregarOriginal.FlatStyle = FlatStyle.Flat;
            btnAgregarOriginal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarOriginal.ForeColor = Color.White;
            btnAgregarOriginal.Location = new Point(0, 46);
            btnAgregarOriginal.Margin = new Padding(0, 3, 7, 0);
            btnAgregarOriginal.Name = "btnAgregarOriginal";
            btnAgregarOriginal.Size = new Size(103, 35);
            btnAgregarOriginal.TabIndex = 7;
            btnAgregarOriginal.Text = "Agregar";
            btnAgregarOriginal.UseVisualStyleBackColor = false;
            btnAgregarOriginal.Click += btnAgregarOriginal_Click;
            // 
            // btnQuitarOriginal
            // 
            btnQuitarOriginal.BackColor = Color.FromArgb(229, 231, 235);
            btnQuitarOriginal.FlatAppearance.BorderSize = 0;
            btnQuitarOriginal.FlatStyle = FlatStyle.Flat;
            btnQuitarOriginal.Font = new Font("Segoe UI", 9F);
            btnQuitarOriginal.ForeColor = Color.FromArgb(17, 24, 39);
            btnQuitarOriginal.Location = new Point(110, 46);
            btnQuitarOriginal.Margin = new Padding(0, 3, 0, 0);
            btnQuitarOriginal.Name = "btnQuitarOriginal";
            btnQuitarOriginal.Size = new Size(80, 35);
            btnQuitarOriginal.TabIndex = 8;
            btnQuitarOriginal.Text = "Quitar";
            btnQuitarOriginal.UseVisualStyleBackColor = false;
            btnQuitarOriginal.Click += btnQuitarOriginal_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            tableLayoutPanel2.SetColumnSpan(groupBox4, 2);
            groupBox4.Controls.Add(tableLayoutPanel4);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox4.ForeColor = Color.FromArgb(30, 58, 95);
            groupBox4.Location = new Point(3, 556);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(476, 220);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Resultado";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label11, 1, 3);
            tableLayoutPanel4.Controls.Add(label10, 0, 3);
            tableLayoutPanel4.Controls.Add(label9, 1, 2);
            tableLayoutPanel4.Controls.Add(label8, 0, 2);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(label5, 1, 0);
            tableLayoutPanel4.Controls.Add(label6, 0, 1);
            tableLayoutPanel4.Controls.Add(label7, 1, 1);
            tableLayoutPanel4.Controls.Add(button1, 0, 4);
            tableLayoutPanel4.Controls.Add(btnGuardarCotizacion, 0, 5);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 24);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel4.Size = new Size(470, 192);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(30, 58, 95);
            label11.Location = new Point(238, 54);
            label11.Name = "label11";
            label11.Size = new Size(27, 18);
            label11.TabIndex = 9;
            label11.Text = "$0";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(75, 85, 99);
            label10.Location = new Point(3, 54);
            label10.Name = "label10";
            label10.Size = new Size(208, 18);
            label10.TabIndex = 8;
            label10.Text = "Total A Pagar (IVA Incluido):";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(30, 58, 95);
            label9.Location = new Point(238, 36);
            label9.Name = "label9";
            label9.Size = new Size(27, 18);
            label9.TabIndex = 7;
            label9.Text = "$0";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(75, 85, 99);
            label8.Location = new Point(3, 36);
            label8.Name = "label8";
            label8.Size = new Size(38, 18);
            label8.TabIndex = 6;
            label8.Text = "IVA:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(75, 85, 99);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 0;
            label4.Text = "Volumen";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(30, 58, 95);
            label5.Location = new Point(238, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 18);
            label5.TabIndex = 1;
            label5.Text = "0 m³";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(75, 85, 99);
            label6.Location = new Point(3, 18);
            label6.Name = "label6";
            label6.Size = new Size(48, 18);
            label6.TabIndex = 2;
            label6.Text = "Total:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(30, 58, 95);
            label7.Location = new Point(238, 18);
            label7.Name = "label7";
            label7.Size = new Size(27, 18);
            label7.TabIndex = 3;
            label7.Text = "$0";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(245, 158, 11);
            tableLayoutPanel4.SetColumnSpan(button1, 2);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 119, 6);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 85);
            button1.Margin = new Padding(3, 13, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(464, 43);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnGuardarCotizacion
            // 
            btnGuardarCotizacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardarCotizacion.BackColor = Color.FromArgb(30, 58, 95);
            tableLayoutPanel4.SetColumnSpan(btnGuardarCotizacion, 2);
            btnGuardarCotizacion.Cursor = Cursors.Hand;
            btnGuardarCotizacion.FlatAppearance.BorderSize = 0;
            btnGuardarCotizacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 93, 122);
            btnGuardarCotizacion.FlatStyle = FlatStyle.Flat;
            btnGuardarCotizacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarCotizacion.ForeColor = Color.White;
            btnGuardarCotizacion.Location = new Point(3, 145);
            btnGuardarCotizacion.Margin = new Padding(3, 13, 3, 4);
            btnGuardarCotizacion.Name = "btnGuardarCotizacion";
            btnGuardarCotizacion.Size = new Size(464, 43);
            btnGuardarCotizacion.TabIndex = 5;
            btnGuardarCotizacion.Text = "Guardar Cotización";
            btnGuardarCotizacion.UseVisualStyleBackColor = false;
            btnGuardarCotizacion.Click += btnGuardarCotizacion_Click;
            // 
            // CotizacionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CotizacionControl";
            Size = new Size(1222, 788);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutTerreno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowEntradaOriginal.ResumeLayout(false);
            flowEntradaOriginal.PerformLayout();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelGrafica;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private ComboBox comboBoxClientes;
        private Label label3;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutTerreno;
        private FlowLayoutPanel flowEntradaOriginal;
        private Label lblOrigX;
        private TextBox txtOrigX;
        private Label lblOrigY;
        private TextBox txtOrigY;
        private Label lblOrigZ;
        private TextBox txtOrigZ;
        private Button btnCargarCoordenadas;
        private Button btnAgregarOriginal;
        private Button btnQuitarOriginal;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colX1;
        private DataGridViewTextBoxColumn colY1;
        private DataGridViewTextBoxColumn colZ1;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label2;
        private ComboBox comboBoxMateriales;
        private Label label9;
        private Label label8;
        private Button btnGuardarCotizacion;
        private Label label11;
        private Label label10;
    }
}
