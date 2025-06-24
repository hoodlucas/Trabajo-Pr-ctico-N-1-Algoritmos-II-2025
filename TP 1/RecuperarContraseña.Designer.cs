namespace TP_1
{
    partial class RecuperarContraseña
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblUsuario = new Label();
            txtNombre = new TextBox();
            btnEnviarCodigo = new Button();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            txtUsuarioRecuperar = new TextBox();
            lblUsuario2 = new Label();
            lblDivision = new Label();
            btnVerificar = new Button();
            lblTitulo2 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(78, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(227, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recuperar Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(43, 94);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(87, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Ingrese usuario";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(152, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(139, 23);
            txtNombre.TabIndex = 2;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.Location = new Point(43, 134);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(107, 23);
            btnEnviarCodigo.TabIndex = 3;
            btnEnviarCodigo.Text = "Enviar código";
            btnEnviarCodigo.UseVisualStyleBackColor = true;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(43, 292);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(85, 15);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "Ingrese código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(152, 289);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(139, 23);
            txtCodigo.TabIndex = 5;
            // 
            // txtUsuarioRecuperar
            // 
            txtUsuarioRecuperar.Location = new Point(152, 260);
            txtUsuarioRecuperar.Name = "txtUsuarioRecuperar";
            txtUsuarioRecuperar.Size = new Size(139, 23);
            txtUsuarioRecuperar.TabIndex = 7;
            // 
            // lblUsuario2
            // 
            lblUsuario2.AutoSize = true;
            lblUsuario2.Location = new Point(43, 263);
            lblUsuario2.Name = "lblUsuario2";
            lblUsuario2.Size = new Size(87, 15);
            lblUsuario2.TabIndex = 6;
            lblUsuario2.Text = "Ingrese usuario";
            // 
            // lblDivision
            // 
            lblDivision.AutoSize = true;
            lblDivision.Location = new Point(43, 183);
            lblDivision.Name = "lblDivision";
            lblDivision.Size = new Size(287, 15);
            lblDivision.TabIndex = 8;
            lblDivision.Text = "--------------------------------------------------------";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(43, 341);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(107, 23);
            btnVerificar.TabIndex = 9;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo2.Location = new Point(78, 209);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(211, 30);
            lblTitulo2.TabIndex = 10;
            lblTitulo2.Text = "Resetear Contraseña";
            // 
            // RecuperarContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 407);
            Controls.Add(lblTitulo2);
            Controls.Add(btnVerificar);
            Controls.Add(lblDivision);
            Controls.Add(txtUsuarioRecuperar);
            Controls.Add(lblUsuario2);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnEnviarCodigo);
            Controls.Add(txtNombre);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Name = "RecuperarContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperar contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuario;
        private TextBox txtNombre;
        private Button btnEnviarCodigo;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtUsuarioRecuperar;
        private Label lblUsuario2;
        private Label lblDivision;
        private Button btnVerificar;
        private Label lblTitulo2;
    }
}