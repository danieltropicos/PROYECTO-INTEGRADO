namespace Proyecto_Integrador.Vistas.Login
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnIngresar = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            labelContraseña = new Label();
            labelUsuario = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(labelContraseña);
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 603);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(459, 245);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Location = new Point(248, 310);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(123, 36);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(229, 241);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(253, 27);
            txtContraseña.TabIndex = 4;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(229, 200);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(253, 27);
            txtUsuario.TabIndex = 3;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(137, 244);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(86, 20);
            labelContraseña.TabIndex = 2;
            labelContraseña.Text = "Contraseña:";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(138, 203);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(62, 20);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(211, 88);
            label1.Name = "label1";
            label1.Size = new Size(189, 35);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesion";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(626, 627);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnIngresar;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label labelContraseña;
        private Label labelUsuario;
        private PictureBox pictureBox1;
    }
}