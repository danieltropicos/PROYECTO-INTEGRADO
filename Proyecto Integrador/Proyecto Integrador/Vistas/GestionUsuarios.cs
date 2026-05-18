using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.Vistas
{
    public partial class GestionUsuarios : Form
    {
        UsuarioControlador controladorUsuario = new UsuarioControlador();
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = controladorUsuario.ObtenerUsuarios();

            dgvUsuarios.Columns["ContrasenaEncriptada"].Visible = false;
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow?.DataBoundItem is not Usuario usuario)
                return;

            usuario.EsActivo = !usuario.EsActivo;

            controladorUsuario.ActualizarUsuario(usuario);

            CargarUsuarios();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        
    }
}
