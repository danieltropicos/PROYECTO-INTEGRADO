namespace Proyecto_Integrador.Vistas.Usuarios
{
    partial class RegistrarUsuariosControl
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
            btnNuevoUsuario = new Button();
            dgvUsuarios = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colRol = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colIconoEditar = new DataGridViewImageColumn();
            colIconoEstado = new DataGridViewImageColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutToolbar.SuspendLayout();
            tableLayoutBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            //
            // tableLayoutPanel1
            //
            tableLayoutPanel1.BackColor = Color.FromArgb(243, 244, 246);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutToolbar, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvUsuarios, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(594, 693);
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
            tableLayoutToolbar.Controls.Add(btnNuevoUsuario, 2, 0);
            tableLayoutToolbar.Dock = DockStyle.Fill;
            tableLayoutToolbar.Location = new Point(3, 3);
            tableLayoutToolbar.Name = "tableLayoutToolbar";
            tableLayoutToolbar.RowCount = 1;
            tableLayoutToolbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutToolbar.Size = new Size(588, 58);
            tableLayoutToolbar.TabIndex = 0;
            //
            // tableLayoutBuscar
            //
            tableLayoutBuscar.ColumnCount = 2;
            tableLayoutBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 264F));
            tableLayoutBuscar.Controls.Add(lblBuscar, 0, 0);
            tableLayoutBuscar.Controls.Add(txtBuscar, 1, 0);
            tableLayoutBuscar.Dock = DockStyle.Fill;
            tableLayoutBuscar.Location = new Point(3, 0);
            tableLayoutBuscar.Margin = new Padding(3, 0, 3, 0);
            tableLayoutBuscar.Name = "tableLayoutBuscar";
            tableLayoutBuscar.RowCount = 1;
            tableLayoutBuscar.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutBuscar.Size = new Size(389, 59);
            tableLayoutBuscar.TabIndex = 0;
            //
            // lblBuscar
            //
            lblBuscar.Font = new Font("Segoe UI", 10F);
            lblBuscar.ForeColor = Color.FromArgb(75, 85, 99);
            lblBuscar.Location = new Point(3, 8);
            lblBuscar.Margin = new Padding(3, 8, 6, 8);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(115, 33);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar usuarios:";
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
            txtBuscar.PlaceholderText = "Nombre o usuario...";
            txtBuscar.Size = new Size(258, 30);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            //
            // btnNuevoUsuario
            //
            btnNuevoUsuario.BackColor = Color.FromArgb(245, 158, 11);
            btnNuevoUsuario.Cursor = Cursors.Hand;
            btnNuevoUsuario.Dock = DockStyle.Fill;
            btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            btnNuevoUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 119, 6);
            btnNuevoUsuario.FlatStyle = FlatStyle.Flat;
            btnNuevoUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevoUsuario.ForeColor = Color.White;
            btnNuevoUsuario.Location = new Point(406, 8);
            btnNuevoUsuario.Margin = new Padding(3, 8, 3, 8);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(179, 43);
            btnNuevoUsuario.TabIndex = 2;
            btnNuevoUsuario.Text = "+ Nuevo usuario";
            btnNuevoUsuario.UseVisualStyleBackColor = false;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
            //
            // dgvUsuarios
            //
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 244, 246);
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.ColumnHeadersHeight = 36;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colUsuario, colCorreo, colTelefono, colRol, colActivo, colIconoEditar, colIconoEstado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 93, 122);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Margin = new Padding(10, 0, 12, 10);
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.FromArgb(229, 231, 235);
            dgvUsuarios.Location = new Point(3, 67);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(588, 623);
            dgvUsuarios.TabIndex = 1;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            dgvUsuarios.CellMouseMove += dgvUsuarios_CellMouseMove;
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
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            //
            // colUsuario
            //
            colUsuario.HeaderText = "Usuario";
            colUsuario.MinimumWidth = 6;
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            //
            // colCorreo
            //
            colCorreo.HeaderText = "Correo";
            colCorreo.MinimumWidth = 6;
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            //
            // colTelefono
            //
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            //
            // colRol
            //
            colRol.HeaderText = "Rol";
            colRol.MinimumWidth = 6;
            colRol.Name = "colRol";
            colRol.ReadOnly = true;
            //
            // colActivo
            //
            colActivo.HeaderText = "Activo";
            colActivo.MinimumWidth = 6;
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            //
            // colIconoEditar
            // 
            colIconoEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colIconoEditar.HeaderText = "Editar";
            colIconoEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colIconoEditar.MinimumWidth = 50;
            colIconoEditar.Name = "colIconoEditar";
            colIconoEditar.Width = 50;
            // 
            // colIconoEstado
            // 
            colIconoEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colIconoEstado.HeaderText = "Estado";
            colIconoEstado.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colIconoEstado.MinimumWidth = 50;
            colIconoEstado.Name = "colIconoEstado";
            colIconoEstado.Width = 50;
            //
            // RegistrarUsuariosControl
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(tableLayoutPanel1);
            Name = "RegistrarUsuariosControl";
            Size = new Size(594, 693);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutToolbar.ResumeLayout(false);
            tableLayoutBuscar.ResumeLayout(false);
            tableLayoutBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutToolbar;
        private TableLayoutPanel tableLayoutBuscar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnNuevoUsuario;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colRol;
        private DataGridViewTextBoxColumn colActivo;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewImageColumn colIconoEditar;
        private DataGridViewImageColumn colIconoEstado;
    }
}
