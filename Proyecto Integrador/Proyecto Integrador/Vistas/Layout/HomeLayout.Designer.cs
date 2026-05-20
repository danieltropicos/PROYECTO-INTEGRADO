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
            lblTituloApp = new Label();
            picLogoNavbar = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelContenido = new Panel();
            panelBienvenida = new Panel();
            picLogoCentro = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoNavbar).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panelContenido.SuspendLayout();
            panelBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoCentro).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 251F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelNavbar, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panelContenido, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1224, 680);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelNavbar
            // 
            tableLayoutPanel1.SetColumnSpan(panelNavbar, 2);
            panelNavbar.Controls.Add(lblTituloApp);
            panelNavbar.Controls.Add(picLogoNavbar);
            panelNavbar.Dock = DockStyle.Fill;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Margin = new Padding(0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Padding = new Padding(14, 11, 18, 11);
            panelNavbar.Size = new Size(1224, 96);
            panelNavbar.TabIndex = 0;
            panelNavbar.Paint += panelNavbar_Paint;
            // 
            // lblTituloApp
            // 
            lblTituloApp.Dock = DockStyle.Fill;
            lblTituloApp.Location = new Point(243, 11);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(963, 74);
            lblTituloApp.TabIndex = 1;
            lblTituloApp.Text = "GeoTerra";
            lblTituloApp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picLogoNavbar
            // 
            picLogoNavbar.Dock = DockStyle.Left;
            picLogoNavbar.Location = new Point(14, 11);
            picLogoNavbar.Margin = new Padding(3, 4, 3, 4);
            picLogoNavbar.Name = "picLogoNavbar";
            picLogoNavbar.Size = new Size(229, 74);
            picLogoNavbar.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoNavbar.TabIndex = 0;
            picLogoNavbar.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 96);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(9, 16, 9, 16);
            flowLayoutPanel1.Size = new Size(251, 584);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 20);
            button1.Margin = new Padding(3, 4, 3, 8);
            button1.Name = "button1";
            button1.Size = new Size(226, 64);
            button1.TabIndex = 0;
            button1.Text = "  Usuarios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 96);
            button2.Margin = new Padding(3, 4, 3, 8);
            button2.Name = "button2";
            button2.Size = new Size(226, 64);
            button2.TabIndex = 1;
            button2.Text = "  Clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 172);
            button3.Margin = new Padding(3, 4, 3, 8);
            button3.Name = "button3";
            button3.Size = new Size(226, 64);
            button3.TabIndex = 2;
            button3.Text = "  Cotización";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 248);
            button4.Margin = new Padding(3, 4, 3, 8);
            button4.Name = "button4";
            button4.Size = new Size(226, 64);
            button4.TabIndex = 3;
            button4.Text = "  Facturas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panelContenido
            // 
            panelContenido.Controls.Add(panelBienvenida);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(251, 96);
            panelContenido.Margin = new Padding(0);
            panelContenido.Name = "panelContenido";
            panelContenido.Padding = new Padding(18, 21, 18, 21);
            panelContenido.Size = new Size(973, 584);
            panelContenido.TabIndex = 2;
            // 
            // panelBienvenida
            // 
            panelBienvenida.Controls.Add(picLogoCentro);
            panelBienvenida.Dock = DockStyle.Fill;
            panelBienvenida.Location = new Point(18, 21);
            panelBienvenida.Margin = new Padding(3, 4, 3, 4);
            panelBienvenida.Name = "panelBienvenida";
            panelBienvenida.Padding = new Padding(606, 179, 606, 179);
            panelBienvenida.Size = new Size(937, 542);
            panelBienvenida.TabIndex = 0;
            // 
            // picLogoCentro
            // 
            picLogoCentro.Dock = DockStyle.Fill;
            picLogoCentro.Location = new Point(606, 179);
            picLogoCentro.Margin = new Padding(3, 4, 3, 4);
            picLogoCentro.Name = "picLogoCentro";
            picLogoCentro.Size = new Size(0, 184);
            picLogoCentro.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoCentro.TabIndex = 0;
            picLogoCentro.TabStop = false;
            // 
            // HomeLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 680);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1026, 651);
            Name = "HomeLayout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto Integrador";
            WindowState = FormWindowState.Maximized;
            Load += HomeLayout_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panelNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogoNavbar).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelBienvenida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogoCentro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelNavbar;
        private PictureBox picLogoNavbar;
        private Label lblTituloApp;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelContenido;
        private Panel panelBienvenida;
        private PictureBox picLogoCentro;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
