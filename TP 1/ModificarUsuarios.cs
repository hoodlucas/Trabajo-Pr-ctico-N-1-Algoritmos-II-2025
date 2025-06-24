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
    public partial class ModificarUsuarios : Form
    {
        private Usuario usuarioAEditar;

        // Constructor: recibe el usuario que queremos modificar
        public ModificarUsuarios(Usuario usuario)
        {
            InitializeComponent();
            usuarioAEditar = usuario;
            this.AcceptButton = btnGuardar; // Enter guarda
        }

        // Al cargar el form, mostramos los datos actuales del usuario
        private void ModificarUsuarios_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = usuarioAEditar.Username;
            txtContraseña.Text = usuarioAEditar.Contraseña;
            cmbRol.Text = usuarioAEditar.Rol;
        }

        // Cuando apretamos guardar, actualizamos los datos del usuario
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            usuarioAEditar.Username = txtUsuario.Text;
            usuarioAEditar.Contraseña = txtContraseña.Text;
            usuarioAEditar.Rol = cmbRol.Text;

            this.Close(); // Cerramos el form después de guardar
        }
    }
}
