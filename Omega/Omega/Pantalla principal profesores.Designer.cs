namespace Omega
{
    partial class Pantalla_principal_profesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_principal_profesores));
            this.picAlta = new System.Windows.Forms.PictureBox();
            this.picBorrar = new System.Windows.Forms.PictureBox();
            this.picModificar = new System.Windows.Forms.PictureBox();
            this.picTabla = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picAlta
            // 
            this.picAlta.BackColor = System.Drawing.Color.Transparent;
            this.picAlta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAlta.BackgroundImage")));
            this.picAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAlta.Location = new System.Drawing.Point(0, 140);
            this.picAlta.Name = "picAlta";
            this.picAlta.Size = new System.Drawing.Size(60, 64);
            this.picAlta.TabIndex = 1;
            this.picAlta.TabStop = false;
            this.picAlta.Click += new System.EventHandler(this.picAlta_Click);
            // 
            // picBorrar
            // 
            this.picBorrar.BackColor = System.Drawing.Color.Transparent;
            this.picBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBorrar.BackgroundImage")));
            this.picBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBorrar.Location = new System.Drawing.Point(0, 205);
            this.picBorrar.Name = "picBorrar";
            this.picBorrar.Size = new System.Drawing.Size(60, 64);
            this.picBorrar.TabIndex = 2;
            this.picBorrar.TabStop = false;
            this.picBorrar.Click += new System.EventHandler(this.picBorrar_Click);
            // 
            // picModificar
            // 
            this.picModificar.BackColor = System.Drawing.Color.Transparent;
            this.picModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picModificar.BackgroundImage")));
            this.picModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picModificar.Location = new System.Drawing.Point(0, 270);
            this.picModificar.Name = "picModificar";
            this.picModificar.Size = new System.Drawing.Size(60, 64);
            this.picModificar.TabIndex = 3;
            this.picModificar.TabStop = false;
            this.picModificar.Click += new System.EventHandler(this.picModificar_Click);
            // 
            // picTabla
            // 
            this.picTabla.BackColor = System.Drawing.Color.Transparent;
            this.picTabla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTabla.BackgroundImage")));
            this.picTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTabla.Location = new System.Drawing.Point(0, 340);
            this.picTabla.Name = "picTabla";
            this.picTabla.Size = new System.Drawing.Size(60, 64);
            this.picTabla.TabIndex = 4;
            this.picTabla.TabStop = false;
            this.picTabla.Click += new System.EventHandler(this.picTabla_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(142, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 433);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 79);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pantalla_principal_profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 630);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picTabla);
            this.Controls.Add(this.picModificar);
            this.Controls.Add(this.picBorrar);
            this.Controls.Add(this.picAlta);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pantalla_principal_profesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla_principal_profesores";
            this.Load += new System.EventHandler(this.Pantalla_principal_profesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picAlta;
        private System.Windows.Forms.PictureBox picBorrar;
        private System.Windows.Forms.PictureBox picModificar;
        private System.Windows.Forms.PictureBox picTabla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}