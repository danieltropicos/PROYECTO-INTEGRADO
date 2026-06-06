namespace Proyecto_Integrador.Vistas.Login
{
    partial class Login
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
            panelBrand = new PanelLateralLogin();
            picLogoGeoterra = new PictureBox();
            lblSubtitulo = new Label();
            panelForm = new Panel();
            tableLayoutCentro = new TableLayoutPanel();
            panelMarco = new Panel();
            panelCard = new Panel();
            tableLayoutForm = new TableLayoutPanel();
            picIconoFormulario = new PictureBox();
            lblTitulo = new Label();
            panelLineaTitulo = new Panel();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            panelFilaContraseña = new Panel();
            tableLayoutFilaContraseña = new TableLayoutPanel();
            txtContraseña = new TextBox();
            picOjo = new PictureBox();
            btnIngresar = new Button();
            tableLayoutSeguro = new TableLayoutPanel();
            picEscudo = new PictureBox();
            lblSeguro = new Label();
            tableLayoutMain.SuspendLayout();
            panelBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoGeoterra).BeginInit();
            panelForm.SuspendLayout();
            tableLayoutCentro.SuspendLayout();
            panelMarco.SuspendLayout();
            panelCard.SuspendLayout();
            tableLayoutForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconoFormulario).BeginInit();
            panelFilaContraseña.SuspendLayout();
            tableLayoutFilaContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOjo).BeginInit();
            tableLayoutSeguro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEscudo).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.BackColor = Color.FromArgb(237, 241, 245);
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56F));
            tableLayoutMain.Controls.Add(panelBrand, 0, 0);
            tableLayoutMain.Controls.Add(panelForm, 1, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 1;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(1050, 525);
            tableLayoutMain.TabIndex = 0;
            // 
            // panelBrand
            // 
            panelBrand.BackColor = Color.FromArgb(237, 241, 245);
            panelBrand.Controls.Add(picLogoGeoterra);
            panelBrand.Controls.Add(lblSubtitulo);
            panelBrand.Dock = DockStyle.Fill;
            panelBrand.Location = new Point(0, 0);
            panelBrand.Margin = new Padding(0);
            panelBrand.Name = "panelBrand";
            panelBrand.Size = new Size(462, 525);
            panelBrand.TabIndex = 0;
            // 
            // picLogoGeoterra
            // 
            picLogoGeoterra.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picLogoGeoterra.BackColor = Color.Transparent;
            picLogoGeoterra.Location = new Point(61, 116);
            picLogoGeoterra.Margin = new Padding(3, 2, 3, 2);
            picLogoGeoterra.Name = "picLogoGeoterra";
            picLogoGeoterra.Size = new Size(307, 210);
            picLogoGeoterra.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoGeoterra.TabIndex = 0;
            picLogoGeoterra.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(200, 210, 225);
            lblSubtitulo.Location = new Point(61, 346);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Padding = new Padding(7, 0, 7, 9);
            lblSubtitulo.Size = new Size(307, 46);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gestión inteligente para proyectos de movimiento de tierra";
            lblSubtitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(237, 241, 245);
            panelForm.Controls.Add(tableLayoutCentro);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(462, 0);
            panelForm.Margin = new Padding(0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(588, 525);
            panelForm.TabIndex = 1;
            // 
            // tableLayoutCentro
            // 
            tableLayoutCentro.ColumnCount = 3;
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 455F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Controls.Add(panelMarco, 1, 1);
            tableLayoutCentro.Dock = DockStyle.Fill;
            tableLayoutCentro.Location = new Point(0, 0);
            tableLayoutCentro.Margin = new Padding(0);
            tableLayoutCentro.Name = "tableLayoutCentro";
            tableLayoutCentro.Padding = new Padding(0, 18, 21, 18);
            tableLayoutCentro.RowCount = 3;
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 435F));
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Size = new Size(588, 525);
            tableLayoutCentro.TabIndex = 0;
            // 
            // panelMarco
            // 
            panelMarco.BackColor = Color.FromArgb(190, 198, 210);
            panelMarco.Controls.Add(panelCard);
            panelMarco.Dock = DockStyle.Fill;
            panelMarco.Location = new Point(56, 45);
            panelMarco.Margin = new Padding(0);
            panelMarco.Name = "panelMarco";
            panelMarco.Padding = new Padding(0, 0, 9, 8);
            panelMarco.Size = new Size(455, 435);
            panelMarco.TabIndex = 0;
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.White;
            panelCard.Controls.Add(tableLayoutForm);
            panelCard.Dock = DockStyle.Fill;
            panelCard.Location = new Point(0, 0);
            panelCard.Margin = new Padding(3, 2, 3, 2);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(38, 30, 38, 24);
            panelCard.Size = new Size(446, 427);
            panelCard.TabIndex = 0;
            // 
            // tableLayoutForm
            // 
            tableLayoutForm.ColumnCount = 3;
            tableLayoutForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutForm.Controls.Add(picIconoFormulario, 1, 0);
            tableLayoutForm.Controls.Add(lblTitulo, 0, 1);
            tableLayoutForm.Controls.Add(panelLineaTitulo, 1, 2);
            tableLayoutForm.Controls.Add(lblUsuario, 0, 3);
            tableLayoutForm.Controls.Add(txtUsuario, 0, 4);
            tableLayoutForm.Controls.Add(lblContraseña, 0, 5);
            tableLayoutForm.Controls.Add(panelFilaContraseña, 0, 6);
            tableLayoutForm.Controls.Add(btnIngresar, 0, 7);
            tableLayoutForm.Controls.Add(tableLayoutSeguro, 0, 8);
            tableLayoutForm.Dock = DockStyle.Fill;
            tableLayoutForm.Location = new Point(38, 30);
            tableLayoutForm.Margin = new Padding(3, 2, 3, 2);
            tableLayoutForm.Name = "tableLayoutForm";
            tableLayoutForm.RowCount = 9;
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutForm.Size = new Size(370, 373);
            tableLayoutForm.TabIndex = 0;
            // 
            // picIconoFormulario
            // 
            picIconoFormulario.Dock = DockStyle.Fill;
            picIconoFormulario.Location = new Point(128, 2);
            picIconoFormulario.Margin = new Padding(3, 2, 3, 2);
            picIconoFormulario.Name = "picIconoFormulario";
            picIconoFormulario.Size = new Size(114, 50);
            picIconoFormulario.SizeMode = PictureBoxSizeMode.Zoom;
            picIconoFormulario.TabIndex = 0;
            picIconoFormulario.TabStop = false;
            // 
            // lblTitulo
            // 
            tableLayoutForm.SetColumnSpan(lblTitulo, 3);
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 58, 95);
            lblTitulo.Location = new Point(3, 54);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(364, 36);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Inicio de sesión";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLineaTitulo
            // 
            panelLineaTitulo.BackColor = Color.FromArgb(245, 158, 11);
            panelLineaTitulo.Location = new Point(128, 92);
            panelLineaTitulo.Margin = new Padding(3, 2, 3, 6);
            panelLineaTitulo.Name = "panelLineaTitulo";
            panelLineaTitulo.Size = new Size(114, 4);
            panelLineaTitulo.TabIndex = 2;
            // 
            // lblUsuario
            // 
            tableLayoutForm.SetColumnSpan(lblUsuario, 3);
            lblUsuario.Dock = DockStyle.Fill;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.ForeColor = Color.FromArgb(75, 85, 99);
            lblUsuario.Location = new Point(3, 102);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(364, 21);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutForm.SetColumnSpan(txtUsuario, 3);
            txtUsuario.Dock = DockStyle.Fill;
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(0, 123);
            txtUsuario.Margin = new Padding(0);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(370, 27);
            txtUsuario.TabIndex = 4;
            // 
            // lblContraseña
            // 
            tableLayoutForm.SetColumnSpan(lblContraseña, 3);
            lblContraseña.Dock = DockStyle.Fill;
            lblContraseña.Font = new Font("Segoe UI", 10F);
            lblContraseña.ForeColor = Color.FromArgb(75, 85, 99);
            lblContraseña.Location = new Point(3, 159);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(364, 22);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "Contraseña";
            lblContraseña.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panelFilaContraseña
            // 
            tableLayoutForm.SetColumnSpan(panelFilaContraseña, 3);
            panelFilaContraseña.Controls.Add(tableLayoutFilaContraseña);
            panelFilaContraseña.Dock = DockStyle.Fill;
            panelFilaContraseña.Location = new Point(0, 181);
            panelFilaContraseña.Margin = new Padding(0);
            panelFilaContraseña.Name = "panelFilaContraseña";
            panelFilaContraseña.Size = new Size(370, 39);
            panelFilaContraseña.TabIndex = 6;
            // 
            // tableLayoutFilaContraseña
            // 
            tableLayoutFilaContraseña.ColumnCount = 2;
            tableLayoutFilaContraseña.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutFilaContraseña.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutFilaContraseña.Controls.Add(txtContraseña, 0, 0);
            tableLayoutFilaContraseña.Controls.Add(picOjo, 1, 0);
            tableLayoutFilaContraseña.Dock = DockStyle.Fill;
            tableLayoutFilaContraseña.Location = new Point(0, 0);
            tableLayoutFilaContraseña.Margin = new Padding(0);
            tableLayoutFilaContraseña.Name = "tableLayoutFilaContraseña";
            tableLayoutFilaContraseña.RowCount = 1;
            tableLayoutFilaContraseña.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutFilaContraseña.Size = new Size(370, 39);
            tableLayoutFilaContraseña.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Dock = DockStyle.Fill;
            txtContraseña.Font = new Font("Segoe UI", 11F);
            txtContraseña.Location = new Point(0, 0);
            txtContraseña.Margin = new Padding(0);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(335, 27);
            txtContraseña.TabIndex = 0;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // picOjo
            // 
            picOjo.Cursor = Cursors.Hand;
            picOjo.Location = new Point(339, 6);
            picOjo.Margin = new Padding(4, 6, 0, 6);
            picOjo.Name = "picOjo";
            picOjo.Size = new Size(28, 13);
            picOjo.SizeMode = PictureBoxSizeMode.Zoom;
            picOjo.TabIndex = 1;
            picOjo.TabStop = false;
            picOjo.Click += picOjo_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(245, 158, 11);
            tableLayoutForm.SetColumnSpan(btnIngresar, 3);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Dock = DockStyle.Fill;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 119, 6);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(0, 226);
            btnIngresar.Margin = new Padding(0, 6, 0, 0);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(370, 39);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // tableLayoutSeguro
            // 
            tableLayoutSeguro.ColumnCount = 4;
            tableLayoutForm.SetColumnSpan(tableLayoutSeguro, 3);
            tableLayoutSeguro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutSeguro.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutSeguro.ColumnStyles.Add(new ColumnStyle());
            tableLayoutSeguro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutSeguro.Controls.Add(picEscudo, 1, 0);
            tableLayoutSeguro.Controls.Add(lblSeguro, 2, 0);
            tableLayoutSeguro.Dock = DockStyle.Fill;
            tableLayoutSeguro.Location = new Point(0, 271);
            tableLayoutSeguro.Margin = new Padding(0, 6, 0, 0);
            tableLayoutSeguro.Name = "tableLayoutSeguro";
            tableLayoutSeguro.RowCount = 1;
            tableLayoutSeguro.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutSeguro.Size = new Size(370, 102);
            tableLayoutSeguro.TabIndex = 8;
            // 
            // picEscudo
            // 
            picEscudo.Anchor = AnchorStyles.None;
            picEscudo.Location = new Point(71, 40);
            picEscudo.Margin = new Padding(0, 0, 5, 0);
            picEscudo.Name = "picEscudo";
            picEscudo.Size = new Size(21, 21);
            picEscudo.SizeMode = PictureBoxSizeMode.Zoom;
            picEscudo.TabIndex = 0;
            picEscudo.TabStop = false;
            // 
            // lblSeguro
            // 
            lblSeguro.Anchor = AnchorStyles.None;
            lblSeguro.AutoSize = true;
            lblSeguro.Font = new Font("Segoe UI", 10F);
            lblSeguro.ForeColor = Color.FromArgb(107, 114, 128);
            lblSeguro.Location = new Point(97, 41);
            lblSeguro.Margin = new Padding(0);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(201, 19);
            lblSeguro.TabIndex = 1;
            lblSeguro.Text = "Acceso seguro a tu información";
            lblSeguro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 241, 245);
            ClientSize = new Size(1050, 525);
            Controls.Add(tableLayoutMain);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(790, 460);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GeoTerra — Iniciar sesión";
            WindowState = FormWindowState.Maximized;
            tableLayoutMain.ResumeLayout(false);
            panelBrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogoGeoterra).EndInit();
            panelForm.ResumeLayout(false);
            tableLayoutCentro.ResumeLayout(false);
            panelMarco.ResumeLayout(false);
            panelCard.ResumeLayout(false);
            tableLayoutForm.ResumeLayout(false);
            tableLayoutForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconoFormulario).EndInit();
            panelFilaContraseña.ResumeLayout(false);
            tableLayoutFilaContraseña.ResumeLayout(false);
            tableLayoutFilaContraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOjo).EndInit();
            tableLayoutSeguro.ResumeLayout(false);
            tableLayoutSeguro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEscudo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutMain;
        private PanelLateralLogin panelBrand;
        private PictureBox picLogoGeoterra;
        private Label lblSubtitulo;
        private Panel panelForm;
        private TableLayoutPanel tableLayoutCentro;
        private Panel panelMarco;
        private Panel panelCard;
        private TableLayoutPanel tableLayoutForm;
        private PictureBox picIconoFormulario;
        private Label lblTitulo;
        private Panel panelLineaTitulo;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private Panel panelFilaContraseña;
        private TableLayoutPanel tableLayoutFilaContraseña;
        private TextBox txtContraseña;
        private PictureBox picOjo;
        private Button btnIngresar;
        private TableLayoutPanel tableLayoutSeguro;
        private PictureBox picEscudo;
        private Label lblSeguro;
    }
}
