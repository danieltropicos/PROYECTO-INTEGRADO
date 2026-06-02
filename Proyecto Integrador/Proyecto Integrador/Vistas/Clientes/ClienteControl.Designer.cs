namespace Proyecto_Integrador.Vistas.Clientes
{
    partial class ClienteControl
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
            btnNuevoCliente = new Button();
            dgvClientes = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colDocumento = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colIconoEditar = new DataGridViewImageColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutToolbar.SuspendLayout();
            tableLayoutBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            //
            // tableLayoutPanel1
            //
            tableLayoutPanel1.BackColor = Color.FromArgb(243, 244, 246);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutToolbar, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvClientes, 0, 1);
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
            tableLayoutToolbar.Controls.Add(btnNuevoCliente, 2, 0);
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
            tableLayoutBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tableLayoutBuscar.Controls.Add(lblBuscar, 0, 0);
            tableLayoutBuscar.Controls.Add(txtBuscar, 1, 0);
            tableLayoutBuscar.Dock = DockStyle.Fill;
            tableLayoutBuscar.Location = new Point(3, 0);
            tableLayoutBuscar.Margin = new Padding(3, 0, 3, 0);
            tableLayoutBuscar.Name = "tableLayoutBuscar";
            tableLayoutBuscar.RowCount = 1;
            tableLayoutBuscar.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutBuscar.Size = new Size(389, 58);
            tableLayoutBuscar.TabIndex = 0;
            //
            // lblBuscar
            //
            lblBuscar.Font = new Font("Segoe UI", 10F);
            lblBuscar.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscar.Location = new Point(3, 8);
            lblBuscar.Margin = new Padding(3, 8, 6, 8);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(116, 25);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar clientes:";
            lblBuscar.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtBuscar
            //
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Dock = DockStyle.Fill;
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.Location = new Point(128, 8);
            txtBuscar.Margin = new Padding(3, 8, 3, 8);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Nombre o documento...";
            txtBuscar.Size = new Size(258, 25);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            //
            // btnNuevoCliente
            //
            btnNuevoCliente.BackColor = Color.FromArgb(245, 158, 11);
            btnNuevoCliente.Cursor = Cursors.Hand;
            btnNuevoCliente.Dock = DockStyle.Fill;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 119, 6);
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevoCliente.ForeColor = Color.White;
            btnNuevoCliente.Location = new Point(357, 8);
            btnNuevoCliente.Margin = new Padding(3, 8, 3, 8);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(179, 42);
            btnNuevoCliente.TabIndex = 2;
            btnNuevoCliente.Text = "+ Nuevo cliente";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            //
            // dgvClientes
            //
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 244, 246);
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeight = 36;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colCorreo, colTelefono, colDireccion, colDocumento, colIconoEditar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 93, 122);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.Margin = new Padding(10, 0, 12, 10);
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.FromArgb(229, 231, 235);
            dgvClientes.Location = new Point(3, 67);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(539, 511);
            dgvClientes.TabIndex = 1;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellMouseMove += dgvClientes_CellMouseMove;
            //
            // colId
            //
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
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
            colDocumento.HeaderText = "Documento";
            colDocumento.Name = "colDocumento";
            colDocumento.ReadOnly = true;
            //
            // colIconoEditar
            // 
            colIconoEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colIconoEditar.HeaderText = "Acciones";
            colIconoEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colIconoEditar.MinimumWidth = 50;
            colIconoEditar.Name = "colIconoEditar";
            colIconoEditar.Width = 50;
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
            tableLayoutToolbar.ResumeLayout(false);
            tableLayoutBuscar.ResumeLayout(false);
            tableLayoutBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutToolbar;
        private TableLayoutPanel tableLayoutBuscar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnNuevoCliente;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colDocumento;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewImageColumn colIconoEditar;
    }
}
