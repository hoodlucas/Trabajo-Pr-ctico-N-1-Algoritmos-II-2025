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
    public partial class RecuperarContraseña : Form
    {
        private string codigoGenerado = "";      // Código generado para recuperar la contraseña
        private string usuarioRecuperando = "";  // Usuario que está intentando recuperar contraseña

        public RecuperarContraseña()
        {
            InitializeComponent();

            // Permite enviar el código presionando Enter
            this.AcceptButton = btnEnviarCodigo;
        }

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            string usuario = txtNombre.Text.Trim();

            // Verifica si el usuario existe
            if (BaseDeDatos.Usuarios.Any(u => u.Username == usuario))
            {
                // Genera un código numérico aleatorio de 6 dígitos
                Random rnd = new Random();
                codigoGenerado = rnd.Next(100000, 999999).ToString();

                // Guarda el usuario para verificar luego
                usuarioRecuperando = usuario;

                MessageBox.Show($"Tu código de recuperación es: {codigoGenerado}");
            }
            else
            {
                // Usuario no encontrado
                MessageBox.Show("El usuario no existe.");
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuarioRecuperar.Text.Trim();
            string codigoIngresado = txtCodigo.Text.Trim();

            // Comprueba que los campos no estén vacíos
            if (codigoGenerado == "" || usuarioIngresado == "")
            {
                MessageBox.Show("Por favor, completá ambos campos.");
                return;
            }

            // Verifica que el usuario y código coincidan
            if (usuarioIngresado == usuarioRecuperando && codigoIngresado == codigoGenerado)
            {
                // Abre el formulario para cambiar la contraseña
                ResetearContraseña formResetear = new ResetearContraseña(usuarioIngresado);

                this.Hide();            // Oculta el formulario actual
                formResetear.ShowDialog();  // Muestra el formulario para resetear
                this.Close();           // Cierra el formulario actual al volver
            }
            else
            {
                // Si no coinciden, muestra error
                MessageBox.Show("Usuario o código incorrectos. Intente nuevamente.");
            }
        }
    }
}