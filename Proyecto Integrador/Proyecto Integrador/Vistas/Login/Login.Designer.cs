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
            tableLayoutMain.Size = new Size(920, 560);
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
            panelBrand.Size = new Size(276, 560);
            panelBrand.TabIndex = 0;
            // 
            // tableLayoutLogo
            // 
            tableLayoutLogo.ColumnCount = 3;
            tableLayoutLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 457F));
            tableLayoutLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutLogo.Controls.Add(picLogo, 1, 1);
            tableLayoutLogo.Dock = DockStyle.Fill;
            tableLayoutLogo.Location = new Point(0, 0);
            tableLayoutLogo.Margin = new Padding(3, 4, 3, 4);
            tableLayoutLogo.Name = "tableLayoutLogo";
            tableLayoutLogo.RowCount = 3;
            tableLayoutLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutLogo.RowStyles.Add(new RowStyle(SizeType.Absolute, 347F));
            tableLayoutLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutLogo.Size = new Size(276, 560);
            tableLayoutLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Dock = DockStyle.Fill;
            picLogo.ImageLocation = "Recursos\\Imagenes\\logo-center.png";
            picLogo.Location = new Point(-90, 106);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(457, 347);
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
            panelForm.Padding = new Padding(27, 32, 27, 32);
            panelForm.Size = new Size(644, 560);
            panelForm.TabIndex = 1;
            // 
            // tableLayoutCentro
            // 
            tableLayoutCentro.ColumnCount = 3;
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 503F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Controls.Add(tableLayoutForm, 1, 1);
            tableLayoutCentro.Dock = DockStyle.Fill;
            tableLayoutCentro.Location = new Point(27, 32);
            tableLayoutCentro.Margin = new Padding(3, 4, 3, 4);
            tableLayoutCentro.Name = "tableLayoutCentro";
            tableLayoutCentro.RowCount = 3;
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.RowStyles.Add(new RowStyle());
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Size = new Size(590, 496);
            tableLayoutCentro.TabIndex = 0;
            // 
            // tableLayoutForm
            // 
            tableLayoutForm.AutoSize = true;
            tableLayoutForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutForm.ColumnCount = 1;
            tableLayoutForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutForm.Controls.Add(lblTitulo, 0, 0);
            tableLayoutForm.Controls.Add(lblUsuario, 0, 1);
            tableLayoutForm.Controls.Add(txtUsuario, 0, 2);
            tableLayoutForm.Controls.Add(lblContraseña, 0, 3);
            tableLayoutForm.Controls.Add(tableLayoutContraseña, 0, 4);
            tableLayoutForm.Controls.Add(btnIngresar, 0, 5);
            tableLayoutForm.Dock = DockStyle.Fill;
            tableLayoutForm.Location = new Point(43, 51);
            tableLayoutForm.Margin = new Padding(0);
            tableLayoutForm.Name = "tableLayoutForm";
            tableLayoutForm.RowCount = 7;
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutForm.Size = new Size(503, 393);
            tableLayoutForm.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 58, 95);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(497, 72);
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
            lblUsuario.Location = new Point(3, 72);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(497, 32);
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
            txtUsuario.Location = new Point(3, 107);
            txtUsuario.Margin = new Padding(3, 3, 3, 8);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(497, 32);
            txtUsuario.TabIndex = 2;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Dock = DockStyle.Fill;
            lblContraseña.Font = new Font("Segoe UI", 10F);
            lblContraseña.ForeColor = Color.FromArgb(75, 85, 99);
            lblContraseña.Location = new Point(3, 163);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(497, 32);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            lblContraseña.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutContraseña
            // 
            tableLayoutContraseña.ColumnCount = 2;
            tableLayoutContraseña.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutContraseña.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutContraseña.Controls.Add(txtContraseña, 0, 0);
            tableLayoutContraseña.Controls.Add(tableLayoutOjo, 1, 0);
            tableLayoutContraseña.Dock = DockStyle.Fill;
            tableLayoutContraseña.Location = new Point(3, 198);
            tableLayoutContraseña.Margin = new Padding(3, 3, 3, 8);
            tableLayoutContraseña.Name = "tableLayoutContraseña";
            tableLayoutContraseña.RowCount = 1;
            tableLayoutContraseña.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutContraseña.Size = new Size(497, 48);
            tableLayoutContraseña.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.White;
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Dock = DockStyle.Fill;
            txtContraseña.Font = new Font("Segoe UI", 11F);
            txtContraseña.Location = new Point(3, 3);
            txtContraseña.Margin = new Padding(3, 3, 7, 3);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(453, 32);
            txtContraseña.TabIndex = 0;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // tableLayoutOjo
            // 
            tableLayoutOjo.ColumnCount = 1;
            tableLayoutOjo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutOjo.Controls.Add(picOjo, 0, 1);
            tableLayoutOjo.Dock = DockStyle.Fill;
            tableLayoutOjo.Location = new Point(463, 0);
            tableLayoutOjo.Margin = new Padding(0);
            tableLayoutOjo.Name = "tableLayoutOjo";
            tableLayoutOjo.RowCount = 3;
            tableLayoutOjo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOjo.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutOjo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutOjo.Size = new Size(34, 48);
            tableLayoutOjo.TabIndex = 2;
            // 
            // picOjo
            // 
            picOjo.BackColor = Color.Transparent;
            picOjo.Cursor = Cursors.Hand;
            picOjo.Dock = DockStyle.Fill;
            picOjo.ImageLocation = "Recursos\\Imagenes\\ojoCerrado.jpg";
            picOjo.Location = new Point(2, 8);
            picOjo.Margin = new Padding(2, 3, 2, 3);
            picOjo.Name = "picOjo";
            picOjo.Size = new Size(30, 31);
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
            btnIngresar.Location = new Point(3, 270);
            btnIngresar.Margin = new Padding(3, 16, 3, 3);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(497, 48);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(920, 560);
            Controls.Add(tableLayoutMain);
            MinimumSize = new Size(820, 544);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión";
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
    }
}
