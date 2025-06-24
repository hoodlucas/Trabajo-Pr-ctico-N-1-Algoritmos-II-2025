namespace TP_1
{
    partial class ModificarUsuarios
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
            lblTituloModificar = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            cmbRol = new ComboBox();
            btnGuardar = new Button();
            lblUsuario = new Label();
            lblConstraseña = new Label();
            lblRol = new Label();
            SuspendLayout();
            // 
            // lblTituloModificar
            // 
            lblTituloModificar.AutoSize = true;
            lblTituloModificar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloModificar.Location = new Point(61, 42);
            lblTituloModificar.Name = "lblTituloModificar";
            lblTituloModificar.Size = new Size(220, 32);
            lblTituloModificar.TabIndex = 0;
            lblTituloModificar.Text = "Modificar Usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(138, 175);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(121, 23);
            txtContraseña.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(138, 116);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(121, 23);
            txtUsuario.TabIndex = 2;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Usuario" });
            cmbRol.Location = new Point(138, 230);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(121, 303);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 31);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(52, 119);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // lblConstraseña
            // 
            lblConstraseña.AutoSize = true;
            lblConstraseña.Location = new Point(52, 178);
            lblConstraseña.Name = "lblConstraseña";
            lblConstraseña.Size = new Size(67, 15);
            lblConstraseña.TabIndex = 7;
            lblConstraseña.Text = "Contraseña";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(52, 233);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(24, 15);
            lblRol.TabIndex = 8;
            lblRol.Text = "Rol";
            // 
            // ModificarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 401);
            Controls.Add(lblRol);
            Controls.Add(lblConstraseña);
            Controls.Add(lblUsuario);
            Controls.Add(btnGuardar);
            Controls.Add(cmbRol);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(lblTituloModificar);
            Name = "ModificarUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar usuarios";
            Load += ModificarUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloModificar;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private ComboBox cmbRol;
        private Button btnGuardar;
        private Label lblUsuario;
        private Label lblConstraseña;
        private Label lblRol;
    }
}