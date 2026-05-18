using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Vistas
{
    public partial class RegistrarUsuarios : Form
    {
        UsuarioControlador controladorUsuario = new UsuarioControlador();

        public RegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Rol nuevoRol = new Rol("Usuario");
            Usuario usuarionuevo = new Usuario(txtNombreUsu.Text, txtApellidoUsu.Text, txtCorreoUsu.Text, txtTelefonoUsu.Text, txtDireccionUsu.Text, txtNombreUsuarioUsu.Text, txtContrasenaUsu.Text, nuevoRol, true);
            controladorUsuario.AgregarUsuario(usuarionuevo);
            Limpiar();

        }

        private void Limpiar()
        {
            txtNombreUsu.Clear();
            txtApellidoUsu.Clear();
            txtCorreoUsu.Clear();
            txtTelefonoUsu.Clear();
            txtDireccionUsu.Clear();
            txtNombreUsuarioUsu.Clear();
            txtContrasenaUsu.Clear();
        }

        private void InitializeComponent()
        {
            PanelAdminUsuarios = new Panel();
            txtDireccionUsu = new TextBox();
            labelDireccionUsu = new Label();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            txtContrasenaUsu = new TextBox();
            labelContraseña = new Label();
            txtNombreUsuarioUsu = new TextBox();
            label6 = new Label();
            txtTelefonoUsu = new TextBox();
            labelTelefono = new Label();
            txtCorreoUsu = new TextBox();
            labelCorreoUsu = new Label();
            txtApellidoUsu = new TextBox();
            labelApellido = new Label();
            txtNombreUsu = new TextBox();
            labelNombre = new Label();
            label1 = new Label();
            PanelAdminUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // PanelAdminUsuarios
            // 
            PanelAdminUsuarios.Controls.Add(txtDireccionUsu);
            PanelAdminUsuarios.Controls.Add(labelDireccionUsu);
            PanelAdminUsuarios.Controls.Add(btnLimpiar);
            PanelAdminUsuarios.Controls.Add(btnRegistrar);
            PanelAdminUsuarios.Controls.Add(txtContrasenaUsu);
            PanelAdminUsuarios.Controls.Add(labelContraseña);
            PanelAdminUsuarios.Controls.Add(txtNombreUsuarioUsu);
            PanelAdminUsuarios.Controls.Add(label6);
            PanelAdminUsuarios.Controls.Add(txtTelefonoUsu);
            PanelAdminUsuarios.Controls.Add(labelTelefono);
            PanelAdminUsuarios.Controls.Add(txtCorreoUsu);
            PanelAdminUsuarios.Controls.Add(labelCorreoUsu);
            PanelAdminUsuarios.Controls.Add(txtApellidoUsu);
            PanelAdminUsuarios.Controls.Add(labelApellido);
            PanelAdminUsuarios.Controls.Add(txtNombreUsu);
            PanelAdminUsuarios.Controls.Add(labelNombre);
            PanelAdminUsuarios.Location = new Point(175, 184);
            PanelAdminUsuarios.Name = "PanelAdminUsuarios";
            PanelAdminUsuarios.Size = new Size(752, 518);
            PanelAdminUsuarios.TabIndex = 5;
            // 
            // txtDireccionUsu
            // 
            txtDireccionUsu.Location = new Point(284, 280);
            txtDireccionUsu.Name = "txtDireccionUsu";
            txtDireccionUsu.Size = new Size(281, 27);
            txtDireccionUsu.TabIndex = 17;
            // 
            // labelDireccionUsu
            // 
            labelDireccionUsu.AutoSize = true;
            labelDireccionUsu.Location = new Point(191, 283);
            labelDireccionUsu.Name = "labelDireccionUsu";
            labelDireccionUsu.Size = new Size(72, 20);
            labelDireccionUsu.TabIndex = 16;
            labelDireccionUsu.Text = "Dirección";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(435, 437);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(284, 437);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtContrasenaUsu
            // 
            txtContrasenaUsu.Location = new Point(284, 376);
            txtContrasenaUsu.Name = "txtContrasenaUsu";
            txtContrasenaUsu.Size = new Size(281, 27);
            txtContrasenaUsu.TabIndex = 13;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(191, 379);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(83, 20);
            labelContraseña.TabIndex = 12;
            labelContraseña.Text = "Contraseña";
            // 
            // txtNombreUsuarioUsu
            // 
            txtNombreUsuarioUsu.Location = new Point(315, 324);
            txtNombreUsuarioUsu.Name = "txtNombreUsuarioUsu";
            txtNombreUsuarioUsu.Size = new Size(250, 27);
            txtNombreUsuarioUsu.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(191, 327);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 10;
            label6.Text = "Nombre Usuario";
            // 
            // txtTelefonoUsu
            // 
            txtTelefonoUsu.Location = new Point(284, 229);
            txtTelefonoUsu.Name = "txtTelefonoUsu";
            txtTelefonoUsu.Size = new Size(281, 27);
            txtTelefonoUsu.TabIndex = 9;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(191, 232);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(67, 20);
            labelTelefono.TabIndex = 8;
            labelTelefono.Text = "Telefono";
            // 
            // txtCorreoUsu
            // 
            txtCorreoUsu.Location = new Point(284, 168);
            txtCorreoUsu.Name = "txtCorreoUsu";
            txtCorreoUsu.Size = new Size(281, 27);
            txtCorreoUsu.TabIndex = 7;
            // 
            // labelCorreoUsu
            // 
            labelCorreoUsu.AutoSize = true;
            labelCorreoUsu.Location = new Point(191, 171);
            labelCorreoUsu.Name = "labelCorreoUsu";
            labelCorreoUsu.Size = new Size(54, 20);
            labelCorreoUsu.TabIndex = 6;
            labelCorreoUsu.Text = "Correo";
            // 
            // txtApellidoUsu
            // 
            txtApellidoUsu.Location = new Point(284, 113);
            txtApellidoUsu.Name = "txtApellidoUsu";
            txtApellidoUsu.Size = new Size(281, 27);
            txtApellidoUsu.TabIndex = 5;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(191, 116);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(66, 20);
            labelApellido.TabIndex = 4;
            labelApellido.Text = "Apellido";
            // 
            // txtNombreUsu
            // 
            txtNombreUsu.Location = new Point(284, 61);
            txtNombreUsu.Name = "txtNombreUsu";
            txtNombreUsu.Size = new Size(281, 27);
            txtNombreUsu.TabIndex = 3;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(191, 64);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(490, 142);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 4;
            label1.Text = "Registrar Usuario";
            // 
            // RegistrarUsuarios
            // 
            ClientSize = new Size(1102, 845);
            Controls.Add(PanelAdminUsuarios);
            Controls.Add(label1);
            Name = "RegistrarUsuarios";
            PanelAdminUsuarios.ResumeLayout(false);
            PanelAdminUsuarios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }



        private Panel PanelAdminUsuarios;
        private TextBox txtDireccionUsu;
        private Label labelDireccionUsu;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private TextBox txtContrasenaUsu;
        private Label labelContraseña;
        private TextBox txtNombreUsuarioUsu;
        private Label label6;
        private TextBox txtTelefonoUsu;
        private Label labelTelefono;
        private TextBox txtCorreoUsu;
        private Label labelCorreoUsu;
        private TextBox txtApellidoUsu;
        private Label labelApellido;
        private TextBox txtNombreUsu;
        private Label labelNombre;
        private Label label1;
    }
}
