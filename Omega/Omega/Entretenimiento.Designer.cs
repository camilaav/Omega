namespace Omega
{
    partial class Entretenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entretenimiento));
            this.btnColorear = new System.Windows.Forms.PictureBox();
            this.btnMemotest = new System.Windows.Forms.PictureBox();
            this.btnRompecabezas = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMemotest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRompecabezas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColorear
            // 
            this.btnColorear.BackColor = System.Drawing.Color.Transparent;
            this.btnColorear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColorear.BackgroundImage")));
            this.btnColorear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColorear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorear.Location = new System.Drawing.Point(228, 418);
            this.btnColorear.Name = "btnColorear";
            this.btnColorear.Size = new System.Drawing.Size(332, 100);
            this.btnColorear.TabIndex = 5;
            this.btnColorear.TabStop = false;
            this.btnColorear.Click += new System.EventHandler(this.btnColorear_Click);
            // 
            // btnMemotest
            // 
            this.btnMemotest.BackColor = System.Drawing.Color.Transparent;
            this.btnMemotest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMemotest.BackgroundImage")));
            this.btnMemotest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMemotest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMemotest.Location = new System.Drawing.Point(228, 275);
            this.btnMemotest.Name = "btnMemotest";
            this.btnMemotest.Size = new System.Drawing.Size(332, 100);
            this.btnMemotest.TabIndex = 4;
            this.btnMemotest.TabStop = false;
            this.btnMemotest.Click += new System.EventHandler(this.btnMemotest_Click);
            // 
            // btnRompecabezas
            // 
            this.btnRompecabezas.BackColor = System.Drawing.Color.Transparent;
            this.btnRompecabezas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRompecabezas.BackgroundImage")));
            this.btnRompecabezas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRompecabezas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRompecabezas.Location = new System.Drawing.Point(228, 129);
            this.btnRompecabezas.Name = "btnRompecabezas";
            this.btnRompecabezas.Size = new System.Drawing.Size(332, 100);
            this.btnRompecabezas.TabIndex = 3;
            this.btnRompecabezas.TabStop = false;
            this.btnRompecabezas.Click += new System.EventHandler(this.btnRompecabezas_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(1, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 69);
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Entretenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnColorear);
            this.Controls.Add(this.btnMemotest);
            this.Controls.Add(this.btnRompecabezas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entretenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entretenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.btnColorear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMemotest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRompecabezas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnColorear;
        private System.Windows.Forms.PictureBox btnMemotest;
        private System.Windows.Forms.PictureBox btnRompecabezas;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}