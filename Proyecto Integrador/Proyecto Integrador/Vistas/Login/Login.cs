using Microsoft.VisualBasic;
using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Vistas.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string HashContrasena(string contrasena)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(contrasena);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            UsuarioControlador usuarioControlador = new UsuarioControlador();
            foreach (var usuario in usuarioControlador.ObtenerUsuarios())
            {
                if (usuario.NombreUsuario == txtUsuario.Text && usuario.ContrasenaEncriptada == HashContrasena(txtContraseña.Text))
                {
                    MessageBox.Show("Bienvenido.");

                }
            }


        }
    }
}
