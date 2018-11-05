namespace Omega
{
    partial class Letras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Letras));
            this.btnSopa = new System.Windows.Forms.PictureBox();
            this.btnCompletas = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSopa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSopa
            // 
            this.btnSopa.BackColor = System.Drawing.Color.Transparent;
            this.btnSopa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSopa.BackgroundImage")));
            this.btnSopa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSopa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSopa.Location = new System.Drawing.Point(234, 306);
            this.btnSopa.Name = "btnSopa";
            this.btnSopa.Size = new System.Drawing.Size(332, 100);
            this.btnSopa.TabIndex = 3;
            this.btnSopa.TabStop = false;
            this.btnSopa.Click += new System.EventHandler(this.btnSopa_Click);
            // 
            // btnCompletas
            // 
            this.btnCompletas.BackColor = System.Drawing.Color.Transparent;
            this.btnCompletas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompletas.BackgroundImage")));
            this.btnCompletas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompletas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompletas.Location = new System.Drawing.Point(234, 168);
            this.btnCompletas.Name = "btnCompletas";
            this.btnCompletas.Size = new System.Drawing.Size(332, 100);
            this.btnCompletas.TabIndex = 2;
            this.btnCompletas.TabStop = false;
            this.btnCompletas.Click += new System.EventHandler(this.btnCompletas_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 69);
            this.pictureBox4.TabIndex = 61;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Letras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnSopa);
            this.Controls.Add(this.btnCompletas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Letras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letras";
            ((System.ComponentModel.ISupportInitialize)(this.btnSopa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSopa;
        private System.Windows.Forms.PictureBox btnCompletas;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}