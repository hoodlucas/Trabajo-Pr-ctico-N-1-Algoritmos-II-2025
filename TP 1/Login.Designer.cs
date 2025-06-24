namespace TP_1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciarSesion = new Button();
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnRecuperarContraseña = new Button();
            ckbMostrarContraseña = new CheckBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(63, 190);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(227, 45);
            btnIniciarSesion.TabIndex = 2;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(63, 70);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(63, 109);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(144, 66);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(146, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(144, 106);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(146, 23);
            txtContraseña.TabIndex = 1;
            // 
            // btnRecuperarContraseña
            // 
            btnRecuperarContraseña.Location = new Point(63, 254);
            btnRecuperarContraseña.Name = "btnRecuperarContraseña";
            btnRecuperarContraseña.Size = new Size(227, 45);
            btnRecuperarContraseña.TabIndex = 3;
            btnRecuperarContraseña.Text = "Recuperar Contraseña";
            btnRecuperarContraseña.UseVisualStyleBackColor = true;
            btnRecuperarContraseña.Click += btnRecuperarContraseña_Click;
            // 
            // ckbMostrarContraseña
            // 
            ckbMostrarContraseña.AutoSize = true;
            ckbMostrarContraseña.Location = new Point(63, 150);
            ckbMostrarContraseña.Name = "ckbMostrarContraseña";
            ckbMostrarContraseña.Size = new Size(130, 19);
            ckbMostrarContraseña.TabIndex = 4;
            ckbMostrarContraseña.Text = "Mostrar Contraseña";
            ckbMostrarContraseña.UseVisualStyleBackColor = true;
            ckbMostrarContraseña.CheckedChanged += ckbMostrarContraseña_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(103, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(144, 30);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Iniciar Sesión";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 343);
            Controls.Add(lblTitulo);
            Controls.Add(ckbMostrarContraseña);
            Controls.Add(btnRecuperarContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(btnIniciarSesion);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnRecuperarContraseña;
        private CheckBox ckbMostrarContraseña;
        private Label lblTitulo;
    }
}
