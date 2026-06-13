namespace Proyecto_Integrador.Vistas.Usuarios
{
    partial class UsuarioForm
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
            panelContenedor = new Panel();
            groupBoxDatos = new GroupBox();
            tableLayoutDatos = new TableLayoutPanel();
            labelNombre = new Label();
            txtNombre = new TextBox();
            labelApellido = new Label();
            txtApellido = new TextBox();
            labelCorreo = new Label();
            txtCorreo = new TextBox();
            labelTelefono = new Label();
            txtTelefono = new TextBox();
            labelDireccion = new Label();
            txtDireccion = new TextBox();
            labelUsuario = new Label();
            txtUsuario = new TextBox();
            labelContrasena = new Label();
            tableLayoutContrasena = new TableLayoutPanel();
            txtContrasena = new TextBox();
            picOjo = new PictureBox();
            flowLayoutPanelBotones = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panelContenedor.SuspendLayout();
            groupBoxDatos.SuspendLayout();
            tableLayoutDatos.SuspendLayout();
            tableLayoutContrasena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOjo).BeginInit();
            flowLayoutPanelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(243, 244, 246);
            panelContenedor.Controls.Add(groupBoxDatos);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Margin = new Padding(3, 4, 3, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Padding = new Padding(18, 21, 18, 21);
            panelContenedor.Size = new Size(553, 693);
            panelContenedor.TabIndex = 0;
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.BackColor = Color.White;
            groupBoxDatos.Controls.Add(tableLayoutDatos);
            groupBoxDatos.Controls.Add(flowLayoutPanelBotones);
            groupBoxDatos.Dock = DockStyle.Fill;
            groupBoxDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxDatos.ForeColor = Color.FromArgb(30, 58, 95);
            groupBoxDatos.Location = new Point(18, 21);
            groupBoxDatos.Margin = new Padding(3, 4, 3, 4);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Padding = new Padding(14, 11, 14, 16);
            groupBoxDatos.Size = new Size(517, 651);
            groupBoxDatos.TabIndex = 0;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "Nuevo usuario";
            // 
            // tableLayoutDatos
            // 
            tableLayoutDatos.ColumnCount = 2;
            tableLayoutDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDatos.Controls.Add(labelNombre, 0, 0);
            tableLayoutDatos.Controls.Add(txtNombre, 1, 0);
            tableLayoutDatos.Controls.Add(labelApellido, 0, 1);
            tableLayoutDatos.Controls.Add(txtApellido, 1, 1);
            tableLayoutDatos.Controls.Add(labelCorreo, 0, 2);
            tableLayoutDatos.Controls.Add(txtCorreo, 1, 2);
            tableLayoutDatos.Controls.Add(labelTelefono, 0, 3);
            tableLayoutDatos.Controls.Add(txtTelefono, 1, 3);
            tableLayoutDatos.Controls.Add(labelDireccion, 0, 4);
            tableLayoutDatos.Controls.Add(txtDireccion, 1, 4);
            tableLayoutDatos.Controls.Add(labelUsuario, 0, 5);
            tableLayoutDatos.Controls.Add(txtUsuario, 1, 5);
            tableLayoutDatos.Controls.Add(labelContrasena, 0, 6);
            tableLayoutDatos.Controls.Add(tableLayoutContrasena, 1, 6);
            tableLayoutDatos.Dock = DockStyle.Fill;
            tableLayoutDatos.Location = new Point(14, 31);
            tableLayoutDatos.Margin = new Padding(3, 4, 3, 4);
            tableLayoutDatos.Name = "tableLayoutDatos";
            tableLayoutDatos.Padding = new Padding(5);
            tableLayoutDatos.RowCount = 7;
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutDatos.Size = new Size(489, 396);
            tableLayoutDatos.TabIndex = 0;
            // 
            // labelNombre
            // 
            labelNombre.Dock = DockStyle.Fill;
            labelNombre.Font = new Font("Segoe UI", 9F);
            labelNombre.ForeColor = Color.FromArgb(75, 85, 99);
            labelNombre.Location = new Point(8, 5);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(120, 48);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre";
            labelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Dock = DockStyle.Fill;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(134, 9);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(347, 30);
            txtNombre.TabIndex = 1;
            // 
            // labelApellido
            // 
            labelApellido.Dock = DockStyle.Fill;
            labelApellido.Font = new Font("Segoe UI", 9F);
            labelApellido.ForeColor = Color.FromArgb(75, 85, 99);
            labelApellido.Location = new Point(8, 53);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(120, 48);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Apellido";
            labelApellido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Dock = DockStyle.Fill;
            txtApellido.Font = new Font("Segoe UI", 10F);
            txtApellido.Location = new Point(134, 57);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(347, 30);
            txtApellido.TabIndex = 3;
            // 
            // labelCorreo
            // 
            labelCorreo.Dock = DockStyle.Fill;
            labelCorreo.Font = new Font("Segoe UI", 9F);
            labelCorreo.ForeColor = Color.FromArgb(75, 85, 99);
            labelCorreo.Location = new Point(8, 101);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(120, 48);
            labelCorreo.TabIndex = 4;
            labelCorreo.Text = "Correo";
            labelCorreo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Dock = DockStyle.Fill;
            txtCorreo.Font = new Font("Segoe UI", 10F);
            txtCorreo.Location = new Point(134, 105);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(347, 30);
            txtCorreo.TabIndex = 5;
            // 
            // labelTelefono
            // 
            labelTelefono.Dock = DockStyle.Fill;
            labelTelefono.Font = new Font("Segoe UI", 9F);
            labelTelefono.ForeColor = Color.FromArgb(75, 85, 99);
            labelTelefono.Location = new Point(8, 149);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(120, 48);
            labelTelefono.TabIndex = 6;
            labelTelefono.Text = "Teléfono";
            labelTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Dock = DockStyle.Fill;
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.Location = new Point(134, 153);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(347, 30);
            txtTelefono.TabIndex = 7;
            // 
            // labelDireccion
            // 
            labelDireccion.Dock = DockStyle.Fill;
            labelDireccion.Font = new Font("Segoe UI", 9F);
            labelDireccion.ForeColor = Color.FromArgb(75, 85, 99);
            labelDireccion.Location = new Point(8, 197);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(120, 48);
            labelDireccion.TabIndex = 8;
            labelDireccion.Text = "Dirección";
            labelDireccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Dock = DockStyle.Fill;
            txtDireccion.Font = new Font("Segoe UI", 10F);
            txtDireccion.Location = new Point(134, 201);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(347, 30);
            txtDireccion.TabIndex = 9;
            // 
            // labelUsuario
            // 
            labelUsuario.Dock = DockStyle.Fill;
            labelUsuario.Font = new Font("Segoe UI", 9F);
            labelUsuario.ForeColor = Color.FromArgb(75, 85, 99);
            labelUsuario.Location = new Point(8, 245);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(120, 48);
            labelUsuario.TabIndex = 10;
            labelUsuario.Text = "Usuario";
            labelUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Dock = DockStyle.Fill;
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.Location = new Point(134, 249);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(347, 30);
            txtUsuario.TabIndex = 11;
            // 
            // labelContrasena
            // 
            labelContrasena.Dock = DockStyle.Fill;
            labelContrasena.Font = new Font("Segoe UI", 9F);
            labelContrasena.ForeColor = Color.FromArgb(75, 85, 99);
            labelContrasena.Location = new Point(8, 293);
            labelContrasena.Name = "labelContrasena";
            labelContrasena.Size = new Size(120, 48);
            labelContrasena.TabIndex = 12;
            labelContrasena.Text = "Contraseña";
            labelContrasena.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutContrasena
            // 
            tableLayoutContrasena.ColumnCount = 2;
            tableLayoutContrasena.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutContrasena.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutContrasena.Controls.Add(txtContrasena, 0, 0);
            tableLayoutContrasena.Controls.Add(picOjo, 1, 0);
            tableLayoutContrasena.Dock = DockStyle.Fill;
            tableLayoutContrasena.Location = new Point(134, 297);
            tableLayoutContrasena.Margin = new Padding(3, 4, 3, 4);
            tableLayoutContrasena.Name = "tableLayoutContrasena";
            tableLayoutContrasena.RowCount = 1;
            tableLayoutContrasena.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutContrasena.Size = new Size(347, 40);
            tableLayoutContrasena.TabIndex = 13;
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.Dock = DockStyle.Fill;
            txtContrasena.Font = new Font("Segoe UI", 10F);
            txtContrasena.Location = new Point(0, 5);
            txtContrasena.Margin = new Padding(0, 5, 5, 5);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(305, 30);
            txtContrasena.TabIndex = 0;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // picOjo
            // 
            picOjo.Cursor = Cursors.Hand;
            picOjo.Dock = DockStyle.Fill;
            picOjo.ImageLocation = "Recursos\\Imagenes\\ojoCerrado.jpg";
            picOjo.Location = new Point(310, 8);
            picOjo.Margin = new Padding(0, 8, 0, 8);
            picOjo.Name = "picOjo";
            picOjo.Size = new Size(37, 24);
            picOjo.SizeMode = PictureBoxSizeMode.Zoom;
            picOjo.TabIndex = 1;
            picOjo.TabStop = false;
            picOjo.Click += picOjo_Click;
            // 
            // flowLayoutPanelBotones
            // 
            flowLayoutPanelBotones.Controls.Add(btnCancelar);
            flowLayoutPanelBotones.Controls.Add(btnGuardar);
            flowLayoutPanelBotones.Dock = DockStyle.Bottom;
            flowLayoutPanelBotones.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBotones.Location = new Point(14, 427);
            flowLayoutPanelBotones.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelBotones.Name = "flowLayoutPanelBotones";
            flowLayoutPanelBotones.Padding = new Padding(0, 11, 0, 0);
            flowLayoutPanelBotones.Size = new Size(489, 208);
            flowLayoutPanelBotones.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(229, 231, 235);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.FromArgb(17, 24, 39);
            btnCancelar.Location = new Point(349, 15);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 53);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(245, 158, 11);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(200, 11);
            btnGuardar.Margin = new Padding(0, 0, 9, 0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 53);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // UsuarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 693);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsuarioForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo usuario";
            panelContenedor.ResumeLayout(false);
            groupBoxDatos.ResumeLayout(false);
            tableLayoutDatos.ResumeLayout(false);
            tableLayoutDatos.PerformLayout();
            tableLayoutContrasena.ResumeLayout(false);
            tableLayoutContrasena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOjo).EndInit();
            flowLayoutPanelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private GroupBox groupBoxDatos;
        private TableLayoutPanel tableLayoutDatos;
        private Label labelNombre;
        private TextBox txtNombre;
        private Label labelApellido;
        private TextBox txtApellido;
        private Label labelCorreo;
        private TextBox txtCorreo;
        private Label labelTelefono;
        private TextBox txtTelefono;
        private Label labelDireccion;
        private TextBox txtDireccion;
        private Label labelUsuario;
        private TextBox txtUsuario;
        private Label labelContrasena;
        private TableLayoutPanel tableLayoutContrasena;
        private TextBox txtContrasena;
        private PictureBox picOjo;
        private FlowLayoutPanel flowLayoutPanelBotones;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}
