namespace Proyecto_Integrador.Vistas.Cotizaciones
{
    partial class MaterialControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutToolbar = new TableLayoutPanel();
            tableLayoutBuscar = new TableLayoutPanel();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnNuevoMaterial = new Button();
            dgvMateriales = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutToolbar.SuspendLayout();
            tableLayoutBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMateriales).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(243, 244, 246);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutToolbar, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvMateriales, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(545, 581);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutToolbar
            // 
            tableLayoutToolbar.BackColor = Color.FromArgb(243, 244, 246);
            tableLayoutToolbar.ColumnCount = 3;
            tableLayoutToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 395F));
            tableLayoutToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 185F));
            tableLayoutToolbar.Controls.Add(tableLayoutBuscar, 0, 0);
            tableLayoutToolbar.Controls.Add(btnNuevoMaterial, 2, 0);
            tableLayoutToolbar.Dock = DockStyle.Fill;
            tableLayoutToolbar.Location = new Point(3, 3);
            tableLayoutToolbar.Name = "tableLayoutToolbar";
            tableLayoutToolbar.RowCount = 1;
            tableLayoutToolbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutToolbar.Size = new Size(539, 58);
            tableLayoutToolbar.TabIndex = 0;
            // 
            // tableLayoutBuscar
            // 
            tableLayoutBuscar.ColumnCount = 2;
            tableLayoutBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142F));
            tableLayoutBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243F));
            tableLayoutBuscar.Controls.Add(lblBuscar, 0, 0);
            tableLayoutBuscar.Controls.Add(txtBuscar, 1, 0);
            tableLayoutBuscar.Dock = DockStyle.Fill;
            tableLayoutBuscar.Location = new Point(3, 0);
            tableLayoutBuscar.Margin = new Padding(3, 0, 3, 0);
            tableLayoutBuscar.Name = "tableLayoutBuscar";
            tableLayoutBuscar.RowCount = 1;
            tableLayoutBuscar.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutBuscar.Size = new Size(389, 58);
            tableLayoutBuscar.TabIndex = 0;
            // 
            // lblBuscar
            // 
            lblBuscar.Dock = DockStyle.Top;
            lblBuscar.Font = new Font("Segoe UI", 10F);
            lblBuscar.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscar.Location = new Point(3, 8);
            lblBuscar.Margin = new Padding(3, 8, 6, 8);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(133, 23);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar materiales:";
            lblBuscar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Dock = DockStyle.Fill;
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.Location = new Point(145, 8);
            txtBuscar.Margin = new Padding(3, 8, 3, 8);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Nombre del material...";
            txtBuscar.Size = new Size(241, 25);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnNuevoMaterial
            // 
            btnNuevoMaterial.BackColor = Color.FromArgb(245, 158, 11);
            btnNuevoMaterial.Cursor = Cursors.Hand;
            btnNuevoMaterial.Dock = DockStyle.Fill;
            btnNuevoMaterial.FlatAppearance.BorderSize = 0;
            btnNuevoMaterial.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 119, 6);
            btnNuevoMaterial.FlatStyle = FlatStyle.Flat;
            btnNuevoMaterial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevoMaterial.ForeColor = Color.White;
            btnNuevoMaterial.Location = new Point(357, 8);
            btnNuevoMaterial.Margin = new Padding(3, 8, 3, 8);
            btnNuevoMaterial.Name = "btnNuevoMaterial";
            btnNuevoMaterial.Size = new Size(179, 42);
            btnNuevoMaterial.TabIndex = 1;
            btnNuevoMaterial.Text = "+ Nuevo material";
            btnNuevoMaterial.UseVisualStyleBackColor = false;
            btnNuevoMaterial.Click += btnNuevoMaterial_Click;
            // 
            // dgvMateriales
            // 
            dgvMateriales.AllowUserToAddRows = false;
            dgvMateriales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 244, 246);
            dgvMateriales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMateriales.BackgroundColor = Color.White;
            dgvMateriales.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMateriales.ColumnHeadersHeight = 36;
            dgvMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMateriales.Columns.AddRange(new DataGridViewColumn[] { colNombre, colValor });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 93, 122);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMateriales.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMateriales.Dock = DockStyle.Fill;
            dgvMateriales.EnableHeadersVisualStyles = false;
            dgvMateriales.GridColor = Color.FromArgb(229, 231, 235);
            dgvMateriales.Location = new Point(3, 67);
            dgvMateriales.MultiSelect = false;
            dgvMateriales.Name = "dgvMateriales";
            dgvMateriales.ReadOnly = true;
            dgvMateriales.RowHeadersVisible = false;
            dgvMateriales.Size = new Size(539, 511);
            dgvMateriales.TabIndex = 1;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colValor
            // 
            colValor.HeaderText = "Valor m³";
            colValor.Name = "colValor";
            colValor.ReadOnly = true;
            // 
            // MaterialControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(tableLayoutPanel1);
            Name = "MaterialControl";
            Size = new Size(545, 581);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutToolbar.ResumeLayout(false);
            tableLayoutBuscar.ResumeLayout(false);
            tableLayoutBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMateriales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutToolbar;
        private TableLayoutPanel tableLayoutBuscar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnNuevoMaterial;
        private DataGridView dgvMateriales;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colValor;
    }
}
