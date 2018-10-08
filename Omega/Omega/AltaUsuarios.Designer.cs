namespace Omega
{
    partial class AltaUsuarios
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
            System.Windows.Forms.PictureBox btnRegresar;
            System.Windows.Forms.PictureBox btnAceptar;
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            btnRegresar = new System.Windows.Forms.PictureBox();
            btnAceptar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = System.Drawing.Color.Transparent;
            btnRegresar.BackgroundImage = global::Omega.Properties.Resources.Salir;
            btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegresar.Location = new System.Drawing.Point(222, 78);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new System.Drawing.Size(50, 50);
            btnRegresar.TabIndex = 6;
            btnRegresar.TabStop = false;
            btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = System.Drawing.Color.Transparent;
            btnAceptar.BackgroundImage = global::Omega.Properties.Resources.Check;
            btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAceptar.Location = new System.Drawing.Point(166, 78);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(50, 50);
            btnAceptar.TabIndex = 7;
            btnAceptar.TabStop = false;
            btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(119, 12);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(153, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(119, 38);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(153, 20);
            this.txtContraseña.TabIndex = 1;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(12, 15);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(12, 41);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Contraseña.TabIndex = 3;
            this.Contraseña.Text = "Contraseña";
            // 
            // AltaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(btnAceptar);
            this.Controls.Add(btnRegresar);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Name = "AltaUsuarios";
            this.Text = "AltaUsuarios";
            this.Load += new System.EventHandler(this.AltaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(btnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contraseña;
    }
}