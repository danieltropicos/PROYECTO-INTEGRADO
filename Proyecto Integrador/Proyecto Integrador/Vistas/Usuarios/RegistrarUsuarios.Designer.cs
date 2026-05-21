namespace Proyecto_Integrador.Vistas.Usuarios
{
    partial class RegistrarUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tableLayoutMain = new TableLayoutPanel();
            panelBrand = new Panel();
            tableLayoutLogo = new TableLayoutPanel();
            picLogo = new PictureBox();
            panelForm = new Panel();
            tableLayoutCentro = new TableLayoutPanel();
            tableLayoutForm = new TableLayoutPanel();
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
            tableLayoutContraseña = new TableLayoutPanel();
            txtContrasenaUsu = new TextBox();
            tableLayoutOjo = new TableLayoutPanel();
            picOjo = new PictureBox();
            flowLayoutPanelBotones = new FlowLayoutPanel();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            lnkVolver = new LinkLabel();
            tableLayoutMain.SuspendLayout();
            panelBrand.SuspendLayout();
            tableLayoutLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelForm.SuspendLayout();
            tableLayoutCentro.SuspendLayout();
            tableLayoutForm.SuspendLayout();
            tableLayoutContraseña.SuspendLayout();
            tableLayoutOjo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOjo).BeginInit();
            flowLayoutPanelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutMain.Controls.Add(panelBrand, 0, 0);
            tableLayoutMain.Controls.Add(panelForm, 1, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 1;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(920, 580);
            tableLayoutMain.TabIndex = 0;
            // 
            // panelBrand
            // 
            panelBrand.BackColor = Color.FromArgb(30, 58, 95);
            panelBrand.Controls.Add(tableLayoutLogo);
            panelBrand.Dock = DockStyle.Fill;
            panelBrand.Location = new Point(0, 0);
            panelBrand.Margin = new Padding(0);
            panelBrand.Name = "panelBrand";
            panelBrand.Size = new Size(276, 580);
            panelBrand.TabIndex = 0;
            // 
            // tableLayoutLogo
            // 
            tableLayoutLogo.ColumnCount = 3;
            tableLayoutLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutLogo.Controls.Add(picLogo, 1, 1);
            tableLayoutLogo.Dock = DockStyle.Fill;
            tableLayoutLogo.Location = new Point(0, 0);
            tableLayoutLogo.Name = "tableLayoutLogo";
            tableLayoutLogo.RowCount = 3;
            tableLayoutLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutLogo.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F));
            tableLayoutLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutLogo.Size = new Size(276, 580);
            tableLayoutLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Dock = DockStyle.Fill;
            picLogo.ImageLocation = "Recursos\\Imagenes\\logo-center.png";
            picLogo.Location = new Point(-62, 160);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(400, 260);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panelForm
            // 
            panelForm.AutoScroll = true;
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(tableLayoutCentro);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(276, 0);
            panelForm.Margin = new Padding(0);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(24);
            panelForm.Size = new Size(644, 580);
            panelForm.TabIndex = 1;
            // 
            // tableLayoutCentro
            // 
            tableLayoutCentro.ColumnCount = 3;
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 480F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Controls.Add(tableLayoutForm, 1, 1);
            tableLayoutCentro.Dock = DockStyle.Fill;
            tableLayoutCentro.Location = new Point(24, 24);
            tableLayoutCentro.Name = "tableLayoutCentro";
            tableLayoutCentro.RowCount = 3;
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.RowStyles.Add(new RowStyle());
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Size = new Size(596, 532);
            tableLayoutCentro.TabIndex = 0;
            // 
            // tableLayoutForm
            // 
            tableLayoutForm.AutoSize = true;
            tableLayoutForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutForm.ColumnCount = 2;
            tableLayoutForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutForm.Controls.Add(label1, 0, 0);
            tableLayoutForm.Controls.Add(labelNombre, 0, 1);
            tableLayoutForm.Controls.Add(txtNombreUsu, 1, 1);
            tableLayoutForm.Controls.Add(labelApellido, 0, 2);
            tableLayoutForm.Controls.Add(txtApellidoUsu, 1, 2);
            tableLayoutForm.Controls.Add(labelCorreoUsu, 0, 3);
            tableLayoutForm.Controls.Add(txtCorreoUsu, 1, 3);
            tableLayoutForm.Controls.Add(labelTelefono, 0, 4);
            tableLayoutForm.Controls.Add(txtTelefonoUsu, 1, 4);
            tableLayoutForm.Controls.Add(labelDireccionUsu, 0, 5);
            tableLayoutForm.Controls.Add(txtDireccionUsu, 1, 5);
            tableLayoutForm.Controls.Add(label6, 0, 6);
            tableLayoutForm.Controls.Add(txtNombreUsuarioUsu, 1, 6);
            tableLayoutForm.Controls.Add(labelContraseña, 0, 7);
            tableLayoutForm.Controls.Add(tableLayoutContraseña, 1, 7);
            tableLayoutForm.Controls.Add(flowLayoutPanelBotones, 1, 8);
            tableLayoutForm.Controls.Add(lnkVolver, 0, 9);
            tableLayoutForm.Dock = DockStyle.Top;
            tableLayoutForm.Location = new Point(58, 47);
            tableLayoutForm.Margin = new Padding(0);
            tableLayoutForm.Name = "tableLayoutForm";
            tableLayoutForm.RowCount = 10;
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutForm.RowStyles.Add(new RowStyle());
            tableLayoutForm.Size = new Size(480, 437);
            tableLayoutForm.TabIndex = 0;
            // 
            // label1
            // 
            tableLayoutForm.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(30, 58, 95);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(474, 52);
            label1.TabIndex = 0;
            label1.Text = "Registrar usuario";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNombre
            // 
            labelNombre.Dock = DockStyle.Fill;
            labelNombre.Font = new Font("Segoe UI", 10F);
            labelNombre.ForeColor = Color.FromArgb(75, 85, 99);
            labelNombre.Location = new Point(3, 52);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(134, 44);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre";
            labelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombreUsu
            // 
            txtNombreUsu.BackColor = Color.White;
            txtNombreUsu.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsu.Dock = DockStyle.Fill;
            txtNombreUsu.Font = new Font("Segoe UI", 10F);
            txtNombreUsu.Location = new Point(143, 55);
            txtNombreUsu.Margin = new Padding(3, 3, 3, 6);
            txtNombreUsu.Name = "txtNombreUsu";
            txtNombreUsu.Size = new Size(334, 25);
            txtNombreUsu.TabIndex = 2;
            // 
            // labelApellido
            // 
            labelApellido.Dock = DockStyle.Fill;
            labelApellido.Font = new Font("Segoe UI", 10F);
            labelApellido.ForeColor = Color.FromArgb(75, 85, 99);
            labelApellido.Location = new Point(3, 96);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(134, 44);
            labelApellido.TabIndex = 3;
            labelApellido.Text = "Apellido";
            labelApellido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtApellidoUsu
            // 
            txtApellidoUsu.BackColor = Color.White;
            txtApellidoUsu.BorderStyle = BorderStyle.FixedSingle;
            txtApellidoUsu.Dock = DockStyle.Fill;
            txtApellidoUsu.Font = new Font("Segoe UI", 10F);
            txtApellidoUsu.Location = new Point(143, 99);
            txtApellidoUsu.Margin = new Padding(3, 3, 3, 6);
            txtApellidoUsu.Name = "txtApellidoUsu";
            txtApellidoUsu.Size = new Size(334, 25);
            txtApellidoUsu.TabIndex = 4;
            // 
            // labelCorreoUsu
            // 
            labelCorreoUsu.Dock = DockStyle.Fill;
            labelCorreoUsu.Font = new Font("Segoe UI", 10F);
            labelCorreoUsu.ForeColor = Color.FromArgb(75, 85, 99);
            labelCorreoUsu.Location = new Point(3, 140);
            labelCorreoUsu.Name = "labelCorreoUsu";
            labelCorreoUsu.Size = new Size(134, 44);
            labelCorreoUsu.TabIndex = 5;
            labelCorreoUsu.Text = "Correo";
            labelCorreoUsu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCorreoUsu
            // 
            txtCorreoUsu.BackColor = Color.White;
            txtCorreoUsu.BorderStyle = BorderStyle.FixedSingle;
            txtCorreoUsu.Dock = DockStyle.Fill;
            txtCorreoUsu.Font = new Font("Segoe UI", 10F);
            txtCorreoUsu.Location = new Point(143, 143);
            txtCorreoUsu.Margin = new Padding(3, 3, 3, 6);
            txtCorreoUsu.Name = "txtCorreoUsu";
            txtCorreoUsu.Size = new Size(334, 25);
            txtCorreoUsu.TabIndex = 6;
            // 
            // labelTelefono
            // 
            labelTelefono.Dock = DockStyle.Fill;
            labelTelefono.Font = new Font("Segoe UI", 10F);
            labelTelefono.ForeColor = Color.FromArgb(75, 85, 99);
            labelTelefono.Location = new Point(3, 184);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(134, 44);
            labelTelefono.TabIndex = 7;
            labelTelefono.Text = "Teléfono";
            labelTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTelefonoUsu
            // 
            txtTelefonoUsu.BackColor = Color.White;
            txtTelefonoUsu.BorderStyle = BorderStyle.FixedSingle;
            txtTelefonoUsu.Dock = DockStyle.Fill;
            txtTelefonoUsu.Font = new Font("Segoe UI", 10F);
            txtTelefonoUsu.Location = new Point(143, 187);
            txtTelefonoUsu.Margin = new Padding(3, 3, 3, 6);
            txtTelefonoUsu.Name = "txtTelefonoUsu";
            txtTelefonoUsu.Size = new Size(334, 25);
            txtTelefonoUsu.TabIndex = 8;
            // 
            // labelDireccionUsu
            // 
            labelDireccionUsu.Dock = DockStyle.Fill;
            labelDireccionUsu.Font = new Font("Segoe UI", 10F);
            labelDireccionUsu.ForeColor = Color.FromArgb(75, 85, 99);
            labelDireccionUsu.Location = new Point(3, 228);
            labelDireccionUsu.Name = "labelDireccionUsu";
            labelDireccionUsu.Size = new Size(134, 44);
            labelDireccionUsu.TabIndex = 9;
            labelDireccionUsu.Text = "Dirección";
            labelDireccionUsu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDireccionUsu
            // 
            txtDireccionUsu.BackColor = Color.White;
            txtDireccionUsu.BorderStyle = BorderStyle.FixedSingle;
            txtDireccionUsu.Dock = DockStyle.Fill;
            txtDireccionUsu.Font = new Font("Segoe UI", 10F);
            txtDireccionUsu.Location = new Point(143, 231);
            txtDireccionUsu.Margin = new Padding(3, 3, 3, 6);
            txtDireccionUsu.Name = "txtDireccionUsu";
            txtDireccionUsu.Size = new Size(334, 25);
            txtDireccionUsu.TabIndex = 10;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.FromArgb(75, 85, 99);
            label6.Location = new Point(3, 272);
            label6.Name = "label6";
            label6.Size = new Size(134, 44);
            label6.TabIndex = 11;
            label6.Text = "Usuario";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombreUsuarioUsu
            // 
            txtNombreUsuarioUsu.BackColor = Color.White;
            txtNombreUsuarioUsu.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuarioUsu.Dock = DockStyle.Fill;
            txtNombreUsuarioUsu.Font = new Font("Segoe UI", 10F);
            txtNombreUsuarioUsu.Location = new Point(143, 275);
            txtNombreUsuarioUsu.Margin = new Padding(3, 3, 3, 6);
            txtNombreUsuarioUsu.Name = "txtNombreUsuarioUsu";
            txtNombreUsuarioUsu.Size = new Size(334, 25);
            txtNombreUsuarioUsu.TabIndex = 12;
            // 
            // labelContraseña
            // 
            labelContraseña.Dock = DockStyle.Fill;
            labelContraseña.Font = new Font("Segoe UI", 10F);
            labelContraseña.ForeColor = Color.FromArgb(75, 85, 99);
            labelContraseña.Location = new Point(3, 316);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(134, 44);
            labelContraseña.TabIndex = 13;
            labelContraseña.Text = "Contraseña";
            labelContraseña.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutContraseña
            // 
            tableLayoutContraseña.ColumnCount = 2;
            tableLayoutContraseña.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutContraseña.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutContraseña.Controls.Add(txtContrasenaUsu, 0, 0);
            tableLayoutContraseña.Controls.Add(tableLayoutOjo, 1, 0);
            tableLayoutContraseña.Dock = DockStyle.Fill;
            tableLayoutContraseña.Location = new Point(143, 319);
            tableLayoutContraseña.Margin = new Padding(3, 3, 3, 6);
            tableLayoutContraseña.Name = "tableLayoutContraseña";
            tableLayoutContraseña.RowCount = 1;
            tableLayoutContraseña.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutContraseña.Size = new Size(334, 35);
            tableLayoutContraseña.TabIndex = 14;
            // 
            // txtContrasenaUsu
            // 
            txtContrasenaUsu.BackColor = Color.White;
            txtContrasenaUsu.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenaUsu.Dock = DockStyle.Fill;
            txtContrasenaUsu.Font = new Font("Segoe UI", 10F);
            txtContrasenaUsu.Location = new Point(3, 3);
            txtContrasenaUsu.Margin = new Padding(3, 3, 6, 3);
            txtContrasenaUsu.Name = "txtContrasenaUsu";
            txtContrasenaUsu.Size = new Size(295, 25);
            txtContrasenaUsu.TabIndex = 0;
            txtContrasenaUsu.UseSystemPasswordChar = true;
            // 
            // tableLayoutOjo
            // 
            tableLayoutOjo.ColumnCount = 1;
            tableLayoutOjo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutOjo.Controls.Add(picOjo, 0, 1);
            tableLayoutOjo.Dock = DockStyle.Fill;
            tableLayoutOjo.Location = new Point(304, 0);
            tableLayoutOjo.Margin = new Padding(0);
            tableLayoutOjo.Name = "tableLayoutOjo";
            tableLayoutOjo.RowCount = 3;
            tableLayoutOjo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOjo.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutOjo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOjo.Size = new Size(30, 35);
            tableLayoutOjo.TabIndex = 2;
            // 
            // picOjo
            // 
            picOjo.BackColor = Color.Transparent;
            picOjo.Cursor = Cursors.Hand;
            picOjo.Dock = DockStyle.Fill;
            picOjo.ImageLocation = "Recursos\\Imagenes\\ojoCerrado.jpg";
            picOjo.Location = new Point(2, 5);
            picOjo.Margin = new Padding(2);
            picOjo.Name = "picOjo";
            picOjo.Size = new Size(26, 24);
            picOjo.SizeMode = PictureBoxSizeMode.Zoom;
            picOjo.TabIndex = 0;
            picOjo.TabStop = false;
            picOjo.Click += picOjo_Click;
            // 
            // flowLayoutPanelBotones
            // 
            flowLayoutPanelBotones.Controls.Add(btnLimpiar);
            flowLayoutPanelBotones.Controls.Add(btnRegistrar);
            flowLayoutPanelBotones.Dock = DockStyle.Fill;
            flowLayoutPanelBotones.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBotones.Location = new Point(143, 364);
            flowLayoutPanelBotones.Margin = new Padding(3, 4, 3, 3);
            flowLayoutPanelBotones.Name = "flowLayoutPanelBotones";
            flowLayoutPanelBotones.Padding = new Padding(0, 6, 0, 0);
            flowLayoutPanelBotones.Size = new Size(334, 49);
            flowLayoutPanelBotones.TabIndex = 15;
            flowLayoutPanelBotones.WrapContents = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(229, 231, 235);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F);
            btnLimpiar.ForeColor = Color.FromArgb(17, 24, 39);
            btnLimpiar.Location = new Point(189, 6);
            btnLimpiar.Margin = new Padding(8, 0, 0, 0);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(145, 40);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(245, 158, 11);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 119, 6);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(36, 6);
            btnRegistrar.Margin = new Padding(8, 0, 0, 0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(145, 40);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lnkVolver
            // 
            lnkVolver.ActiveLinkColor = Color.FromArgb(30, 58, 95);
            lnkVolver.AutoSize = true;
            lnkVolver.BackColor = Color.White;
            tableLayoutForm.SetColumnSpan(lnkVolver, 2);
            lnkVolver.Cursor = Cursors.Hand;
            lnkVolver.Font = new Font("Segoe UI", 9F);
            lnkVolver.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkVolver.LinkColor = Color.FromArgb(59, 93, 122);
            lnkVolver.Location = new Point(3, 422);
            lnkVolver.Margin = new Padding(3, 6, 3, 0);
            lnkVolver.Name = "lnkVolver";
            lnkVolver.Size = new Size(148, 15);
            lnkVolver.TabIndex = 16;
            lnkVolver.TabStop = true;
            lnkVolver.Text = "← Volver al inicio de sesión";
            lnkVolver.VisitedLinkColor = Color.FromArgb(59, 93, 122);
            lnkVolver.LinkClicked += lnkVolver_LinkClicked;
            // 
            // RegistrarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(920, 580);
            Controls.Add(tableLayoutMain);
            MinimumSize = new Size(800, 520);
            Name = "RegistrarUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar usuario";
            WindowState = FormWindowState.Maximized;
            tableLayoutMain.ResumeLayout(false);
            panelBrand.ResumeLayout(false);
            tableLayoutLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelForm.ResumeLayout(false);
            tableLayoutCentro.ResumeLayout(false);
            tableLayoutCentro.PerformLayout();
            tableLayoutForm.ResumeLayout(false);
            tableLayoutForm.PerformLayout();
            tableLayoutContraseña.ResumeLayout(false);
            tableLayoutContraseña.PerformLayout();
            tableLayoutOjo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picOjo).EndInit();
            flowLayoutPanelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutMain;
        private Panel panelBrand;
        private TableLayoutPanel tableLayoutLogo;
        private PictureBox picLogo;
        private Panel panelForm;
        private TableLayoutPanel tableLayoutCentro;
        private TableLayoutPanel tableLayoutForm;
        private Label label1;
        private Label labelNombre;
        private TextBox txtNombreUsu;
        private Label labelApellido;
        private TextBox txtApellidoUsu;
        private Label labelCorreoUsu;
        private TextBox txtCorreoUsu;
        private Label labelTelefono;
        private TextBox txtTelefonoUsu;
        private Label labelDireccionUsu;
        private TextBox txtDireccionUsu;
        private Label label6;
        private TextBox txtNombreUsuarioUsu;
        private Label labelContraseña;
        private TableLayoutPanel tableLayoutContraseña;
        private TextBox txtContrasenaUsu;
        private TableLayoutPanel tableLayoutOjo;
        private PictureBox picOjo;
        private FlowLayoutPanel flowLayoutPanelBotones;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private LinkLabel lnkVolver;
    }
}
