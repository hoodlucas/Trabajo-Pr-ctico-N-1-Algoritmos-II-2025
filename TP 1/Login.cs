namespace TP_1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnIniciarSesion; // Enter = iniciar sesi�n
        }

        // Si el usuario cierra la ventana con la X, cerramos toda la app
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Bot�n para iniciar sesi�n
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contrase�aIngresada = txtContrase�a.Text;

            Usuario usuarioEncontrado = null;

            // Buscamos si hay un usuario que coincida con los datos
            foreach (Usuario u in BaseDeDatos.Usuarios)
            {
                if (u.Username == usuarioIngresado && u.Contrase�a == contrase�aIngresada)
                {
                    usuarioEncontrado = u;
                    break;
                }
            }

            if (usuarioEncontrado != null)
            {

                // Si es admin, lo mandamos al panel de administraci�n
                if (usuarioEncontrado.Rol == "Administrador")
                {
                    Administrador adminForm = new Administrador();
                    adminForm.Show();
                }
                else
                {
                    // Si es usuario com�n, puede editar su perfil
                    this.Hide();
                    EditarPerfil formEditar = new EditarPerfil(usuarioEncontrado);
                    formEditar.ShowDialog();
                }

                this.Hide(); // Ocultamos el login
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos");
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
                    Contrase�a = "1234",
                    Rol = "Administrador"
                });

                BaseDeDatos.Usuarios.Add(new Usuario
                {
                    Username = "lucas",
                    Contrase�a = "abcd",
                    Rol = "Usuario"
                });
            }
        }

        // Mostrar u ocultar la contrase�a al tildar el checkbox
        private void ckbMostrarContrase�a_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMostrarContrase�a.Checked)
            {
                txtContrase�a.PasswordChar = '\0'; // Mostrar
            }
            else
            {
                txtContrase�a.PasswordChar = '*'; // Ocultar
            }
        }

        // Abre el formulario de recuperaci�n de contrase�a
        private void btnRecuperarContrase�a_Click(object sender, EventArgs e)
        {
            RecuperarContrase�a formRecuperarContrase�a = new RecuperarContrase�a();
            formRecuperarContrase�a.ShowDialog();
        }

        private void Login_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
           // DialogResult.Cancel;
        }
    }
}
