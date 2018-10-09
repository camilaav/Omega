namespace Omega
{
    partial class ModificacionUsuarios
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
            System.Windows.Forms.PictureBox btnIngresar;
            System.Windows.Forms.PictureBox btnRegresar;
            this.contraseñaNueva = new System.Windows.Forms.Label();
            this.contraseñaVieja = new System.Windows.Forms.Label();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.txtContraseñaVieja = new System.Windows.Forms.TextBox();
            btnIngresar = new System.Windows.Forms.PictureBox();
            btnRegresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = System.Drawing.Color.Transparent;
            btnIngresar.BackgroundImage = global::Omega.Properties.Resources.Check;
            btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnIngresar.Location = new System.Drawing.Point(169, 64);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(50, 50);
            btnIngresar.TabIndex = 7;
            btnIngresar.TabStop = false;
            btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = System.Drawing.Color.Transparent;
            btnRegresar.BackgroundImage = global::Omega.Properties.Resources.Salir;
            btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegresar.Location = new System.Drawing.Point(225, 64);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new System.Drawing.Size(50, 50);
            btnRegresar.TabIndex = 8;
            btnRegresar.TabStop = false;
            btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // contraseñaNueva
            // 
            this.contraseñaNueva.AutoSize = true;
            this.contraseñaNueva.Location = new System.Drawing.Point(14, 41);
            this.contraseñaNueva.Name = "contraseñaNueva";
            this.contraseñaNueva.Size = new System.Drawing.Size(94, 13);
            this.contraseñaNueva.TabIndex = 12;
            this.contraseñaNueva.Text = "Contraseña nueva";
            // 
            // contraseñaVieja
            // 
            this.contraseñaVieja.AutoSize = true;
            this.contraseñaVieja.Location = new System.Drawing.Point(14, 15);
            this.contraseñaVieja.Name = "contraseñaVieja";
            this.contraseñaVieja.Size = new System.Drawing.Size(86, 13);
            this.contraseñaVieja.TabIndex = 11;
            this.contraseñaVieja.Text = "Contraseña vieja";
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.Location = new System.Drawing.Point(121, 38);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.Size = new System.Drawing.Size(153, 20);
            this.txtContraseñaNueva.TabIndex = 10;
            // 
            // txtContraseñaVieja
            // 
            this.txtContraseñaVieja.Location = new System.Drawing.Point(121, 12);
            this.txtContraseñaVieja.Name = "txtContraseñaVieja";
            this.txtContraseñaVieja.Size = new System.Drawing.Size(153, 20);
            this.txtContraseñaVieja.TabIndex = 9;
            // 
            // ModificacionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.contraseñaNueva);
            this.Controls.Add(this.contraseñaVieja);
            this.Controls.Add(this.txtContraseñaNueva);
            this.Controls.Add(this.txtContraseñaVieja);
            this.Controls.Add(btnRegresar);
            this.Controls.Add(btnIngresar);
            this.Name = "ModificacionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificacionUsuarios";
            ((System.ComponentModel.ISupportInitialize)(btnIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contraseñaNueva;
        private System.Windows.Forms.Label contraseñaVieja;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.TextBox txtContraseñaVieja;
    }
}