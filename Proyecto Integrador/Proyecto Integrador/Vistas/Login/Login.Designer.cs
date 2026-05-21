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
            panelBrand = new Panel();
            tableLayoutLogo = new TableLayoutPanel();
            picLogo = new PictureBox();
            panelForm = new Panel();
            tableLayoutCentro = new TableLayoutPanel();
            tableLayoutForm = new TableLayoutPanel();
            lblTitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            tableLayoutContraseña = new TableLayoutPanel();
            txtContraseña = new TextBox();
            tableLayoutOjo = new TableLayoutPanel();
            picOjo = new PictureBox();
            btnIngresar = new Button();
            btnCrearCuenta = new Button();
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
            tableLayoutMain.Size = new Size(805, 420);
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
            panelBrand.Size = new Size(242, 420);
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
            tableLayoutLogo.Size = new Size(242, 420);
            tableLayoutLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Dock = DockStyle.Fill;
            picLogo.ImageLocation = "Recursos\\Imagenes\\logo-center.png";
            picLogo.Location = new Point(24, 145);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(194, 130);
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
            panelForm.Location = new Point(338, 0);
            panelForm.Margin = new Padding(0);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(24);
            panelForm.Size = new Size(467, 420);
            panelForm.TabIndex = 1;
            // 
            // tableLayoutCentro
            // 
            tableLayoutCentro.ColumnCount = 3;
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 440F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Controls.Add(tableLayoutForm, 1, 1);
            tableLayoutCentro.Dock = DockStyle.Fill;
            tableLayoutCentro.Location = new Point(24, 24);
            tableLayoutCentro.Name = "tableLayoutCentro";
            tableLayoutCentro.RowCount = 3;
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Size = new Size(419, 372);
            tableLayoutCentro.TabIndex = 0;
            // 
            // tableLayoutForm
            // 
            tableLayoutForm.ColumnCount = 1;
            tableLayoutForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutForm.Controls.Add(lblTitulo, 0, 0);
            tableLayoutForm.Controls.Add(lblUsuario, 0, 1);
            tableLayoutForm.Controls.Add(txtUsuario, 0, 2);
            tableLayoutForm.Controls.Add(lblContraseña, 0, 3);
            tableLayoutForm.Controls.Add(tableLayoutContraseña, 0, 4);
            tableLayoutForm.Controls.Add(btnIngresar, 0, 5);
            tableLayoutForm.Controls.Add(btnCrearCuenta, 0, 6);
            tableLayoutForm.AutoSize = true;
            tableLayoutForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutForm.Dock = DockStyle.Fill;
            tableLayoutForm.Location = new Point(13, 18);
            tableLayoutForm.Margin = new Padding(0);
            tableLayoutForm.Name = "tableLayoutForm";
            tableLayoutForm.RowCount = 7;
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutForm.Size = new Size(369, 336);
            tableLayoutForm.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 58, 95);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(363, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inicio de sesión";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Dock = DockStyle.Fill;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.ForeColor = Color.FromArgb(75, 85, 99);
            lblUsuario.Location = new Point(3, 54);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(363, 24);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Dock = DockStyle.Fill;
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(3, 80);
            txtUsuario.Margin = new Padding(3, 2, 3, 6);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(363, 27);
            txtUsuario.TabIndex = 2;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Dock = DockStyle.Fill;
            lblContraseña.Font = new Font("Segoe UI", 10F);
            lblContraseña.ForeColor = Color.FromArgb(75, 85, 99);
            lblContraseña.Location = new Point(3, 117);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(363, 24);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            lblContraseña.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutContraseña
            // 
            tableLayoutContraseña.ColumnCount = 2;
            tableLayoutContraseña.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutContraseña.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutContraseña.Controls.Add(txtContraseña, 0, 0);
            tableLayoutContraseña.Controls.Add(tableLayoutOjo, 1, 0);
            tableLayoutContraseña.Dock = DockStyle.Fill;
            tableLayoutContraseña.Location = new Point(3, 143);
            tableLayoutContraseña.Margin = new Padding(3, 2, 3, 6);
            tableLayoutContraseña.Name = "tableLayoutContraseña";
            tableLayoutContraseña.RowCount = 1;
            tableLayoutContraseña.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutContraseña.Size = new Size(363, 40);
            tableLayoutContraseña.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.White;
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Dock = DockStyle.Fill;
            txtContraseña.Font = new Font("Segoe UI", 11F);
            txtContraseña.Location = new Point(3, 2);
            txtContraseña.Margin = new Padding(3, 2, 6, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(324, 27);
            txtContraseña.TabIndex = 0;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // tableLayoutOjo
            // 
            tableLayoutOjo.ColumnCount = 1;
            tableLayoutOjo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutOjo.Controls.Add(picOjo, 0, 1);
            tableLayoutOjo.Dock = DockStyle.Fill;
            tableLayoutOjo.Location = new Point(333, 0);
            tableLayoutOjo.Margin = new Padding(0);
            tableLayoutOjo.Name = "tableLayoutOjo";
            tableLayoutOjo.RowCount = 3;
            tableLayoutOjo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOjo.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutOjo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOjo.Size = new Size(30, 40);
            tableLayoutOjo.TabIndex = 2;
            // 
            // picOjo
            // 
            picOjo.BackColor = Color.Transparent;
            picOjo.Cursor = Cursors.Hand;
            picOjo.Dock = DockStyle.Fill;
            picOjo.ImageLocation = "Recursos\\Imagenes\\ojoCerrado.jpg";
            picOjo.Margin = new Padding(2);
            picOjo.Name = "picOjo";
            picOjo.SizeMode = PictureBoxSizeMode.Zoom;
            picOjo.TabIndex = 0;
            picOjo.TabStop = false;
            picOjo.Click += picOjo_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIngresar.BackColor = Color.FromArgb(245, 158, 11);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 119, 6);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(3, 192);
            btnIngresar.Margin = new Padding(3, 12, 3, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(363, 36);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCrearCuenta.BackColor = Color.FromArgb(229, 231, 235);
            btnCrearCuenta.Cursor = Cursors.Hand;
            btnCrearCuenta.FlatAppearance.BorderSize = 0;
            btnCrearCuenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 213, 219);
            btnCrearCuenta.FlatStyle = FlatStyle.Flat;
            btnCrearCuenta.Font = new Font("Segoe UI", 10F);
            btnCrearCuenta.ForeColor = Color.FromArgb(17, 24, 39);
            btnCrearCuenta.Location = new Point(3, 248);
            btnCrearCuenta.Margin = new Padding(3, 8, 3, 2);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(363, 34);
            btnCrearCuenta.TabIndex = 6;
            btnCrearCuenta.Text = "Crear cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(805, 420);
            Controls.Add(tableLayoutMain);
            FormBorderStyle = FormBorderStyle.Sizable;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = true;
            MinimumSize = new Size(720, 420);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Text = "Iniciar sesión";
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
        private Label lblTitulo;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private TableLayoutPanel tableLayoutContraseña;
        private TextBox txtContraseña;
        private TableLayoutPanel tableLayoutOjo;
        private PictureBox picOjo;
        private Button btnIngresar;
        private Button btnCrearCuenta;
    }
}
