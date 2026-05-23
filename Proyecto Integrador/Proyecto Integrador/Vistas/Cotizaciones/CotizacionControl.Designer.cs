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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            tableLayoutTerrenoOriginal = new TableLayoutPanel();
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
            btnAgregarOriginal = new Button();
            btnQuitarOriginal = new Button();
            groupBox3 = new GroupBox();
            tableLayoutTerrenoFinal = new TableLayoutPanel();
            dataGridView2 = new DataGridView();
            colX2 = new DataGridViewTextBoxColumn();
            colY2 = new DataGridViewTextBoxColumn();
            colZ2 = new DataGridViewTextBoxColumn();
            flowEntradaFinal = new FlowLayoutPanel();
            lblFinalX = new Label();
            txtFinalX = new TextBox();
            lblFinalY = new Label();
            txtFinalY = new TextBox();
            lblFinalZ = new Label();
            txtFinalZ = new TextBox();
            btnAgregarFinal = new Button();
            btnQuitarFinal = new Button();
            groupBox4 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutTerrenoOriginal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowEntradaOriginal.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutTerrenoFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            flowEntradaFinal.SuspendLayout();
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1069, 591);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelGrafica
            // 
            panelGrafica.BackColor = Color.White;
            panelGrafica.Dock = DockStyle.Fill;
            panelGrafica.Location = new Point(430, 3);
            panelGrafica.Name = "panelGrafica";
            panelGrafica.Padding = new Padding(10);
            panelGrafica.Size = new Size(636, 585);
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
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel2.Controls.Add(groupBox4, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 158F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Size = new Size(421, 585);
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
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 152);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Generales";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(comboBoxClientes, 1, 0);
            tableLayoutPanel3.Controls.Add(textBox1, 1, 2);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(comboBoxMateriales, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(4, 2, 4, 4);
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(409, 130);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.FromArgb(75, 85, 99);
            label1.Location = new Point(7, 2);
            label1.Name = "label1";
            label1.Size = new Size(104, 40);
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
            comboBoxClientes.Location = new Point(117, 5);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(285, 25);
            comboBoxClientes.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(117, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 25);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.ForeColor = Color.FromArgb(75, 85, 99);
            label3.Location = new Point(7, 82);
            label3.Name = "label3";
            label3.Size = new Size(104, 44);
            label3.TabIndex = 4;
            label3.Text = "Valor m³";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.ForeColor = Color.FromArgb(75, 85, 99);
            label2.Location = new Point(7, 42);
            label2.Name = "label2";
            label2.Size = new Size(104, 40);
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
            comboBoxMateriales.Location = new Point(117, 45);
            comboBoxMateriales.Name = "comboBoxMateriales";
            comboBoxMateriales.Size = new Size(285, 25);
            comboBoxMateriales.TabIndex = 7;
            comboBoxMateriales.SelectedIndexChanged += comboBoxMateriales_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            tableLayoutPanel2.SetColumnSpan(groupBox2, 2);
            groupBox2.Controls.Add(tableLayoutTerrenoOriginal);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(30, 58, 95);
            groupBox2.Location = new Point(3, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(415, 122);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Terreno Original";
            // 
            // tableLayoutTerrenoOriginal
            // 
            tableLayoutTerrenoOriginal.ColumnCount = 1;
            tableLayoutTerrenoOriginal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutTerrenoOriginal.Controls.Add(dataGridView1, 0, 0);
            tableLayoutTerrenoOriginal.Controls.Add(flowEntradaOriginal, 0, 1);
            tableLayoutTerrenoOriginal.Dock = DockStyle.Fill;
            tableLayoutTerrenoOriginal.Location = new Point(3, 19);
            tableLayoutTerrenoOriginal.Name = "tableLayoutTerrenoOriginal";
            tableLayoutTerrenoOriginal.RowCount = 2;
            tableLayoutTerrenoOriginal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutTerrenoOriginal.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutTerrenoOriginal.Size = new Size(409, 100);
            tableLayoutTerrenoOriginal.TabIndex = 0;
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
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(403, 50);
            dataGridView1.TabIndex = 0;
            // 
            // colX1
            // 
            colX1.HeaderText = "X";
            colX1.Name = "colX1";
            colX1.ReadOnly = true;
            // 
            // colY1
            // 
            colY1.HeaderText = "Y";
            colY1.Name = "colY1";
            colY1.ReadOnly = true;
            // 
            // colZ1
            // 
            colZ1.HeaderText = "Z";
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
            flowEntradaOriginal.Controls.Add(btnAgregarOriginal);
            flowEntradaOriginal.Controls.Add(btnQuitarOriginal);
            flowEntradaOriginal.Dock = DockStyle.Fill;
            flowEntradaOriginal.Location = new Point(3, 59);
            flowEntradaOriginal.Name = "flowEntradaOriginal";
            flowEntradaOriginal.Padding = new Padding(0, 4, 0, 0);
            flowEntradaOriginal.Size = new Size(403, 38);
            flowEntradaOriginal.TabIndex = 1;
            flowEntradaOriginal.WrapContents = false;
            // 
            // lblOrigX
            // 
            lblOrigX.AutoSize = true;
            lblOrigX.Font = new Font("Segoe UI", 9F);
            lblOrigX.ForeColor = Color.FromArgb(75, 85, 99);
            lblOrigX.Location = new Point(0, 10);
            lblOrigX.Margin = new Padding(0, 6, 4, 0);
            lblOrigX.Name = "lblOrigX";
            lblOrigX.Size = new Size(14, 15);
            lblOrigX.TabIndex = 0;
            lblOrigX.Text = "X";
            // 
            // txtOrigX
            // 
            txtOrigX.BorderStyle = BorderStyle.FixedSingle;
            txtOrigX.Font = new Font("Segoe UI", 9F);
            txtOrigX.Location = new Point(18, 7);
            txtOrigX.Margin = new Padding(0, 3, 8, 0);
            txtOrigX.Name = "txtOrigX";
            txtOrigX.Size = new Size(58, 23);
            txtOrigX.TabIndex = 1;
            // 
            // lblOrigY
            // 
            lblOrigY.AutoSize = true;
            lblOrigY.Font = new Font("Segoe UI", 9F);
            lblOrigY.ForeColor = Color.FromArgb(75, 85, 99);
            lblOrigY.Location = new Point(84, 10);
            lblOrigY.Margin = new Padding(0, 6, 4, 0);
            lblOrigY.Name = "lblOrigY";
            lblOrigY.Size = new Size(14, 15);
            lblOrigY.TabIndex = 2;
            lblOrigY.Text = "Y";
            // 
            // txtOrigY
            // 
            txtOrigY.BorderStyle = BorderStyle.FixedSingle;
            txtOrigY.Font = new Font("Segoe UI", 9F);
            txtOrigY.Location = new Point(102, 7);
            txtOrigY.Margin = new Padding(0, 3, 8, 0);
            txtOrigY.Name = "txtOrigY";
            txtOrigY.Size = new Size(58, 23);
            txtOrigY.TabIndex = 3;
            // 
            // lblOrigZ
            // 
            lblOrigZ.AutoSize = true;
            lblOrigZ.Font = new Font("Segoe UI", 9F);
            lblOrigZ.ForeColor = Color.FromArgb(75, 85, 99);
            lblOrigZ.Location = new Point(168, 10);
            lblOrigZ.Margin = new Padding(0, 6, 4, 0);
            lblOrigZ.Name = "lblOrigZ";
            lblOrigZ.Size = new Size(14, 15);
            lblOrigZ.TabIndex = 4;
            lblOrigZ.Text = "Z";
            // 
            // txtOrigZ
            // 
            txtOrigZ.BorderStyle = BorderStyle.FixedSingle;
            txtOrigZ.Font = new Font("Segoe UI", 9F);
            txtOrigZ.Location = new Point(186, 7);
            txtOrigZ.Margin = new Padding(0, 3, 8, 0);
            txtOrigZ.Name = "txtOrigZ";
            txtOrigZ.Size = new Size(58, 23);
            txtOrigZ.TabIndex = 5;
            // 
            // btnAgregarOriginal
            // 
            btnAgregarOriginal.BackColor = Color.FromArgb(245, 158, 11);
            btnAgregarOriginal.FlatAppearance.BorderSize = 0;
            btnAgregarOriginal.FlatStyle = FlatStyle.Flat;
            btnAgregarOriginal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarOriginal.ForeColor = Color.White;
            btnAgregarOriginal.Location = new Point(252, 6);
            btnAgregarOriginal.Margin = new Padding(0, 2, 6, 0);
            btnAgregarOriginal.Name = "btnAgregarOriginal";
            btnAgregarOriginal.Size = new Size(90, 26);
            btnAgregarOriginal.TabIndex = 6;
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
            btnQuitarOriginal.Location = new Point(348, 6);
            btnQuitarOriginal.Margin = new Padding(0, 2, 0, 0);
            btnQuitarOriginal.Name = "btnQuitarOriginal";
            btnQuitarOriginal.Size = new Size(70, 26);
            btnQuitarOriginal.TabIndex = 7;
            btnQuitarOriginal.Text = "Quitar";
            btnQuitarOriginal.UseVisualStyleBackColor = false;
            btnQuitarOriginal.Click += btnQuitarOriginal_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            tableLayoutPanel2.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(tableLayoutTerrenoFinal);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(30, 58, 95);
            groupBox3.Location = new Point(3, 289);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(415, 122);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Terreno Final";
            // 
            // tableLayoutTerrenoFinal
            // 
            tableLayoutTerrenoFinal.ColumnCount = 1;
            tableLayoutTerrenoFinal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutTerrenoFinal.Controls.Add(dataGridView2, 0, 0);
            tableLayoutTerrenoFinal.Controls.Add(flowEntradaFinal, 0, 1);
            tableLayoutTerrenoFinal.Dock = DockStyle.Fill;
            tableLayoutTerrenoFinal.Location = new Point(3, 19);
            tableLayoutTerrenoFinal.Name = "tableLayoutTerrenoFinal";
            tableLayoutTerrenoFinal.RowCount = 2;
            tableLayoutTerrenoFinal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutTerrenoFinal.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutTerrenoFinal.Size = new Size(409, 100);
            tableLayoutTerrenoFinal.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 244, 246);
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.ColumnHeadersHeight = 36;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colX2, colY2, colZ2 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(59, 93, 122);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.FromArgb(229, 231, 235);
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(403, 50);
            dataGridView2.TabIndex = 0;
            // 
            // colX2
            // 
            colX2.HeaderText = "X";
            colX2.Name = "colX2";
            colX2.ReadOnly = true;
            // 
            // colY2
            // 
            colY2.HeaderText = "Y";
            colY2.Name = "colY2";
            colY2.ReadOnly = true;
            // 
            // colZ2
            // 
            colZ2.HeaderText = "Z";
            colZ2.Name = "colZ2";
            colZ2.ReadOnly = true;
            // 
            // flowEntradaFinal
            // 
            flowEntradaFinal.Controls.Add(lblFinalX);
            flowEntradaFinal.Controls.Add(txtFinalX);
            flowEntradaFinal.Controls.Add(lblFinalY);
            flowEntradaFinal.Controls.Add(txtFinalY);
            flowEntradaFinal.Controls.Add(lblFinalZ);
            flowEntradaFinal.Controls.Add(txtFinalZ);
            flowEntradaFinal.Controls.Add(btnAgregarFinal);
            flowEntradaFinal.Controls.Add(btnQuitarFinal);
            flowEntradaFinal.Dock = DockStyle.Fill;
            flowEntradaFinal.Location = new Point(3, 59);
            flowEntradaFinal.Name = "flowEntradaFinal";
            flowEntradaFinal.Padding = new Padding(0, 4, 0, 0);
            flowEntradaFinal.Size = new Size(403, 38);
            flowEntradaFinal.TabIndex = 1;
            flowEntradaFinal.WrapContents = false;
            // 
            // lblFinalX
            // 
            lblFinalX.AutoSize = true;
            lblFinalX.Font = new Font("Segoe UI", 9F);
            lblFinalX.ForeColor = Color.FromArgb(75, 85, 99);
            lblFinalX.Location = new Point(0, 10);
            lblFinalX.Margin = new Padding(0, 6, 4, 0);
            lblFinalX.Name = "lblFinalX";
            lblFinalX.Size = new Size(14, 15);
            lblFinalX.TabIndex = 0;
            lblFinalX.Text = "X";
            // 
            // txtFinalX
            // 
            txtFinalX.BorderStyle = BorderStyle.FixedSingle;
            txtFinalX.Font = new Font("Segoe UI", 9F);
            txtFinalX.Location = new Point(18, 7);
            txtFinalX.Margin = new Padding(0, 3, 8, 0);
            txtFinalX.Name = "txtFinalX";
            txtFinalX.Size = new Size(58, 23);
            txtFinalX.TabIndex = 1;
            // 
            // lblFinalY
            // 
            lblFinalY.AutoSize = true;
            lblFinalY.Font = new Font("Segoe UI", 9F);
            lblFinalY.ForeColor = Color.FromArgb(75, 85, 99);
            lblFinalY.Location = new Point(84, 10);
            lblFinalY.Margin = new Padding(0, 6, 4, 0);
            lblFinalY.Name = "lblFinalY";
            lblFinalY.Size = new Size(14, 15);
            lblFinalY.TabIndex = 2;
            lblFinalY.Text = "Y";
            // 
            // txtFinalY
            // 
            txtFinalY.BorderStyle = BorderStyle.FixedSingle;
            txtFinalY.Font = new Font("Segoe UI", 9F);
            txtFinalY.Location = new Point(102, 7);
            txtFinalY.Margin = new Padding(0, 3, 8, 0);
            txtFinalY.Name = "txtFinalY";
            txtFinalY.Size = new Size(58, 23);
            txtFinalY.TabIndex = 3;
            // 
            // lblFinalZ
            // 
            lblFinalZ.AutoSize = true;
            lblFinalZ.Font = new Font("Segoe UI", 9F);
            lblFinalZ.ForeColor = Color.FromArgb(75, 85, 99);
            lblFinalZ.Location = new Point(168, 10);
            lblFinalZ.Margin = new Padding(0, 6, 4, 0);
            lblFinalZ.Name = "lblFinalZ";
            lblFinalZ.Size = new Size(14, 15);
            lblFinalZ.TabIndex = 4;
            lblFinalZ.Text = "Z";
            // 
            // txtFinalZ
            // 
            txtFinalZ.BorderStyle = BorderStyle.FixedSingle;
            txtFinalZ.Font = new Font("Segoe UI", 9F);
            txtFinalZ.Location = new Point(186, 7);
            txtFinalZ.Margin = new Padding(0, 3, 8, 0);
            txtFinalZ.Name = "txtFinalZ";
            txtFinalZ.Size = new Size(58, 23);
            txtFinalZ.TabIndex = 5;
            // 
            // btnAgregarFinal
            // 
            btnAgregarFinal.BackColor = Color.FromArgb(245, 158, 11);
            btnAgregarFinal.FlatAppearance.BorderSize = 0;
            btnAgregarFinal.FlatStyle = FlatStyle.Flat;
            btnAgregarFinal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarFinal.ForeColor = Color.White;
            btnAgregarFinal.Location = new Point(252, 6);
            btnAgregarFinal.Margin = new Padding(0, 2, 6, 0);
            btnAgregarFinal.Name = "btnAgregarFinal";
            btnAgregarFinal.Size = new Size(90, 26);
            btnAgregarFinal.TabIndex = 6;
            btnAgregarFinal.Text = "Agregar";
            btnAgregarFinal.UseVisualStyleBackColor = false;
            btnAgregarFinal.Click += btnAgregarFinal_Click;
            // 
            // btnQuitarFinal
            // 
            btnQuitarFinal.BackColor = Color.FromArgb(229, 231, 235);
            btnQuitarFinal.FlatAppearance.BorderSize = 0;
            btnQuitarFinal.FlatStyle = FlatStyle.Flat;
            btnQuitarFinal.Font = new Font("Segoe UI", 9F);
            btnQuitarFinal.ForeColor = Color.FromArgb(17, 24, 39);
            btnQuitarFinal.Location = new Point(348, 6);
            btnQuitarFinal.Margin = new Padding(0, 2, 0, 0);
            btnQuitarFinal.Name = "btnQuitarFinal";
            btnQuitarFinal.Size = new Size(70, 26);
            btnQuitarFinal.TabIndex = 7;
            btnQuitarFinal.Text = "Quitar";
            btnQuitarFinal.UseVisualStyleBackColor = false;
            btnQuitarFinal.Click += btnQuitarFinal_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            tableLayoutPanel2.SetColumnSpan(groupBox4, 2);
            groupBox4.Controls.Add(tableLayoutPanel4);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox4.ForeColor = Color.FromArgb(30, 58, 95);
            groupBox4.Location = new Point(3, 417);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(415, 165);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Resultado";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(label5, 1, 0);
            tableLayoutPanel4.Controls.Add(label6, 0, 1);
            tableLayoutPanel4.Controls.Add(label7, 1, 1);
            tableLayoutPanel4.Controls.Add(button1, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel4.Size = new Size(409, 143);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(75, 85, 99);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 0;
            label4.Text = "Volumen";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(30, 58, 95);
            label5.Location = new Point(207, 0);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 1;
            label5.Text = "0 m³";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(75, 85, 99);
            label6.Location = new Point(3, 43);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 2;
            label6.Text = "Total:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(30, 58, 95);
            label7.Location = new Point(207, 43);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
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
            button1.Location = new Point(3, 96);
            button1.Margin = new Padding(3, 10, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(403, 42);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CotizacionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(tableLayoutPanel1);
            Name = "CotizacionControl";
            Size = new Size(1069, 591);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutTerrenoOriginal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowEntradaOriginal.ResumeLayout(false);
            flowEntradaOriginal.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutTerrenoFinal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            flowEntradaFinal.ResumeLayout(false);
            flowEntradaFinal.PerformLayout();
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
        private TableLayoutPanel tableLayoutTerrenoOriginal;
        private FlowLayoutPanel flowEntradaOriginal;
        private Label lblOrigX;
        private TextBox txtOrigX;
        private Label lblOrigY;
        private TextBox txtOrigY;
        private Label lblOrigZ;
        private TextBox txtOrigZ;
        private Button btnAgregarOriginal;
        private Button btnQuitarOriginal;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colX1;
        private DataGridViewTextBoxColumn colY1;
        private DataGridViewTextBoxColumn colZ1;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutTerrenoFinal;
        private FlowLayoutPanel flowEntradaFinal;
        private Label lblFinalX;
        private TextBox txtFinalX;
        private Label lblFinalY;
        private TextBox txtFinalY;
        private Label lblFinalZ;
        private TextBox txtFinalZ;
        private Button btnAgregarFinal;
        private Button btnQuitarFinal;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn colX2;
        private DataGridViewTextBoxColumn colY2;
        private DataGridViewTextBoxColumn colZ2;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label2;
        private ComboBox comboBoxMateriales;
    }
}
