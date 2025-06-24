using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class EditarPerfil : Form
    {
        private Usuario usuario;

        // Constructor: recibe el usuario actual y carga sus datos en los campos
        public EditarPerfil(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.AcceptButton = btnEditar; // Enter activa el botón Editar

            // Mostramos el nombre y la contraseña actuales
            txtUsuario.Text = usuario.Username;
            txtContraseña.Text = usuario.Contraseña;
        }

        // Botón para guardar los cambios en el perfil
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = txtUsuario.Text.Trim();
            string nuevaContraseña = txtContraseña.Text.Trim();

            // Validamos que no queden campos vacíos
            if (nuevoUsuario == "" || nuevaContraseña == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Chequeamos que el nuevo nombre no esté repetido (en otro usuario)
            bool usuarioDuplicado = BaseDeDatos.Usuarios.Any(u => u.Username == nuevoUsuario && u != usuario);

            if (usuarioDuplicado)
            {
                MessageBox.Show("Ese nombre de usuario ya está en uso. Elija otro.");
                return;
            }

            // Todo bien: actualizamos el objeto usuario
            usuario.Username = nuevoUsuario;
            usuario.Contraseña = nuevaContraseña;

            MessageBox.Show("Datos actualizados correctamente.");
        }

        // Botón para cerrar sesión y volver al login
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha cerrado sesión de forma exitosa");
            Form Login = new Login();
            Login.Show();
            this.Close(); // Cerramos esta ventana
        }
    }
}
