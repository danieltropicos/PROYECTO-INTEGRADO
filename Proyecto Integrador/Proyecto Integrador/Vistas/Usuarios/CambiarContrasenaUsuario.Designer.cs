namespace Proyecto_Integrador.Vistas.Usuarios
{
    partial class CambiarContrasenaUsuario
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
            labelActual = new Label();
            txtContrasenaActual = new TextBox();
            labelNueva = new Label();
            txtContrasenaNueva = new TextBox();
            labelConfirmar = new Label();
            txtConfirmarContrasena = new TextBox();
            tableLayoutBotones = new TableLayoutPanel();
            btnGuardar = new Button();
            btnCancelar = new Button();
            panelContenedor.SuspendLayout();
            groupBoxDatos.SuspendLayout();
            tableLayoutDatos.SuspendLayout();
            tableLayoutBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(243, 244, 246);
            panelContenedor.Controls.Add(groupBoxDatos);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Padding = new Padding(16);
            panelContenedor.Size = new Size(424, 282);
            panelContenedor.TabIndex = 0;
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.BackColor = Color.White;
            groupBoxDatos.Controls.Add(tableLayoutDatos);
            groupBoxDatos.Controls.Add(tableLayoutBotones);
            groupBoxDatos.Dock = DockStyle.Fill;
            groupBoxDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxDatos.ForeColor = Color.FromArgb(30, 58, 95);
            groupBoxDatos.Location = new Point(16, 16);
            groupBoxDatos.Margin = new Padding(3, 2, 3, 2);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Padding = new Padding(12, 8, 12, 12);
            groupBoxDatos.Size = new Size(392, 250);
            groupBoxDatos.TabIndex = 0;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "Cambiar contraseña";
            // 
            // tableLayoutDatos
            // 
            tableLayoutDatos.ColumnCount = 2;
            tableLayoutDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDatos.Controls.Add(labelActual, 0, 0);
            tableLayoutDatos.Controls.Add(txtContrasenaActual, 1, 0);
            tableLayoutDatos.Controls.Add(labelNueva, 0, 1);
            tableLayoutDatos.Controls.Add(txtContrasenaNueva, 1, 1);
            tableLayoutDatos.Controls.Add(labelConfirmar, 0, 2);
            tableLayoutDatos.Controls.Add(txtConfirmarContrasena, 1, 2);
            tableLayoutDatos.Dock = DockStyle.Fill;
            tableLayoutDatos.Location = new Point(12, 24);
            tableLayoutDatos.Margin = new Padding(3, 2, 3, 2);
            tableLayoutDatos.Name = "tableLayoutDatos";
            tableLayoutDatos.Padding = new Padding(4);
            tableLayoutDatos.RowCount = 3;
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutDatos.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutDatos.Size = new Size(368, 166);
            tableLayoutDatos.TabIndex = 0;
            // 
            // labelActual
            // 
            labelActual.Dock = DockStyle.Top;
            labelActual.Font = new Font("Segoe UI", 9F);
            labelActual.ForeColor = Color.FromArgb(75, 85, 99);
            labelActual.Location = new Point(7, 4);
            labelActual.Name = "labelActual";
            labelActual.Size = new Size(134, 28);
            labelActual.TabIndex = 0;
            labelActual.Text = "Contraseña actual";
            labelActual.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtContrasenaActual
            // 
            txtContrasenaActual.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenaActual.Dock = DockStyle.Fill;
            txtContrasenaActual.Font = new Font("Segoe UI", 10F);
            txtContrasenaActual.Location = new Point(147, 7);
            txtContrasenaActual.Name = "txtContrasenaActual";
            txtContrasenaActual.Size = new Size(214, 25);
            txtContrasenaActual.TabIndex = 1;
            txtContrasenaActual.UseSystemPasswordChar = true;
            // 
            // labelNueva
            // 
            labelNueva.Dock = DockStyle.Top;
            labelNueva.Font = new Font("Segoe UI", 9F);
            labelNueva.ForeColor = Color.FromArgb(75, 85, 99);
            labelNueva.Location = new Point(7, 56);
            labelNueva.Name = "labelNueva";
            labelNueva.Size = new Size(134, 28);
            labelNueva.TabIndex = 2;
            labelNueva.Text = "Nueva contraseña";
            labelNueva.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtContrasenaNueva
            // 
            txtContrasenaNueva.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenaNueva.Dock = DockStyle.Fill;
            txtContrasenaNueva.Font = new Font("Segoe UI", 10F);
            txtContrasenaNueva.Location = new Point(147, 59);
            txtContrasenaNueva.Name = "txtContrasenaNueva";
            txtContrasenaNueva.Size = new Size(214, 25);
            txtContrasenaNueva.TabIndex = 2;
            txtContrasenaNueva.UseSystemPasswordChar = true;
            // 
            // labelConfirmar
            // 
            labelConfirmar.Dock = DockStyle.Top;
            labelConfirmar.Font = new Font("Segoe UI", 9F);
            labelConfirmar.ForeColor = Color.FromArgb(75, 85, 99);
            labelConfirmar.Location = new Point(7, 108);
            labelConfirmar.Name = "labelConfirmar";
            labelConfirmar.Size = new Size(134, 28);
            labelConfirmar.TabIndex = 4;
            labelConfirmar.Text = "Confirmar contraseña";
            labelConfirmar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarContrasena.Dock = DockStyle.Fill;
            txtConfirmarContrasena.Font = new Font("Segoe UI", 10F);
            txtConfirmarContrasena.Location = new Point(147, 111);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(214, 25);
            txtConfirmarContrasena.TabIndex = 3;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // tableLayoutBotones
            // 
            tableLayoutBotones.ColumnCount = 2;
            tableLayoutBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutBotones.Controls.Add(btnGuardar, 0, 0);
            tableLayoutBotones.Controls.Add(btnCancelar, 1, 0);
            tableLayoutBotones.Dock = DockStyle.Bottom;
            tableLayoutBotones.Location = new Point(12, 190);
            tableLayoutBotones.Margin = new Padding(3, 2, 3, 2);
            tableLayoutBotones.Name = "tableLayoutBotones";
            tableLayoutBotones.Padding = new Padding(0, 8, 0, 0);
            tableLayoutBotones.RowCount = 1;
            tableLayoutBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutBotones.Size = new Size(368, 48);
            tableLayoutBotones.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(30, 58, 95);
            btnGuardar.Dock = DockStyle.Fill;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(0, 8);
            btnGuardar.Margin = new Padding(0, 0, 4, 0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 40);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(229, 231, 235);
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.FromArgb(17, 24, 39);
            btnCancelar.Location = new Point(188, 8);
            btnCancelar.Margin = new Padding(4, 0, 0, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 40);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CambiarContrasenaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 282);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CambiarContrasenaUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cambiar contraseña";
            panelContenedor.ResumeLayout(false);
            groupBoxDatos.ResumeLayout(false);
            tableLayoutDatos.ResumeLayout(false);
            tableLayoutDatos.PerformLayout();
            tableLayoutBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private GroupBox groupBoxDatos;
        private TableLayoutPanel tableLayoutDatos;
        private Label labelActual;
        private TextBox txtContrasenaActual;
        private Label labelNueva;
        private TextBox txtContrasenaNueva;
        private Label labelConfirmar;
        private TextBox txtConfirmarContrasena;
        private TableLayoutPanel tableLayoutBotones;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}
