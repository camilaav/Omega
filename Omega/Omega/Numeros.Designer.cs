namespace Omega
{
    partial class Numeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numeros));
            this.btnSuma = new System.Windows.Forms.PictureBox();
            this.btnResta = new System.Windows.Forms.PictureBox();
            this.btnCantidad = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSuma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.Transparent;
            this.btnSuma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuma.BackgroundImage")));
            this.btnSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuma.Location = new System.Drawing.Point(39, 170);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(205, 235);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.TabStop = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.Transparent;
            this.btnResta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResta.BackgroundImage")));
            this.btnResta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResta.Location = new System.Drawing.Point(291, 170);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(205, 235);
            this.btnResta.TabIndex = 1;
            this.btnResta.TabStop = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnCantidad
            // 
            this.btnCantidad.BackColor = System.Drawing.Color.Transparent;
            this.btnCantidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCantidad.BackgroundImage")));
            this.btnCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCantidad.Location = new System.Drawing.Point(535, 170);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(205, 235);
            this.btnCantidad.TabIndex = 2;
            this.btnCantidad.TabStop = false;
            this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(0, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 69);
            this.pictureBox4.TabIndex = 60;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Numeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnCantidad);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Numeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numeros";
            ((System.ComponentModel.ISupportInitialize)(this.btnSuma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSuma;
        private System.Windows.Forms.PictureBox btnResta;
        private System.Windows.Forms.PictureBox btnCantidad;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}