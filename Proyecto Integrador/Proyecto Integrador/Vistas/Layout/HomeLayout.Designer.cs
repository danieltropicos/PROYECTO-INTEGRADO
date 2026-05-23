namespace Proyecto_Integrador.Vistas.Layout
{
    partial class HomeLayout
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panelNavbar = new Panel();
            tableLayoutNavbar = new TableLayoutPanel();
            picLogoNavbar = new PictureBox();
            btnMiPerfilNavbar = new Button();
            panelSidebar = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnHome = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelCerrarSesion = new Panel();
            tableLayoutCerrarSesion = new TableLayoutPanel();
            picIconoCerrarSesion = new PictureBox();
            btnCerrarSesion = new Button();
            panelContenido = new Panel();
            panelBienvenida = new Panel();
            tableLayoutCentro = new TableLayoutPanel();
            picLogoCentro = new PictureBox();
            button5 = new Button();
            tableLayoutPanel1.SuspendLayout();
            panelNavbar.SuspendLayout();
            tableLayoutNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoNavbar).BeginInit();
            panelSidebar.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelCerrarSesion.SuspendLayout();
            tableLayoutCerrarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconoCerrarSesion).BeginInit();
            panelContenido.SuspendLayout();
            panelBienvenida.SuspendLayout();
            tableLayoutCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoCentro).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(243, 244, 246);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelNavbar, 0, 0);
            tableLayoutPanel1.Controls.Add(panelSidebar, 0, 1);
            tableLayoutPanel1.Controls.Add(panelContenido, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1071, 510);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.FromArgb(30, 58, 95);
            tableLayoutPanel1.SetColumnSpan(panelNavbar, 2);
            panelNavbar.Controls.Add(tableLayoutNavbar);
            panelNavbar.Dock = DockStyle.Fill;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Margin = new Padding(0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Padding = new Padding(10, 6, 14, 6);
            panelNavbar.Size = new Size(1071, 54);
            panelNavbar.TabIndex = 0;
            // 
            // tableLayoutNavbar
            // 
            tableLayoutNavbar.ColumnCount = 3;
            tableLayoutNavbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutNavbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutNavbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutNavbar.Controls.Add(picLogoNavbar, 0, 0);
            tableLayoutNavbar.Controls.Add(btnMiPerfilNavbar, 2, 0);
            tableLayoutNavbar.Dock = DockStyle.Fill;
            tableLayoutNavbar.Location = new Point(10, 6);
            tableLayoutNavbar.Margin = new Padding(3, 2, 3, 2);
            tableLayoutNavbar.Name = "tableLayoutNavbar";
            tableLayoutNavbar.RowCount = 1;
            tableLayoutNavbar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutNavbar.Size = new Size(1047, 42);
            tableLayoutNavbar.TabIndex = 0;
            // 
            // picLogoNavbar
            // 
            picLogoNavbar.BackColor = Color.Transparent;
            picLogoNavbar.Dock = DockStyle.Fill;
            picLogoNavbar.Location = new Point(0, 0);
            picLogoNavbar.Margin = new Padding(0, 0, 7, 0);
            picLogoNavbar.Name = "picLogoNavbar";
            picLogoNavbar.Size = new Size(98, 42);
            picLogoNavbar.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoNavbar.TabIndex = 0;
            picLogoNavbar.TabStop = false;
            // 
            // btnMiPerfilNavbar
            // 
            btnMiPerfilNavbar.BackColor = Color.FromArgb(59, 93, 122);
            btnMiPerfilNavbar.Cursor = Cursors.Hand;
            btnMiPerfilNavbar.Dock = DockStyle.Fill;
            btnMiPerfilNavbar.FlatAppearance.BorderSize = 0;
            btnMiPerfilNavbar.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 110, 140);
            btnMiPerfilNavbar.FlatStyle = FlatStyle.Flat;
            btnMiPerfilNavbar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMiPerfilNavbar.ForeColor = Color.White;
            btnMiPerfilNavbar.Location = new Point(932, 6);
            btnMiPerfilNavbar.Margin = new Padding(7, 6, 10, 6);
            btnMiPerfilNavbar.Name = "btnMiPerfilNavbar";
            btnMiPerfilNavbar.Size = new Size(105, 30);
            btnMiPerfilNavbar.TabIndex = 1;
            btnMiPerfilNavbar.Text = "Mi perfil";
            btnMiPerfilNavbar.UseVisualStyleBackColor = false;
            btnMiPerfilNavbar.Click += btnMiPerfilNavbar_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 58, 95);
            panelSidebar.Controls.Add(flowLayoutPanel1);
            panelSidebar.Controls.Add(panelCerrarSesion);
            panelSidebar.Dock = DockStyle.Fill;
            panelSidebar.Location = new Point(0, 54);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(8, 12, 8, 12);
            panelSidebar.Size = new Size(220, 456);
            panelSidebar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(30, 58, 95);
            flowLayoutPanel1.Controls.Add(btnHome);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(8, 12);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(204, 393);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(59, 93, 122);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 110, 140);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(3, 3);
            btnHome.Margin = new Padding(3, 3, 3, 6);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(18, 0, 0, 0);
            btnHome.Size = new Size(198, 48);
            btnHome.TabIndex = 0;
            btnHome.Text = "  Inicio";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 58, 95);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 93, 122);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 60);
            button1.Margin = new Padding(3, 3, 3, 6);
            button1.Name = "button1";
            button1.Padding = new Padding(18, 0, 0, 0);
            button1.Size = new Size(198, 48);
            button1.TabIndex = 0;
            button1.Text = "  Usuarios";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 58, 95);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 93, 122);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 117);
            button2.Margin = new Padding(3, 3, 3, 6);
            button2.Name = "button2";
            button2.Padding = new Padding(18, 0, 0, 0);
            button2.Size = new Size(198, 48);
            button2.TabIndex = 1;
            button2.Text = "  Clientes";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(30, 58, 95);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 93, 122);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 174);
            button3.Margin = new Padding(3, 3, 3, 6);
            button3.Name = "button3";
            button3.Padding = new Padding(18, 0, 0, 0);
            button3.Size = new Size(198, 48);
            button3.TabIndex = 2;
            button3.Text = "  Cotización";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(30, 58, 95);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 93, 122);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 231);
            button4.Margin = new Padding(3, 3, 3, 6);
            button4.Name = "button4";
            button4.Padding = new Padding(18, 0, 0, 0);
            button4.Size = new Size(198, 48);
            button4.TabIndex = 3;
            button4.Text = "  Materiales";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panelCerrarSesion
            // 
            panelCerrarSesion.BackColor = Color.FromArgb(30, 58, 95);
            panelCerrarSesion.Controls.Add(tableLayoutCerrarSesion);
            panelCerrarSesion.Dock = DockStyle.Bottom;
            panelCerrarSesion.Location = new Point(8, 405);
            panelCerrarSesion.Margin = new Padding(3, 6, 3, 0);
            panelCerrarSesion.Name = "panelCerrarSesion";
            panelCerrarSesion.Size = new Size(204, 39);
            panelCerrarSesion.TabIndex = 4;
            // 
            // tableLayoutCerrarSesion
            // 
            tableLayoutCerrarSesion.ColumnCount = 2;
            tableLayoutCerrarSesion.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutCerrarSesion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutCerrarSesion.Controls.Add(picIconoCerrarSesion, 0, 0);
            tableLayoutCerrarSesion.Controls.Add(btnCerrarSesion, 1, 0);
            tableLayoutCerrarSesion.Dock = DockStyle.Fill;
            tableLayoutCerrarSesion.Location = new Point(0, 0);
            tableLayoutCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            tableLayoutCerrarSesion.Name = "tableLayoutCerrarSesion";
            tableLayoutCerrarSesion.RowCount = 1;
            tableLayoutCerrarSesion.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutCerrarSesion.Size = new Size(204, 39);
            tableLayoutCerrarSesion.TabIndex = 0;
            // 
            // picIconoCerrarSesion
            // 
            picIconoCerrarSesion.BackColor = Color.Transparent;
            picIconoCerrarSesion.Cursor = Cursors.Hand;
            picIconoCerrarSesion.Dock = DockStyle.Fill;
            picIconoCerrarSesion.ImageLocation = "Recursos\\Imagenes\\icono-cerrar-sesion.png";
            picIconoCerrarSesion.Location = new Point(4, 0);
            picIconoCerrarSesion.Margin = new Padding(4, 0, 0, 0);
            picIconoCerrarSesion.Name = "picIconoCerrarSesion";
            picIconoCerrarSesion.Padding = new Padding(2);
            picIconoCerrarSesion.Size = new Size(24, 39);
            picIconoCerrarSesion.SizeMode = PictureBoxSizeMode.Zoom;
            picIconoCerrarSesion.TabIndex = 0;
            picIconoCerrarSesion.TabStop = false;
            picIconoCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(30, 58, 95);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Fill;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 93, 122);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(28, 0);
            btnCerrarSesion.Margin = new Padding(0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(4, 0, 0, 0);
            btnCerrarSesion.Size = new Size(176, 39);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(243, 244, 246);
            panelContenido.Controls.Add(panelBienvenida);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(220, 54);
            panelContenido.Margin = new Padding(0);
            panelContenido.Name = "panelContenido";
            panelContenido.Padding = new Padding(16, 16, 16, 16);
            panelContenido.Size = new Size(851, 456);
            panelContenido.TabIndex = 2;
            // 
            // panelBienvenida
            // 
            panelBienvenida.BackColor = Color.FromArgb(243, 244, 246);
            panelBienvenida.Controls.Add(tableLayoutCentro);
            panelBienvenida.Dock = DockStyle.Fill;
            panelBienvenida.Location = new Point(16, 16);
            panelBienvenida.Name = "panelBienvenida";
            panelBienvenida.Size = new Size(819, 424);
            panelBienvenida.TabIndex = 0;
            // 
            // tableLayoutCentro
            // 
            tableLayoutCentro.ColumnCount = 3;
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 630F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Controls.Add(picLogoCentro, 1, 1);
            tableLayoutCentro.Dock = DockStyle.Fill;
            tableLayoutCentro.Location = new Point(0, 0);
            tableLayoutCentro.Margin = new Padding(3, 2, 3, 2);
            tableLayoutCentro.Name = "tableLayoutCentro";
            tableLayoutCentro.RowCount = 3;
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Size = new Size(819, 424);
            tableLayoutCentro.TabIndex = 0;
            // 
            // picLogoCentro
            // 
            picLogoCentro.BackColor = Color.Transparent;
            picLogoCentro.Dock = DockStyle.Fill;
            picLogoCentro.Location = new Point(94, 62);
            picLogoCentro.Margin = new Padding(0);
            picLogoCentro.Name = "picLogoCentro";
            picLogoCentro.Size = new Size(630, 300);
            picLogoCentro.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoCentro.TabIndex = 0;
            picLogoCentro.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(30, 58, 95);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 93, 122);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(3, 288);
            button5.Margin = new Padding(3, 3, 3, 6);
            button5.Name = "button5";
            button5.Padding = new Padding(18, 0, 0, 0);
            button5.Size = new Size(198, 48);
            button5.TabIndex = 4;
            button5.Text = "  Facturas";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // HomeLayout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1071, 510);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(900, 498);
            Name = "HomeLayout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto Integrador";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panelNavbar.ResumeLayout(false);
            tableLayoutNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogoNavbar).EndInit();
            panelSidebar.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panelCerrarSesion.ResumeLayout(false);
            tableLayoutCerrarSesion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picIconoCerrarSesion).EndInit();
            panelContenido.ResumeLayout(false);
            panelBienvenida.ResumeLayout(false);
            tableLayoutCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogoCentro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelNavbar;
        private TableLayoutPanel tableLayoutNavbar;
        private PictureBox picLogoNavbar;
        private Button btnMiPerfilNavbar;
        private Panel panelSidebar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnHome;
        private Panel panelCerrarSesion;
        private TableLayoutPanel tableLayoutCerrarSesion;
        private PictureBox picIconoCerrarSesion;
        private Button btnCerrarSesion;
        private Panel panelContenido;
        private Panel panelBienvenida;
        private TableLayoutPanel tableLayoutCentro;
        private PictureBox picLogoCentro;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
