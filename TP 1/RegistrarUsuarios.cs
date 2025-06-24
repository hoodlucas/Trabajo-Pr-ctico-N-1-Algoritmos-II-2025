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
    public partial class RegistrarUsuarios : Form
    {
        public RegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Capturamos los datos ingresados
            string username = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string rol = cmbRol.Text;

            // Validaciones
            if (username == "" || contraseña == "" || rol == "")
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            // Validar que el username no exista
            foreach (Usuario u in BaseDeDatos.Usuarios)
            {
                if (u.Username == username)
                {
                    MessageBox.Show("El nombre de usuario ya existe.");
                    return;
                }
            }

            // Crear el nuevo usuario
            Usuario nuevoUsuario = new Usuario
            {
                Username = username,        
                Contraseña = contraseña,
                Rol = rol
            };

            // Agregamos a la lista
            BaseDeDatos.Usuarios.Add(nuevoUsuario);

            // Limpiamos los campos para cargar otro queremos
            txtUsuario.Clear();
            txtContraseña.Clear();
            cmbRol.SelectedIndex = -1;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
