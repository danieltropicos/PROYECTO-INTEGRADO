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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
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
            dataGridView1 = new DataGridView();
            colX1 = new DataGridViewTextBoxColumn();
            colY1 = new DataGridViewTextBoxColumn();
            colZ1 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();
            colX2 = new DataGridViewTextBoxColumn();
            colY2 = new DataGridViewTextBoxColumn();
            colZ2 = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.BackColor = Color.FromArgb(243, 244, 246);
            tableLayoutPanel1.Size = new Size(1069, 591);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(430, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(636, 585);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel2.Controls.Add(groupBox4, 0, 3);
            tableLayoutPanel2.BackColor = Color.FromArgb(243, 244, 246);
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
            tableLayoutPanel2.SetColumnSpan(groupBox1, 2);
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(30, 58, 95);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 124);
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
            tableLayoutPanel3.Size = new Size(409, 102);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = false;
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.FromArgb(75, 85, 99);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 33);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.BackColor = Color.White;
            comboBoxClientes.Dock = DockStyle.Fill;
            comboBoxClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClientes.FlatStyle = FlatStyle.Standard;
            comboBoxClientes.Font = new Font("Segoe UI", 10F);
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(166, 3);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(240, 23);
            comboBoxClientes.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(166, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 23);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = false;
            label3.Dock = DockStyle.Fill;
            label3.ForeColor = Color.FromArgb(75, 85, 99);
            label3.Location = new Point(3, 66);
            label3.Name = "label3";
            label3.Size = new Size(157, 36);
            label3.TabIndex = 4;
            label3.Text = "Valor m³";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = false;
            label2.Dock = DockStyle.Fill;
            label2.ForeColor = Color.FromArgb(75, 85, 99);
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(157, 33);
            label2.TabIndex = 6;
            label2.Text = "Material";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxMateriales
            // 
            comboBoxMateriales.BackColor = Color.White;
            comboBoxMateriales.Dock = DockStyle.Fill;
            comboBoxMateriales.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMateriales.FlatStyle = FlatStyle.Standard;
            comboBoxMateriales.Font = new Font("Segoe UI", 10F);
            comboBoxMateriales.FormattingEnabled = true;
            comboBoxMateriales.Location = new Point(166, 36);
            comboBoxMateriales.Name = "comboBoxMateriales";
            comboBoxMateriales.Size = new Size(240, 23);
            comboBoxMateriales.TabIndex = 7;
            // 
            // groupBox2
            // 
            tableLayoutPanel2.SetColumnSpan(groupBox2, 2);
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(30, 58, 95);
            groupBox2.Location = new Point(3, 133);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(415, 130);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Terreno Original";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(243, 244, 246);
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 95);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 58, 95);
            dataGridView1.ColumnHeadersHeight = 36;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 93, 122);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(229, 231, 235);
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colX1, colY1, colZ1 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(409, 108);
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
            // groupBox3
            // 
            tableLayoutPanel2.SetColumnSpan(groupBox3, 2);
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(30, 58, 95);
            groupBox3.Location = new Point(3, 269);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(415, 130);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Terreno Final";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(243, 244, 246);
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 95);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 58, 95);
            dataGridView2.ColumnHeadersHeight = 36;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.DefaultCellStyle.BackColor = Color.White;
            dataGridView2.DefaultCellStyle.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 93, 122);
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.FromArgb(229, 231, 235);
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colX2, colY2, colZ2 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 19);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(409, 108);
            dataGridView2.TabIndex = 0;
            // 
            // colX2
            // 
            colX2.HeaderText = "X";
            colX2.Name = "colX2";
            // 
            // colY2
            // 
            colY2.HeaderText = "Y";
            colY2.Name = "colY2";
            // 
            // colZ2
            // 
            colZ2.HeaderText = "Z";
            colZ2.Name = "colZ2";
            // 
            // groupBox4
            // 
            tableLayoutPanel2.SetColumnSpan(groupBox4, 2);
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(tableLayoutPanel4);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox4.ForeColor = Color.FromArgb(30, 58, 95);
            groupBox4.Location = new Point(3, 405);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(415, 177);
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
            tableLayoutPanel4.Size = new Size(409, 155);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(75, 85, 99);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
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
            label6.Location = new Point(3, 55);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 2;
            label6.Text = "Total:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(30, 58, 95);
            label7.Location = new Point(207, 55);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 3;
            label7.Text = "$0";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            tableLayoutPanel4.SetColumnSpan(button1, 2);
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(245, 158, 11);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 119, 6);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 113);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private ComboBox comboBoxClientes;
        private Label label3;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colX1;
        private DataGridViewTextBoxColumn colY1;
        private DataGridViewTextBoxColumn colZ1;
        private GroupBox groupBox3;
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
