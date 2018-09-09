namespace Omega
{
    partial class Pantalla_principal
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
            System.Windows.Forms.PictureBox btnEntretenimiento;
            System.Windows.Forms.PictureBox btnLetras;
            System.Windows.Forms.PictureBox btnNumeros;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_principal));
            btnEntretenimiento = new System.Windows.Forms.PictureBox();
            btnLetras = new System.Windows.Forms.PictureBox();
            btnNumeros = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnEntretenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntretenimiento
            // 
            btnEntretenimiento.BackColor = System.Drawing.Color.Transparent;
            btnEntretenimiento.BackgroundImage = global::Omega.Properties.Resources.Aceptar;
            btnEntretenimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnEntretenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEntretenimiento.Location = new System.Drawing.Point(495, 70);
            btnEntretenimiento.Name = "btnEntretenimiento";
            btnEntretenimiento.Size = new System.Drawing.Size(200, 200);
            btnEntretenimiento.TabIndex = 6;
            btnEntretenimiento.TabStop = false;
            btnEntretenimiento.Click += new System.EventHandler(this.btnEntretenimiento_Click);
            // 
            // btnLetras
            // 
            btnLetras.BackColor = System.Drawing.Color.Transparent;
            btnLetras.BackgroundImage = global::Omega.Properties.Resources.LetrasNiños;
            btnLetras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnLetras.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLetras.Location = new System.Drawing.Point(278, 70);
            btnLetras.Name = "btnLetras";
            btnLetras.Size = new System.Drawing.Size(200, 200);
            btnLetras.TabIndex = 5;
            btnLetras.TabStop = false;
            btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // btnNumeros
            // 
            btnNumeros.BackColor = System.Drawing.Color.Transparent;
            btnNumeros.BackgroundImage = global::Omega.Properties.Resources.Numeros;
            btnNumeros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnNumeros.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNumeros.Location = new System.Drawing.Point(62, 70);
            btnNumeros.Name = "btnNumeros";
            btnNumeros.Size = new System.Drawing.Size(200, 200);
            btnNumeros.TabIndex = 4;
            btnNumeros.TabStop = false;
            btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // Pantalla_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(761, 327);
            this.Controls.Add(btnEntretenimiento);
            this.Controls.Add(btnLetras);
            this.Controls.Add(btnNumeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pantalla_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Pantalla_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(btnEntretenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnNumeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}