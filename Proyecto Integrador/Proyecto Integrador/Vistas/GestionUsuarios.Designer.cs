namespace Proyecto_Integrador.Vistas
{
    partial class GestionUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelSuperior;
        private Label lblTitulo;

        private DataGridView dgvUsuarios;

        private Button btnCambiarEstado;
        private Button btnActualizar;
        private Button btnCerrar;

        private TextBox txtBuscar;
        private Label lblBuscar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelSuperior = new Panel();
            lblTitulo = new Label();
            dgvUsuarios = new DataGridView();
            btnCambiarEstado = new Button();
            btnActualizar = new Button();
            btnCerrar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(30, 30, 30);
            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Margin = new Padding(3, 4, 3, 4);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1371, 107);
            panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(29, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(338, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(34, 200);
            dgvUsuarios.Margin = new Padding(3, 4, 3, 4);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(1291, 600);
            dgvUsuarios.TabIndex = 3;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.BackColor = Color.ForestGreen;
            btnCambiarEstado.FlatStyle = FlatStyle.Flat;
            btnCambiarEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCambiarEstado.ForeColor = Color.White;
            btnCambiarEstado.Location = new Point(34, 833);
            btnCambiarEstado.Margin = new Padding(3, 4, 3, 4);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(175, 53);
            btnCambiarEstado.TabIndex = 4;
            btnCambiarEstado.Text = "Activar/Desactivar";
            btnCambiarEstado.UseVisualStyleBackColor = false;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DodgerBlue;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(255, 833);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(160, 53);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(0, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 7;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(114, 136);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar usuario...";
            txtBuscar.Size = new Size(342, 27);
            txtBuscar.TabIndex = 2;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBuscar.Location = new Point(34, 140);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(68, 23);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1371, 933);
            Controls.Add(panelSuperior);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnCambiarEstado);
            Controls.Add(btnActualizar);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "GestionUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Usuarios";
            Load += GestionUsuarios_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}