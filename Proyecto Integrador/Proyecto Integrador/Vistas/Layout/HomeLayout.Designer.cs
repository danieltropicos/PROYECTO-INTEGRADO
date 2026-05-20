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
            lblTituloApp = new Label();
            panelSidebar = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            tableLayoutPanel1.SuspendLayout();
            panelNavbar.SuspendLayout();
            tableLayoutNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoNavbar).BeginInit();
            panelSidebar.SuspendLayout();
            panelCerrarSesion.SuspendLayout();
            tableLayoutCerrarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconoCerrarSesion).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panelContenido.SuspendLayout();
            panelBienvenida.SuspendLayout();
            tableLayoutCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoCentro).BeginInit();
            SuspendLayout();
            //
            // tableLayoutPanel1
            //
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 251F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelNavbar, 0, 0);
            tableLayoutPanel1.Controls.Add(panelSidebar, 0, 1);
            tableLayoutPanel1.Controls.Add(panelContenido, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.BackColor = Color.FromArgb(243, 244, 246);
            tableLayoutPanel1.Size = new Size(1224, 680);
            tableLayoutPanel1.TabIndex = 0;
            //
            // panelNavbar
            //
            tableLayoutPanel1.SetColumnSpan(panelNavbar, 2);
            panelNavbar.BackColor = Color.FromArgb(30, 58, 95);
            panelNavbar.Controls.Add(tableLayoutNavbar);
            panelNavbar.Dock = DockStyle.Fill;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Margin = new Padding(0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Padding = new Padding(12, 8, 16, 8);
            panelNavbar.Size = new Size(1224, 72);
            panelNavbar.TabIndex = 0;
            //
            // tableLayoutNavbar
            //
            tableLayoutNavbar.ColumnCount = 2;
            tableLayoutNavbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutNavbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutNavbar.Controls.Add(picLogoNavbar, 0, 0);
            tableLayoutNavbar.Controls.Add(lblTituloApp, 1, 0);
            tableLayoutNavbar.Dock = DockStyle.Fill;
            tableLayoutNavbar.Location = new Point(12, 8);
            tableLayoutNavbar.Name = "tableLayoutNavbar";
            tableLayoutNavbar.RowCount = 1;
            tableLayoutNavbar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutNavbar.Size = new Size(1196, 56);
            tableLayoutNavbar.TabIndex = 0;
            //
            // picLogoNavbar
            //
            picLogoNavbar.BackColor = Color.Transparent;
            picLogoNavbar.Dock = DockStyle.Fill;
            picLogoNavbar.Location = new Point(3, 3);
            picLogoNavbar.Margin = new Padding(0, 0, 8, 0);
            picLogoNavbar.Name = "picLogoNavbar";
            picLogoNavbar.Size = new Size(132, 50);
            picLogoNavbar.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoNavbar.TabIndex = 0;
            picLogoNavbar.TabStop = false;
            //
            // lblTituloApp
            //
            lblTituloApp.BackColor = Color.Transparent;
            lblTituloApp.Dock = DockStyle.Fill;
            lblTituloApp.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloApp.ForeColor = Color.White;
            lblTituloApp.Location = new Point(143, 0);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(1053, 56);
            lblTituloApp.TabIndex = 1;
            lblTituloApp.Text = "GeoTerra";
            lblTituloApp.TextAlign = ContentAlignment.MiddleRight;
            //
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 58, 95);
            panelSidebar.Controls.Add(flowLayoutPanel1);
            panelSidebar.Controls.Add(panelCerrarSesion);
            panelSidebar.Dock = DockStyle.Fill;
            panelSidebar.Location = new Point(0, 72);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(9, 16, 9, 16);
            panelSidebar.Size = new Size(251, 608);
            panelSidebar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(9, 16);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0);
            flowLayoutPanel1.BackColor = Color.FromArgb(30, 58, 95);
            flowLayoutPanel1.Size = new Size(233, 488);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            //
            // button1
            //
            button1.Location = new Point(12, 20);
            button1.Margin = new Padding(3, 4, 3, 8);
            button1.Name = "button1";
            button1.Size = new Size(226, 64);
            button1.TabIndex = 0;
            button1.BackColor = Color.FromArgb(30, 58, 95);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 93, 122);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.White;
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Text = "  Usuarios";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            //
            // button2
            //
            button2.Location = new Point(12, 96);
            button2.Margin = new Padding(3, 4, 3, 8);
            button2.Name = "button2";
            button2.Size = new Size(226, 64);
            button2.TabIndex = 1;
            button2.BackColor = Color.FromArgb(30, 58, 95);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 93, 122);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.White;
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Text = "  Clientes";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            //
            // button3
            //
            button3.Location = new Point(12, 172);
            button3.Margin = new Padding(3, 4, 3, 8);
            button3.Name = "button3";
            button3.Size = new Size(226, 64);
            button3.TabIndex = 2;
            button3.BackColor = Color.FromArgb(30, 58, 95);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 93, 122);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = Color.White;
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Text = "  Cotización";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            //
            // button4
            //
            button4.Location = new Point(12, 248);
            button4.Margin = new Padding(3, 4, 3, 8);
            button4.Name = "button4";
            button4.Size = new Size(226, 64);
            button4.TabIndex = 3;
            button4.BackColor = Color.FromArgb(30, 58, 95);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 93, 122);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F);
            button4.ForeColor = Color.White;
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Text = "  Facturas";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panelCerrarSesion
            // 
            panelCerrarSesion.BackColor = Color.FromArgb(30, 58, 95);
            panelCerrarSesion.Controls.Add(tableLayoutCerrarSesion);
            panelCerrarSesion.Dock = DockStyle.Bottom;
            panelCerrarSesion.Location = new Point(9, 516);
            panelCerrarSesion.Margin = new Padding(3, 8, 3, 0);
            panelCerrarSesion.Name = "panelCerrarSesion";
            panelCerrarSesion.Size = new Size(233, 52);
            panelCerrarSesion.TabIndex = 4;
            // 
            // tableLayoutCerrarSesion
            // 
            tableLayoutCerrarSesion.ColumnCount = 2;
            tableLayoutCerrarSesion.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutCerrarSesion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutCerrarSesion.Controls.Add(picIconoCerrarSesion, 0, 0);
            tableLayoutCerrarSesion.Controls.Add(btnCerrarSesion, 1, 0);
            tableLayoutCerrarSesion.Dock = DockStyle.Fill;
            tableLayoutCerrarSesion.Location = new Point(0, 0);
            tableLayoutCerrarSesion.Name = "tableLayoutCerrarSesion";
            tableLayoutCerrarSesion.RowCount = 1;
            tableLayoutCerrarSesion.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutCerrarSesion.Size = new Size(233, 52);
            tableLayoutCerrarSesion.TabIndex = 0;
            // 
            // picIconoCerrarSesion
            // 
            picIconoCerrarSesion.BackColor = Color.Transparent;
            picIconoCerrarSesion.Cursor = Cursors.Hand;
            picIconoCerrarSesion.Dock = DockStyle.Fill;
            picIconoCerrarSesion.ImageLocation = "Recursos\\Imagenes\\icono-cerrar-sesion.png";
            picIconoCerrarSesion.Location = new Point(4, 14);
            picIconoCerrarSesion.Margin = new Padding(4, 0, 0, 0);
            picIconoCerrarSesion.Name = "picIconoCerrarSesion";
            picIconoCerrarSesion.Padding = new Padding(2);
            picIconoCerrarSesion.Size = new Size(28, 24);
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
            btnCerrarSesion.Location = new Point(35, 0);
            btnCerrarSesion.Margin = new Padding(0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(4, 0, 0, 0);
            btnCerrarSesion.Size = new Size(198, 52);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelContenido
            //
            panelContenido.Controls.Add(panelBienvenida);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(251, 72);
            panelContenido.Margin = new Padding(0);
            panelContenido.Name = "panelContenido";
            panelContenido.Padding = new Padding(18, 21, 18, 21);
            panelContenido.BackColor = Color.FromArgb(243, 244, 246);
            panelContenido.Size = new Size(973, 608);
            panelContenido.TabIndex = 2;
            //
            // panelBienvenida
            //
            panelBienvenida.BackColor = Color.FromArgb(243, 244, 246);
            panelBienvenida.Controls.Add(tableLayoutCentro);
            panelBienvenida.Dock = DockStyle.Fill;
            panelBienvenida.Location = new Point(18, 21);
            panelBienvenida.Margin = new Padding(3, 4, 3, 4);
            panelBienvenida.Name = "panelBienvenida";
            panelBienvenida.Padding = new Padding(0);
            panelBienvenida.Size = new Size(937, 566);
            panelBienvenida.TabIndex = 0;
            //
            // tableLayoutCentro
            //
            tableLayoutCentro.ColumnCount = 3;
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Controls.Add(picLogoCentro, 1, 1);
            tableLayoutCentro.Dock = DockStyle.Fill;
            tableLayoutCentro.Location = new Point(0, 0);
            tableLayoutCentro.Name = "tableLayoutCentro";
            tableLayoutCentro.RowCount = 3;
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Size = new Size(937, 566);
            tableLayoutCentro.TabIndex = 0;
            //
            // picLogoCentro
            //
            picLogoCentro.BackColor = Color.Transparent;
            picLogoCentro.Dock = DockStyle.Fill;
            picLogoCentro.Location = new Point(291, 183);
            picLogoCentro.Margin = new Padding(0);
            picLogoCentro.Name = "picLogoCentro";
            picLogoCentro.Size = new Size(360, 200);
            picLogoCentro.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoCentro.TabIndex = 0;
            picLogoCentro.TabStop = false;
            //
            // HomeLayout
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1224, 680);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1026, 651);
            Name = "HomeLayout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto Integrador";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panelNavbar.ResumeLayout(false);
            tableLayoutNavbar.ResumeLayout(false);
            tableLayoutNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoNavbar).EndInit();
            panelSidebar.ResumeLayout(false);
            panelCerrarSesion.ResumeLayout(false);
            tableLayoutCerrarSesion.ResumeLayout(false);
            tableLayoutCerrarSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconoCerrarSesion).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelBienvenida.ResumeLayout(false);
            tableLayoutCentro.ResumeLayout(false);
            tableLayoutCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoCentro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelNavbar;
        private TableLayoutPanel tableLayoutNavbar;
        private PictureBox picLogoNavbar;
        private Label lblTituloApp;
        private Panel panelSidebar;
        private FlowLayoutPanel flowLayoutPanel1;
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
    }
}
