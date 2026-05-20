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
            PanelAdminUsuarios = new Panel();
            tableLayoutFormulario = new TableLayoutPanel();
            label1 = new Label();
            labelNombre = new Label();
            txtNombreUsu = new TextBox();
            labelApellido = new Label();
            txtApellidoUsu = new TextBox();
            labelCorreoUsu = new Label();
            txtCorreoUsu = new TextBox();
            labelTelefono = new Label();
            txtTelefonoUsu = new TextBox();
            labelDireccionUsu = new Label();
            txtDireccionUsu = new TextBox();
            label6 = new Label();
            txtNombreUsuarioUsu = new TextBox();
            labelContraseña = new Label();
            txtContrasenaUsu = new TextBox();
            flowLayoutPanelBotones = new FlowLayoutPanel();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            PanelAdminUsuarios.SuspendLayout();
            tableLayoutFormulario.SuspendLayout();
            flowLayoutPanelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // PanelAdminUsuarios
            // 
            PanelAdminUsuarios.Controls.Add(tableLayoutFormulario);
            PanelAdminUsuarios.Dock = DockStyle.Fill;
            PanelAdminUsuarios.Location = new Point(0, 0);
            PanelAdminUsuarios.Name = "PanelAdminUsuarios";
            PanelAdminUsuarios.Padding = new Padding(24, 16, 24, 24);
            PanelAdminUsuarios.Size = new Size(520, 520);
            PanelAdminUsuarios.TabIndex = 3;
            // 
            // tableLayoutFormulario
            // 
            tableLayoutFormulario.ColumnCount = 2;
            tableLayoutFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutFormulario.Controls.Add(label1, 0, 0);
            tableLayoutFormulario.Controls.Add(labelNombre, 0, 1);
            tableLayoutFormulario.Controls.Add(txtNombreUsu, 1, 1);
            tableLayoutFormulario.Controls.Add(labelApellido, 0, 2);
            tableLayoutFormulario.Controls.Add(txtApellidoUsu, 1, 2);
            tableLayoutFormulario.Controls.Add(labelCorreoUsu, 0, 3);
            tableLayoutFormulario.Controls.Add(txtCorreoUsu, 1, 3);
            tableLayoutFormulario.Controls.Add(labelTelefono, 0, 4);
            tableLayoutFormulario.Controls.Add(txtTelefonoUsu, 1, 4);
            tableLayoutFormulario.Controls.Add(labelDireccionUsu, 0, 5);
            tableLayoutFormulario.Controls.Add(txtDireccionUsu, 1, 5);
            tableLayoutFormulario.Controls.Add(label6, 0, 6);
            tableLayoutFormulario.Controls.Add(txtNombreUsuarioUsu, 1, 6);
            tableLayoutFormulario.Controls.Add(labelContraseña, 0, 7);
            tableLayoutFormulario.Controls.Add(txtContrasenaUsu, 1, 7);
            tableLayoutFormulario.Controls.Add(flowLayoutPanelBotones, 1, 8);
            tableLayoutFormulario.Dock = DockStyle.Top;
            tableLayoutFormulario.Location = new Point(24, 16);
            tableLayoutFormulario.Name = "tableLayoutFormulario";
            tableLayoutFormulario.RowCount = 9;
            tableLayoutFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutFormulario.SetColumnSpan(label1, 2);
            tableLayoutFormulario.Size = new Size(472, 436);
            tableLayoutFormulario.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(466, 44);
            label1.TabIndex = 2;
            label1.Text = "Registrar Usuario";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNombre
            // 
            labelNombre.Dock = DockStyle.Fill;
            labelNombre.Location = new Point(3, 44);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(134, 48);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            labelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombreUsu
            // 
            txtNombreUsu.Dock = DockStyle.Fill;
            txtNombreUsu.Location = new Point(143, 47);
            txtNombreUsu.Name = "txtNombreUsu";
            txtNombreUsu.Size = new Size(326, 23);
            txtNombreUsu.TabIndex = 3;
            // 
            // labelApellido
            // 
            labelApellido.Dock = DockStyle.Fill;
            labelApellido.Location = new Point(3, 92);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(134, 48);
            labelApellido.TabIndex = 4;
            labelApellido.Text = "Apellido";
            labelApellido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtApellidoUsu
            // 
            txtApellidoUsu.Dock = DockStyle.Fill;
            txtApellidoUsu.Location = new Point(143, 95);
            txtApellidoUsu.Name = "txtApellidoUsu";
            txtApellidoUsu.Size = new Size(326, 23);
            txtApellidoUsu.TabIndex = 5;
            // 
            // labelCorreoUsu
            // 
            labelCorreoUsu.Dock = DockStyle.Fill;
            labelCorreoUsu.Location = new Point(3, 140);
            labelCorreoUsu.Name = "labelCorreoUsu";
            labelCorreoUsu.Size = new Size(134, 48);
            labelCorreoUsu.TabIndex = 6;
            labelCorreoUsu.Text = "Correo";
            labelCorreoUsu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCorreoUsu
            // 
            txtCorreoUsu.Dock = DockStyle.Fill;
            txtCorreoUsu.Location = new Point(143, 143);
            txtCorreoUsu.Name = "txtCorreoUsu";
            txtCorreoUsu.Size = new Size(326, 23);
            txtCorreoUsu.TabIndex = 7;
            // 
            // labelTelefono
            // 
            labelTelefono.Dock = DockStyle.Fill;
            labelTelefono.Location = new Point(3, 188);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(134, 48);
            labelTelefono.TabIndex = 8;
            labelTelefono.Text = "Teléfono";
            labelTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTelefonoUsu
            // 
            txtTelefonoUsu.Dock = DockStyle.Fill;
            txtTelefonoUsu.Location = new Point(143, 191);
            txtTelefonoUsu.Name = "txtTelefonoUsu";
            txtTelefonoUsu.Size = new Size(326, 23);
            txtTelefonoUsu.TabIndex = 9;
            // 
            // labelDireccionUsu
            // 
            labelDireccionUsu.Dock = DockStyle.Fill;
            labelDireccionUsu.Location = new Point(3, 236);
            labelDireccionUsu.Name = "labelDireccionUsu";
            labelDireccionUsu.Size = new Size(134, 48);
            labelDireccionUsu.TabIndex = 16;
            labelDireccionUsu.Text = "Dirección";
            labelDireccionUsu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDireccionUsu
            // 
            txtDireccionUsu.Dock = DockStyle.Fill;
            txtDireccionUsu.Location = new Point(143, 239);
            txtDireccionUsu.Name = "txtDireccionUsu";
            txtDireccionUsu.Size = new Size(326, 23);
            txtDireccionUsu.TabIndex = 17;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 284);
            label6.Name = "label6";
            label6.Size = new Size(134, 48);
            label6.TabIndex = 10;
            label6.Text = "Usuario";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombreUsuarioUsu
            // 
            txtNombreUsuarioUsu.Dock = DockStyle.Fill;
            txtNombreUsuarioUsu.Location = new Point(143, 287);
            txtNombreUsuarioUsu.Name = "txtNombreUsuarioUsu";
            txtNombreUsuarioUsu.Size = new Size(326, 23);
            txtNombreUsuarioUsu.TabIndex = 11;
            // 
            // labelContraseña
            // 
            labelContraseña.Dock = DockStyle.Fill;
            labelContraseña.Location = new Point(3, 332);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(134, 48);
            labelContraseña.TabIndex = 12;
            labelContraseña.Text = "Contraseña";
            labelContraseña.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtContrasenaUsu
            // 
            txtContrasenaUsu.Dock = DockStyle.Fill;
            txtContrasenaUsu.Location = new Point(143, 335);
            txtContrasenaUsu.Name = "txtContrasenaUsu";
            txtContrasenaUsu.Size = new Size(326, 23);
            txtContrasenaUsu.TabIndex = 13;
            txtContrasenaUsu.UseSystemPasswordChar = true;
            // 
            // flowLayoutPanelBotones
            // 
            flowLayoutPanelBotones.Controls.Add(btnLimpiar);
            flowLayoutPanelBotones.Controls.Add(btnRegistrar);
            flowLayoutPanelBotones.Dock = DockStyle.Fill;
            flowLayoutPanelBotones.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBotones.Location = new Point(143, 383);
            flowLayoutPanelBotones.Name = "flowLayoutPanelBotones";
            flowLayoutPanelBotones.Padding = new Padding(0, 8, 0, 0);
            flowLayoutPanelBotones.Size = new Size(326, 50);
            flowLayoutPanelBotones.TabIndex = 18;
            flowLayoutPanelBotones.WrapContents = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(168, 11);
            btnLimpiar.Margin = new Padding(8, 0, 0, 0);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 42);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(10, 11);
            btnRegistrar.Margin = new Padding(8, 0, 0, 0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 42);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // RegistrarUsuariosControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelAdminUsuarios);
            Name = "RegistrarUsuariosControl";
            Size = new Size(520, 520);
            PanelAdminUsuarios.ResumeLayout(false);
            tableLayoutFormulario.ResumeLayout(false);
            tableLayoutFormulario.PerformLayout();
            flowLayoutPanelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelAdminUsuarios;
        private TableLayoutPanel tableLayoutFormulario;
        private Label labelNombre;
        private TextBox txtNombreUsu;
        private Label labelApellido;
        private TextBox txtApellidoUsu;
        private Label labelCorreoUsu;
        private TextBox txtCorreoUsu;
        private Label labelTelefono;
        private TextBox txtTelefonoUsu;
        private Label label6;
        private TextBox txtNombreUsuarioUsu;
        private Label labelContraseña;
        private TextBox txtContrasenaUsu;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Label labelDireccionUsu;
        private Label label1;
        private TextBox txtDireccionUsu;
        private FlowLayoutPanel flowLayoutPanelBotones;
    }
}
