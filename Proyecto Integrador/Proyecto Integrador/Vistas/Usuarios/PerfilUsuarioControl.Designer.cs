namespace Proyecto_Integrador.Vistas.Usuarios
{
    partial class PerfilUsuarioControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            tableLayoutCentro = new TableLayoutPanel();
            panelTarjeta = new Panel();
            tableLayoutPerfil = new TableLayoutPanel();
            lblTitulo = new Label();
            flowLayoutRol = new FlowLayoutPanel();
            lblRol = new Label();
            lblNombreValor = new Label();
            lblEtiquetaUsuario = new Label();
            lblUsuarioValor = new Label();
            lblEtiquetaCorreo = new Label();
            lblCorreoValor = new Label();
            lblEtiquetaTelefono = new Label();
            lblTelefonoValor = new Label();
            lblEtiquetaDireccion = new Label();
            lblDireccionValor = new Label();
            lblEtiquetaEstado = new Label();
            lblEstadoValor = new Label();
            btnCambiarContrasena = new Button();
            panelPrincipal.SuspendLayout();
            tableLayoutCentro.SuspendLayout();
            panelTarjeta.SuspendLayout();
            tableLayoutPerfil.SuspendLayout();
            flowLayoutRol.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(243, 244, 246);
            panelPrincipal.Controls.Add(tableLayoutCentro);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(900, 650);
            panelPrincipal.TabIndex = 0;
            // 
            // tableLayoutCentro
            // 
            tableLayoutCentro.ColumnCount = 3;
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 580F));
            tableLayoutCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Controls.Add(panelTarjeta, 1, 1);
            tableLayoutCentro.Dock = DockStyle.Fill;
            tableLayoutCentro.Location = new Point(0, 0);
            tableLayoutCentro.Name = "tableLayoutCentro";
            tableLayoutCentro.RowCount = 3;
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 500F));
            tableLayoutCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutCentro.Size = new Size(900, 650);
            tableLayoutCentro.TabIndex = 0;
            // 
            // panelTarjeta
            // 
            panelTarjeta.BackColor = Color.White;
            panelTarjeta.Controls.Add(tableLayoutPerfil);
            panelTarjeta.Dock = DockStyle.Fill;
            panelTarjeta.Location = new Point(163, 75);
            panelTarjeta.Name = "panelTarjeta";
            panelTarjeta.Padding = new Padding(36, 32, 36, 36);
            panelTarjeta.Size = new Size(574, 500);
            panelTarjeta.TabIndex = 0;
            // 
            // tableLayoutPerfil
            // 
            tableLayoutPerfil.ColumnCount = 2;
            tableLayoutPerfil.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPerfil.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPerfil.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPerfil.Controls.Add(flowLayoutRol, 1, 0);
            tableLayoutPerfil.Controls.Add(lblNombreValor, 0, 1);
            tableLayoutPerfil.Controls.Add(lblEtiquetaUsuario, 0, 2);
            tableLayoutPerfil.Controls.Add(lblUsuarioValor, 1, 2);
            tableLayoutPerfil.Controls.Add(lblEtiquetaCorreo, 0, 3);
            tableLayoutPerfil.Controls.Add(lblCorreoValor, 1, 3);
            tableLayoutPerfil.Controls.Add(lblEtiquetaTelefono, 0, 4);
            tableLayoutPerfil.Controls.Add(lblTelefonoValor, 1, 4);
            tableLayoutPerfil.Controls.Add(lblEtiquetaDireccion, 0, 5);
            tableLayoutPerfil.Controls.Add(lblDireccionValor, 1, 5);
            tableLayoutPerfil.Controls.Add(lblEtiquetaEstado, 0, 6);
            tableLayoutPerfil.Controls.Add(lblEstadoValor, 1, 6);
            tableLayoutPerfil.Dock = DockStyle.Fill;
            tableLayoutPerfil.Location = new Point(36, 32);
            tableLayoutPerfil.Name = "tableLayoutPerfil";
            tableLayoutPerfil.RowCount = 7;
            tableLayoutPerfil.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPerfil.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPerfil.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPerfil.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPerfil.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPerfil.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPerfil.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPerfil.Size = new Size(502, 432);
            tableLayoutPerfil.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 58, 95);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(144, 52);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mi perfil";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutRol
            // 
            flowLayoutRol.Controls.Add(lblRol);
            flowLayoutRol.Controls.Add(btnCambiarContrasena);
            flowLayoutRol.Dock = DockStyle.Fill;
            flowLayoutRol.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutRol.Location = new Point(153, 0);
            flowLayoutRol.Margin = new Padding(0);
            flowLayoutRol.Name = "flowLayoutRol";
            flowLayoutRol.Padding = new Padding(0, 11, 0, 0);
            flowLayoutRol.Size = new Size(346, 52);
            flowLayoutRol.TabIndex = 13;
            flowLayoutRol.WrapContents = false;
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.Left;
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.FromArgb(245, 158, 11);
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.ForeColor = Color.White;
            lblRol.Location = new Point(153, 14);
            lblRol.Margin = new Padding(3, 0, 3, 0);
            lblRol.Name = "lblRol";
            lblRol.Padding = new Padding(12, 6, 12, 6);
            lblRol.Size = new Size(70, 29);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol";
            lblRol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombreValor
            // 
            tableLayoutPerfil.SetColumnSpan(lblNombreValor, 2);
            lblNombreValor.Dock = DockStyle.Fill;
            lblNombreValor.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNombreValor.ForeColor = Color.FromArgb(17, 24, 39);
            lblNombreValor.Location = new Point(3, 52);
            lblNombreValor.Name = "lblNombreValor";
            lblNombreValor.Size = new Size(496, 64);
            lblNombreValor.TabIndex = 2;
            lblNombreValor.Text = "Nombre Apellido";
            lblNombreValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEtiquetaUsuario
            // 
            lblEtiquetaUsuario.Dock = DockStyle.Fill;
            lblEtiquetaUsuario.Font = new Font("Segoe UI", 10F);
            lblEtiquetaUsuario.ForeColor = Color.FromArgb(75, 85, 99);
            lblEtiquetaUsuario.Location = new Point(3, 116);
            lblEtiquetaUsuario.Name = "lblEtiquetaUsuario";
            lblEtiquetaUsuario.Size = new Size(144, 44);
            lblEtiquetaUsuario.TabIndex = 3;
            lblEtiquetaUsuario.Text = "Usuario";
            lblEtiquetaUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsuarioValor
            // 
            lblUsuarioValor.Dock = DockStyle.Fill;
            lblUsuarioValor.Font = new Font("Segoe UI", 11F);
            lblUsuarioValor.ForeColor = Color.FromArgb(17, 24, 39);
            lblUsuarioValor.Location = new Point(153, 116);
            lblUsuarioValor.Name = "lblUsuarioValor";
            lblUsuarioValor.Size = new Size(346, 44);
            lblUsuarioValor.TabIndex = 4;
            lblUsuarioValor.Text = "-";
            lblUsuarioValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEtiquetaCorreo
            // 
            lblEtiquetaCorreo.Dock = DockStyle.Fill;
            lblEtiquetaCorreo.Font = new Font("Segoe UI", 10F);
            lblEtiquetaCorreo.ForeColor = Color.FromArgb(75, 85, 99);
            lblEtiquetaCorreo.Location = new Point(3, 160);
            lblEtiquetaCorreo.Name = "lblEtiquetaCorreo";
            lblEtiquetaCorreo.Size = new Size(144, 44);
            lblEtiquetaCorreo.TabIndex = 5;
            lblEtiquetaCorreo.Text = "Correo";
            lblEtiquetaCorreo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCorreoValor
            // 
            lblCorreoValor.Dock = DockStyle.Fill;
            lblCorreoValor.Font = new Font("Segoe UI", 11F);
            lblCorreoValor.ForeColor = Color.FromArgb(17, 24, 39);
            lblCorreoValor.Location = new Point(153, 160);
            lblCorreoValor.Name = "lblCorreoValor";
            lblCorreoValor.Size = new Size(346, 44);
            lblCorreoValor.TabIndex = 6;
            lblCorreoValor.Text = "-";
            lblCorreoValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEtiquetaTelefono
            // 
            lblEtiquetaTelefono.Dock = DockStyle.Fill;
            lblEtiquetaTelefono.Font = new Font("Segoe UI", 10F);
            lblEtiquetaTelefono.ForeColor = Color.FromArgb(75, 85, 99);
            lblEtiquetaTelefono.Location = new Point(3, 204);
            lblEtiquetaTelefono.Name = "lblEtiquetaTelefono";
            lblEtiquetaTelefono.Size = new Size(144, 44);
            lblEtiquetaTelefono.TabIndex = 7;
            lblEtiquetaTelefono.Text = "Teléfono";
            lblEtiquetaTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTelefonoValor
            // 
            lblTelefonoValor.Dock = DockStyle.Fill;
            lblTelefonoValor.Font = new Font("Segoe UI", 11F);
            lblTelefonoValor.ForeColor = Color.FromArgb(17, 24, 39);
            lblTelefonoValor.Location = new Point(153, 204);
            lblTelefonoValor.Name = "lblTelefonoValor";
            lblTelefonoValor.Size = new Size(346, 44);
            lblTelefonoValor.TabIndex = 8;
            lblTelefonoValor.Text = "-";
            lblTelefonoValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEtiquetaDireccion
            // 
            lblEtiquetaDireccion.Dock = DockStyle.Fill;
            lblEtiquetaDireccion.Font = new Font("Segoe UI", 10F);
            lblEtiquetaDireccion.ForeColor = Color.FromArgb(75, 85, 99);
            lblEtiquetaDireccion.Location = new Point(3, 248);
            lblEtiquetaDireccion.Name = "lblEtiquetaDireccion";
            lblEtiquetaDireccion.Size = new Size(144, 52);
            lblEtiquetaDireccion.TabIndex = 9;
            lblEtiquetaDireccion.Text = "Dirección";
            lblEtiquetaDireccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDireccionValor
            // 
            lblDireccionValor.Dock = DockStyle.Fill;
            lblDireccionValor.Font = new Font("Segoe UI", 11F);
            lblDireccionValor.ForeColor = Color.FromArgb(17, 24, 39);
            lblDireccionValor.Location = new Point(153, 248);
            lblDireccionValor.Name = "lblDireccionValor";
            lblDireccionValor.Size = new Size(346, 52);
            lblDireccionValor.TabIndex = 10;
            lblDireccionValor.Text = "-";
            lblDireccionValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEtiquetaEstado
            // 
            lblEtiquetaEstado.Dock = DockStyle.Fill;
            lblEtiquetaEstado.Font = new Font("Segoe UI", 10F);
            lblEtiquetaEstado.ForeColor = Color.FromArgb(75, 85, 99);
            lblEtiquetaEstado.Location = new Point(3, 300);
            lblEtiquetaEstado.Name = "lblEtiquetaEstado";
            lblEtiquetaEstado.Size = new Size(144, 44);
            lblEtiquetaEstado.TabIndex = 11;
            lblEtiquetaEstado.Text = "Estado";
            lblEtiquetaEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEstadoValor
            // 
            lblEstadoValor.Dock = DockStyle.Fill;
            lblEstadoValor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEstadoValor.ForeColor = Color.FromArgb(22, 163, 74);
            lblEstadoValor.Location = new Point(153, 300);
            lblEstadoValor.Name = "lblEstadoValor";
            lblEstadoValor.Size = new Size(346, 44);
            lblEstadoValor.TabIndex = 12;
            lblEstadoValor.Text = "Activo";
            lblEstadoValor.TextAlign = ContentAlignment.MiddleLeft;
            //
            // btnCambiarContrasena
            //
            btnCambiarContrasena.Anchor = AnchorStyles.Left;
            btnCambiarContrasena.BackColor = Color.FromArgb(30, 58, 95);
            btnCambiarContrasena.Cursor = Cursors.Hand;
            btnCambiarContrasena.FlatAppearance.BorderSize = 0;
            btnCambiarContrasena.FlatStyle = FlatStyle.Flat;
            btnCambiarContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCambiarContrasena.ForeColor = Color.White;
            btnCambiarContrasena.Location = new Point(85, 11);
            btnCambiarContrasena.Margin = new Padding(12, 0, 0, 0);
            btnCambiarContrasena.Name = "btnCambiarContrasena";
            btnCambiarContrasena.Size = new Size(160, 29);
            btnCambiarContrasena.TabIndex = 14;
            btnCambiarContrasena.Text = "Cambiar contraseña";
            btnCambiarContrasena.UseVisualStyleBackColor = false;
            btnCambiarContrasena.Click += btnCambiarContrasena_Click;
            //
            // PerfilUsuarioControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(panelPrincipal);
            Name = "PerfilUsuarioControl";
            Size = new Size(900, 650);
            panelPrincipal.ResumeLayout(false);
            tableLayoutCentro.ResumeLayout(false);
            panelTarjeta.ResumeLayout(false);
            tableLayoutPerfil.ResumeLayout(false);
            tableLayoutPerfil.PerformLayout();
            flowLayoutRol.ResumeLayout(false);
            flowLayoutRol.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private TableLayoutPanel tableLayoutCentro;
        private Panel panelTarjeta;
        private TableLayoutPanel tableLayoutPerfil;
        private Label lblTitulo;
        private FlowLayoutPanel flowLayoutRol;
        private Label lblRol;
        private Label lblNombreValor;
        private Label lblEtiquetaUsuario;
        private Label lblUsuarioValor;
        private Label lblEtiquetaCorreo;
        private Label lblCorreoValor;
        private Label lblEtiquetaTelefono;
        private Label lblTelefonoValor;
        private Label lblEtiquetaDireccion;
        private Label lblDireccionValor;
        private Label lblEtiquetaEstado;
        private Label lblEstadoValor;
        private Button btnCambiarContrasena;
    }
}
