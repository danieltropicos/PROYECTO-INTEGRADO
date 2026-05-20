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
    public partial class RegistrarAdministradores : Form
    {
        UsuarioControlador controladorUsuario = new UsuarioControlador();
        public RegistrarAdministradores()
        {
            InitializeComponent();
        }

        private void RegistrarAdministradores_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Rol nuevorol = new Rol("Admin");
            Usuario adminnuevo = new Usuario(txtNombreAdm.Text,
                                             txtApellidoAdm.Text,
                                             txtCorreoAdm.Text,
                                             txtTelefonoAdm.Text,
                                             txtDireccionAdm.Text,
                                             txtNombreUsuarioAdm.Text,
                                             txtContrasenaAdm.Text,
                                             nuevorol);
            controladorUsuario.AgregarUsuario(adminnuevo);
            Limpiar();


        }

        private void Limpiar()
        {
            txtNombreAdm.Clear();
            txtApellidoAdm.Clear();
            txtCorreoAdm.Clear();
            txtTelefonoAdm.Clear();
            txtDireccionAdm.Clear();
            txtNombreUsuarioAdm.Clear();
            txtContrasenaAdm.Clear();
        }
    }
}
