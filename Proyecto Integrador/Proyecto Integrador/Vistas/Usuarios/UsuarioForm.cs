using Proyecto_Integrador.Modelos.Usuarios;
using Proyecto_Integrador.Validaciones;
using Proyecto_Integrador.Vistas.Utilidades;

namespace Proyecto_Integrador.Vistas.Usuarios
{
    public partial class UsuarioForm : Form
    {
        private static readonly Rol RolPorDefecto = new("Usuario");

        private readonly Rol _rol;

        public bool EsEditar { get; private set; }
        public Usuario? Entidad { get; private set; }
        public string? ContrasenaPlana { get; private set; }

        public UsuarioForm() : this(null)
        {
        }

        public UsuarioForm(Usuario? usuario)
        {
            _rol = usuario?.Rol ?? RolPorDefecto;
            EsEditar = usuario is not null;

            InitializeComponent();
            picOjo.ImageLocation = RecursosAplicacion.Ruta(RecursosAplicacion.ArchivoOjoCerrado);

            if (EsEditar)
            {
                Text = "Editar usuario";
                btnGuardar.Text = "Actualizar";
                txtNombre.Text = usuario!.Nombre;
                txtApellido.Text = usuario.Apellido;
                txtCorreo.Text = usuario.CorreoElectronico;
                txtTelefono.Text = usuario.Telefono;
                txtDireccion.Text = usuario.Direccion;
                txtUsuario.Text = usuario.NombreUsuario;
            }
            else
            {
                Text = "Nuevo usuario";
                btnGuardar.Text = "Guardar";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Complete los campos obligatorios.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarNombreApellido.EsValido(txtNombre.Text))
                return;

            if (!ValidarNombreApellido.EsValido(txtApellido.Text))
                return;

            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                !ValidarTelefono.EsValido(txtTelefono.Text))
                return;

            if (!EsEditar)
            {
                if (string.IsNullOrWhiteSpace(txtContrasena.Text))
                {
                    MessageBox.Show("Ingrese la contraseña.",
                        "Datos incompletos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidarContraseña.EsValida(txtContrasena.Text))
                    return;
            }

            var contrasena = txtContrasena.Text;
            ContrasenaPlana = string.IsNullOrWhiteSpace(contrasena)
                ? null
                : contrasena;

            var contrasenaParaModelo = ContrasenaPlana ?? "no-cambiar";

            Entidad = new Usuario(
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtTelefono.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtUsuario.Text.Trim(),
                contrasenaParaModelo,
                _rol);

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
