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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_principal));
            System.Windows.Forms.PictureBox btnLetras;
            System.Windows.Forms.PictureBox btnNumeros;
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            btnEntretenimiento = new System.Windows.Forms.PictureBox();
            btnLetras = new System.Windows.Forms.PictureBox();
            btnNumeros = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnEntretenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntretenimiento
            // 
            btnEntretenimiento.BackColor = System.Drawing.Color.Transparent;
            btnEntretenimiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntretenimiento.BackgroundImage")));
            btnEntretenimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnEntretenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEntretenimiento.Location = new System.Drawing.Point(223, 422);
            btnEntretenimiento.Name = "btnEntretenimiento";
            btnEntretenimiento.Size = new System.Drawing.Size(332, 100);
            btnEntretenimiento.TabIndex = 6;
            btnEntretenimiento.TabStop = false;
            btnEntretenimiento.Click += new System.EventHandler(this.btnEntretenimiento_Click);
            // 
            // btnLetras
            // 
            btnLetras.BackColor = System.Drawing.Color.Transparent;
            btnLetras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetras.BackgroundImage")));
            btnLetras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnLetras.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLetras.Location = new System.Drawing.Point(223, 274);
            btnLetras.Name = "btnLetras";
            btnLetras.Size = new System.Drawing.Size(332, 100);
            btnLetras.TabIndex = 5;
            btnLetras.TabStop = false;
            btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // btnNumeros
            // 
            btnNumeros.BackColor = System.Drawing.Color.Transparent;
            btnNumeros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNumeros.BackgroundImage")));
            btnNumeros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnNumeros.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNumeros.Location = new System.Drawing.Point(223, 129);
            btnNumeros.Name = "btnNumeros";
            btnNumeros.Size = new System.Drawing.Size(332, 100);
            btnNumeros.TabIndex = 4;
            btnNumeros.TabStop = false;
            btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(0, -2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 69);
            this.pictureBox4.TabIndex = 60;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Pantalla_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(btnEntretenimiento);
            this.Controls.Add(btnLetras);
            this.Controls.Add(btnNumeros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pantalla_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Pantalla_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(btnEntretenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
    }
}