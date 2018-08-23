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
            System.Windows.Forms.PictureBox pictureBox2;
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.PictureBox btnNumeros;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_principal));
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnNumeros = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImage = global::Omega.Properties.Resources.verified;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox2.Location = new System.Drawing.Point(495, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(200, 200);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = global::Omega.Properties.Resources.verified;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Location = new System.Drawing.Point(278, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(200, 200);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnNumeros
            // 
            btnNumeros.BackColor = System.Drawing.Color.Transparent;
            btnNumeros.BackgroundImage = global::Omega.Properties.Resources.af97c0a93bf8d556333e5e942cf8dec0;
            btnNumeros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnNumeros.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNumeros.Location = new System.Drawing.Point(62, 70);
            btnNumeros.Name = "btnNumeros";
            btnNumeros.Size = new System.Drawing.Size(200, 200);
            btnNumeros.TabIndex = 4;
            btnNumeros.TabStop = false;
            // 
            // Pantalla_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 327);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(btnNumeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pantalla_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla_principal";
            this.Load += new System.EventHandler(this.Pantalla_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnNumeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}