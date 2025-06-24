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
    public partial class ResetearContraseña : Form
    {
        private string usuario;  // Usuario que va a cambiar la contraseña

        public ResetearContraseña(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            // Permite presionar Enter para enviar la nueva contraseña
            this.AcceptButton = btnNuevaContraseña;
        }

        private void btnNuevaContraseña_Click(object sender, EventArgs e)
        {
            string nuevaContraseña = txtContraseña.Text.Trim();
            string confirmarContraseña = txtConfirmacion.Text.Trim();

            // Verifica que los campos no estén vacíos
            if (nuevaContraseña == "" || confirmarContraseña == "")
            {
                MessageBox.Show("Por favor, completá ambos campos.");
                return;
            }

            // Verifica que ambas contraseñas coincidan
            if (nuevaContraseña != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            // Busca el usuario en la base de datos simulada
            var usuarioEncontrado = BaseDeDatos.Usuarios.FirstOrDefault(u => u.Username == usuario);

            // Actualiza la contraseña del usuario
            usuarioEncontrado.Contraseña = nuevaContraseña;

            MessageBox.Show("Contraseña actualizada correctamente.");

            this.Close(); // Cierra el formulario después de actualizar
        }
    }
}