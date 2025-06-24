namespace TP_1
{
    partial class ResetearContraseña
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
            lblContraseña = new Label();
            lblConfirmacion = new Label();
            txtContraseña = new TextBox();
            txtConfirmacion = new TextBox();
            btnNuevaContraseña = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(43, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(291, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingrese su nueva contraseña";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(43, 107);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Location = new Point(43, 149);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(122, 15);
            lblConfirmacion.TabIndex = 2;
            lblConfirmacion.Text = "Confirmar contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(204, 99);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(130, 23);
            txtContraseña.TabIndex = 3;
            // 
            // txtConfirmacion
            // 
            txtConfirmacion.Location = new Point(204, 153);
            txtConfirmacion.Name = "txtConfirmacion";
            txtConfirmacion.Size = new Size(130, 23);
            txtConfirmacion.TabIndex = 4;
            // 
            // btnNuevaContraseña
            // 
            btnNuevaContraseña.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNuevaContraseña.Location = new Point(100, 219);
            btnNuevaContraseña.Name = "btnNuevaContraseña";
            btnNuevaContraseña.Size = new Size(164, 32);
            btnNuevaContraseña.TabIndex = 5;
            btnNuevaContraseña.Text = "Nueva contraseña";
            btnNuevaContraseña.UseVisualStyleBackColor = true;
            btnNuevaContraseña.Click += btnNuevaContraseña_Click;
            // 
            // ResetearContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 309);
            Controls.Add(btnNuevaContraseña);
            Controls.Add(txtConfirmacion);
            Controls.Add(txtContraseña);
            Controls.Add(lblConfirmacion);
            Controls.Add(lblContraseña);
            Controls.Add(lblTitulo);
            Name = "ResetearContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resetear contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblContraseña;
        private Label lblConfirmacion;
        private TextBox txtContraseña;
        private TextBox txtConfirmacion;
        private Button btnNuevaContraseña;
    }
}