using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Controladores
{
    internal class UsuarioControlador
    {
        private UsuarioRepositorio usuarioRepositorio;

        public UsuarioControlador()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarioRepositorio.Leer();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            usuarioRepositorio.Agregar(usuario);
        }
    }
}
