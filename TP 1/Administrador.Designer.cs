namespace TP_1
{
    partial class Administrador
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
            btnCerrarSesion = new Button();
            lblTituloAdm = new Label();
            btnRegistrarUsuario = new Button();
            btnModificarUsuario = new Button();
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(52, 322);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(301, 48);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblTituloAdm
            // 
            lblTituloAdm.AutoSize = true;
            lblTituloAdm.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAdm.Location = new Point(266, 59);
            lblTituloAdm.Name = "lblTituloAdm";
            lblTituloAdm.Size = new Size(389, 32);
            lblTituloAdm.TabIndex = 1;
            lblTituloAdm.Text = "Panel General Del Administrador";
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Location = new Point(52, 129);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(301, 48);
            btnRegistrarUsuario.TabIndex = 2;
            btnRegistrarUsuario.Text = "Registrar Usuario";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            btnRegistrarUsuario.Click += button2_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(52, 226);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(301, 48);
            btnModificarUsuario.TabIndex = 3;
            btnModificarUsuario.Text = "Modificar Usuario";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(380, 128);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(487, 327);
            dgvUsuarios.TabIndex = 4;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 494);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnModificarUsuario);
            Controls.Add(btnRegistrarUsuario);
            Controls.Add(lblTituloAdm);
            Controls.Add(btnCerrarSesion);
            Name = "Administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnCerrarSesion;
        private Label lblTituloAdm;
        private Button btnRegistrarUsuario;
        private Button btnModificarUsuario;
        private DataGridView dgvUsuarios;
    }
}