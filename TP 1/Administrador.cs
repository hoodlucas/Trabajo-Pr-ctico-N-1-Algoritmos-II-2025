using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_1;


namespace TP_1
{
    public partial class Administrador : Form
    {
        // Al cargar el form, mostramos los usuarios
        private void Administrador_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        public Administrador()
        {
            InitializeComponent();
            CargarUsuarios(); // Por las dudas también acá
        }

        // Llena la grilla con los usuarios
        private void CargarUsuarios()
        {
            dgvUsuarios.AutoGenerateColumns = true;
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = BaseDeDatos.Usuarios;
        }

        // Cierra sesión y vuelve al login
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();
            this.Hide();
        }

        // Abre el form para registrar usuarios
        private void button2_Click(object sender, EventArgs e)
        {
            Form RegistrarUsuarios = new RegistrarUsuarios();
            RegistrarUsuarios.ShowDialog();
            CargarUsuarios(); // Actualiza grilla
        }

        // Modifica el usuario seleccionado
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                Usuario usuarioSeleccionado = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;
                ModificarUsuarios formModificar = new ModificarUsuarios(usuarioSeleccionado);
                formModificar.ShowDialog();
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario apretando el ▶ de la tabla para modificar.");
            }
        }
    }
}
