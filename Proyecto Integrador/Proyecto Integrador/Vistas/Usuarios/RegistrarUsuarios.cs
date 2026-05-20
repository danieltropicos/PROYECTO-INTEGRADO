using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Vistas.Usuarios
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
            Rol nuevorol = new Rol("Usuario");
            Usuario usuarionuevo = new Usuario(txtNombreUsu.Text, txtApellidoUsu.Text, txtCorreoUsu.Text, txtTelefonoUsu.Text, txtDireccionUsu.Text, txtNombreUsuarioUsu.Text, txtContrasenaUsu.Text, nuevorol, true);
            controladorUsuario.AgregarUsuario(usuarionuevo);
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
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
    }
}
