using Microsoft.VisualBasic;
using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Layout;
using Proyecto_Integrador.Vistas.Usuarios;
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

        private void Limpiar()
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            UsuarioControlador usuarioControlador = new UsuarioControlador();
            int bandera = 0;
            foreach (var usuario in usuarioControlador.ObtenerUsuarios())
            {
                if (usuario.NombreUsuario == txtUsuario.Text && usuario.ContrasenaEncriptada == HashContrasena(txtContraseña.Text))
                {
                    MessageBox.Show("-- Bienvenido " + usuario.NombreUsuario + ". --");
                    HomeLayout homeLayout = new HomeLayout();
                    homeLayout.Show();
                    this.Hide();
                    bandera++;

                }
            }
            if (bandera == 0)
            {
                MessageBox.Show("-- Usuario o Contraseña Incorrecto --");
                Limpiar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            pictureBox1.Image = Image.FromFile("Imagenes/ojoCerrado.jpg");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

            var registrarUsuariosForm = new RegistrarUsuarios();
            registrarUsuariosForm.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar)
            {
                txtContraseña.UseSystemPasswordChar = false;
                pictureBox1.Image = Image.FromFile("Imagenes/ojoAbierto.jpg");

            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                pictureBox1.Image = Image.FromFile("Imagenes/ojoCerrado.jpg");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            pictureBox1.Image = Image.FromFile("Imagenes/ojoCerrado.jpg");
        }
    }
}
