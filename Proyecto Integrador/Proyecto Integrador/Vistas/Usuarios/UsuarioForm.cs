using Proyecto_Integrador.Controladores;
using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Vistas.Utilidades;

namespace Proyecto_Integrador.Vistas.Usuarios
{
    public partial class UsuarioForm : Form
    {
        private readonly RolControlador _rolControlador = new();

        public bool EsEditar { get; private set; }
        public Usuario? Entidad { get; private set; }
        public string? ContrasenaPlana { get; private set; }

        public UsuarioForm()
        {
            InitializeComponent();
            Text = "Nuevo usuario";
            btnGuardar.Text = "Guardar";
            comboBoxRol.DisplayMember = nameof(Rol.Nombre);
            comboBoxRol.DataSource = _rolControlador.ObtenerRoles();
            picOjo.ImageLocation = RecursosAplicacion.Ruta(RecursosAplicacion.ArchivoOjoCerrado);
        }

        public UsuarioForm(Usuario usuario) : this()
        {
            EsEditar = true;
            Text = "Editar usuario";
            btnGuardar.Text = "Actualizar";

            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtCorreo.Text = usuario.CorreoElectronico;
            txtTelefono.Text = usuario.Telefono;
            txtDireccion.Text = usuario.Direccion;
            txtUsuario.Text = usuario.NombreUsuario;

            var rol = _rolControlador.ObtenerRoles()
                .FirstOrDefault(r => r.Nombre == usuario.Rol.Nombre);
            if (rol is not null)
                comboBoxRol.SelectedItem = rol;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                comboBoxRol.SelectedItem is not Rol rolSeleccionado)
            {
                MessageBox.Show("Complete los campos obligatorios.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EsEditar && string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Ingrese la contraseña.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var contrasena = txtContrasena.Text;
            ContrasenaPlana = string.IsNullOrWhiteSpace(contrasena) ? null : contrasena;

            // En edición sin contraseña nueva, el repositorio conserva la anterior.
            var contrasenaParaModelo = ContrasenaPlana ?? "no-cambiar";
            Entidad = new Usuario(
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtTelefono.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtUsuario.Text.Trim(),     
                contrasenaParaModelo,
                rolSeleccionado);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void picOjo_Click(object sender, EventArgs e)
        {
            if (txtContrasena.UseSystemPasswordChar)
            {
                txtContrasena.UseSystemPasswordChar = false;
                picOjo.ImageLocation = RecursosAplicacion.Ruta(RecursosAplicacion.ArchivoOjoAbierto);
            }
            else
            {
                txtContrasena.UseSystemPasswordChar = true;
                picOjo.ImageLocation = RecursosAplicacion.Ruta(RecursosAplicacion.ArchivoOjoCerrado);
            }
        }
    }
}
