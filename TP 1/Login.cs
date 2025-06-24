namespace TP_1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnIniciarSesion; // Enter = iniciar sesión
        }

        // Si el usuario cierra la ventana con la X, cerramos toda la app
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Botón para iniciar sesión
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contraseñaIngresada = txtContraseña.Text;

            Usuario usuarioEncontrado = null;

            // Buscamos si hay un usuario que coincida con los datos
            foreach (Usuario u in BaseDeDatos.Usuarios)
            {
                if (u.Username == usuarioIngresado && u.Contraseña == contraseñaIngresada)
                {
                    usuarioEncontrado = u;
                    break;
                }
            }

            if (usuarioEncontrado != null)
            {

                // Si es admin, lo mandamos al panel de administración
                if (usuarioEncontrado.Rol == "Administrador")
                {
                    Administrador adminForm = new Administrador();
                    adminForm.Show();
                }
                else
                {
                    // Si es usuario común, puede editar su perfil
                    this.Hide();
                    EditarPerfil formEditar = new EditarPerfil(usuarioEncontrado);
                    formEditar.ShowDialog();
                }

                this.Hide(); // Ocultamos el login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        // Al cargar el form, si no hay usuarios cargados, agregamos 2 de ejemplo
        private void Login_Load(object sender, EventArgs e)
        {
            if (BaseDeDatos.Usuarios.Count == 0)
            {
                BaseDeDatos.Usuarios.Add(new Usuario
                {
                    Username = "admin",
                    Contraseña = "1234",
                    Rol = "Administrador"
                });

                BaseDeDatos.Usuarios.Add(new Usuario
                {
                    Username = "lucas",
                    Contraseña = "abcd",
                    Rol = "Usuario"
                });
            }
        }

        // Mostrar u ocultar la contraseña al tildar el checkbox
        private void ckbMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMostrarContraseña.Checked)
            {
                txtContraseña.PasswordChar = '\0'; // Mostrar
            }
            else
            {
                txtContraseña.PasswordChar = '*'; // Ocultar
            }
        }

        // Abre el formulario de recuperación de contraseña
        private void btnRecuperarContraseña_Click(object sender, EventArgs e)
        {
            RecuperarContraseña formRecuperarContraseña = new RecuperarContraseña();
            formRecuperarContraseña.ShowDialog();
        }

        private void Login_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
           // DialogResult.Cancel;
        }
    }
}
