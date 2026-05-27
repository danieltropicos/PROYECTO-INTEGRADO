namespace Proyecto_Integrador.Vistas.Cotizaciones
{
    partial class ListaCotizacionControl
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
            btnCrearCotizacion = new Button();
            dgvCotizaciones = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colMaterial = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colAccion = new DataGridViewButtonColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutToolbar.SuspendLayout();
            tableLayoutBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCotizaciones).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(243, 244, 246);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutToolbar, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvCotizaciones, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(900, 580);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutToolbar
            // 
            tableLayoutToolbar.BackColor = Color.FromArgb(243, 244, 246);
            tableLayoutToolbar.ColumnCount = 3;
            tableLayoutToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 420F));
            tableLayoutToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutToolbar.Controls.Add(tableLayoutBuscar, 0, 0);
            tableLayoutToolbar.Controls.Add(btnCrearCotizacion, 2, 0);
            tableLayoutToolbar.Dock = DockStyle.Fill;
            tableLayoutToolbar.Location = new Point(3, 3);
            tableLayoutToolbar.Name = "tableLayoutToolbar";
            tableLayoutToolbar.RowCount = 1;
            tableLayoutToolbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutToolbar.Size = new Size(894, 58);
            tableLayoutToolbar.TabIndex = 0;
            // 
            // tableLayoutBuscar
            // 
            tableLayoutBuscar.ColumnCount = 2;
            tableLayoutBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tableLayoutBuscar.Controls.Add(lblBuscar, 0, 0);
            tableLayoutBuscar.Controls.Add(txtBuscar, 1, 0);
            tableLayoutBuscar.Dock = DockStyle.Fill;
            tableLayoutBuscar.Location = new Point(3, 0);
            tableLayoutBuscar.Margin = new Padding(3, 0, 3, 0);
            tableLayoutBuscar.Name = "tableLayoutBuscar";
            tableLayoutBuscar.RowCount = 1;
            tableLayoutBuscar.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutBuscar.Size = new Size(414, 58);
            tableLayoutBuscar.TabIndex = 0;
            // 
            // lblBuscar
            // 
            lblBuscar.Font = new Font("Segoe UI", 10F);
            lblBuscar.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscar.Location = new Point(3, 8);
            lblBuscar.Margin = new Padding(3, 8, 6, 8);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(141, 25);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar cotización:";
            lblBuscar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Dock = DockStyle.Fill;
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.Location = new Point(153, 8);
            txtBuscar.Margin = new Padding(3, 8, 3, 8);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Cliente o material...";
            txtBuscar.Size = new Size(258, 25);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnCrearCotizacion
            // 
            btnCrearCotizacion.BackColor = Color.FromArgb(245, 158, 11);
            btnCrearCotizacion.Cursor = Cursors.Hand;
            btnCrearCotizacion.Dock = DockStyle.Fill;
            btnCrearCotizacion.FlatAppearance.BorderSize = 0;
            btnCrearCotizacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 119, 6);
            btnCrearCotizacion.FlatStyle = FlatStyle.Flat;
            btnCrearCotizacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCrearCotizacion.ForeColor = Color.White;
            btnCrearCotizacion.Location = new Point(697, 8);
            btnCrearCotizacion.Margin = new Padding(3, 8, 3, 8);
            btnCrearCotizacion.Name = "btnCrearCotizacion";
            btnCrearCotizacion.Size = new Size(194, 42);
            btnCrearCotizacion.TabIndex = 2;
            btnCrearCotizacion.Text = "+ Nueva cotización";
            btnCrearCotizacion.UseVisualStyleBackColor = false;
            btnCrearCotizacion.Click += btnCrearCotizacion_Click;
            // 
            // dgvCotizaciones
            // 
            dgvCotizaciones.AllowUserToAddRows = false;
            dgvCotizaciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 244, 246);
            dgvCotizaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCotizaciones.BackgroundColor = Color.White;
            dgvCotizaciones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCotizaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCotizaciones.ColumnHeadersHeight = 36;
            dgvCotizaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCotizaciones.Columns.AddRange(new DataGridViewColumn[] { colId, colCliente, colMaterial, colVolumen, colTotal, colFecha, colEstado, colAccion });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 93, 122);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCotizaciones.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCotizaciones.Dock = DockStyle.Fill;
            dgvCotizaciones.EnableHeadersVisualStyles = false;
            dgvCotizaciones.GridColor = Color.FromArgb(229, 231, 235);
            dgvCotizaciones.Location = new Point(3, 67);
            dgvCotizaciones.MultiSelect = false;
            dgvCotizaciones.Name = "dgvCotizaciones";
            dgvCotizaciones.ReadOnly = true;
            dgvCotizaciones.RowHeadersVisible = false;
            dgvCotizaciones.Size = new Size(894, 510);
            dgvCotizaciones.TabIndex = 1;
            dgvCotizaciones.CellContentClick += dgvCotizaciones_CellContentClick;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            // 
            // colMaterial
            // 
            colMaterial.HeaderText = "Material";
            colMaterial.Name = "colMaterial";
            colMaterial.ReadOnly = true;
            // 
            // colVolumen
            // 
            colVolumen.HeaderText = "Volumen";
            colVolumen.Name = "colVolumen";
            colVolumen.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // colAccion
            // 
            colAccion.HeaderText = "Acción";
            colAccion.Name = "colAccion";
            colAccion.ReadOnly = true;
            colAccion.Text = "Generar Factura";
            colAccion.UseColumnTextForButtonValue = true;
            // 
            // ListaCotizacionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(tableLayoutPanel1);
            Name = "ListaCotizacionControl";
            Size = new Size(900, 580);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutToolbar.ResumeLayout(false);
            tableLayoutBuscar.ResumeLayout(false);
            tableLayoutBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCotizaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutToolbar;
        private TableLayoutPanel tableLayoutBuscar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnCrearCotizacion;
        private DataGridView dgvCotizaciones;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colMaterial;
        private DataGridViewTextBoxColumn colVolumen;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewButtonColumn colAccion;
    }
}
