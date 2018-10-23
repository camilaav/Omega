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
            ((System.ComponentModel.ISupportInitialize)(this.btnColorear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMemotest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRompecabezas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColorear
            // 
            this.btnColorear.BackColor = System.Drawing.Color.DarkGray;
            this.btnColorear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorear.Location = new System.Drawing.Point(378, 12);
            this.btnColorear.Name = "btnColorear";
            this.btnColorear.Size = new System.Drawing.Size(177, 175);
            this.btnColorear.TabIndex = 5;
            this.btnColorear.TabStop = false;
            this.btnColorear.Click += new System.EventHandler(this.btnColorear_Click);
            // 
            // btnMemotest
            // 
            this.btnMemotest.BackColor = System.Drawing.Color.DarkGray;
            this.btnMemotest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMemotest.Location = new System.Drawing.Point(195, 12);
            this.btnMemotest.Name = "btnMemotest";
            this.btnMemotest.Size = new System.Drawing.Size(177, 175);
            this.btnMemotest.TabIndex = 4;
            this.btnMemotest.TabStop = false;
            this.btnMemotest.Click += new System.EventHandler(this.btnMemotest_Click);
            // 
            // btnRompecabezas
            // 
            this.btnRompecabezas.BackColor = System.Drawing.Color.DarkGray;
            this.btnRompecabezas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRompecabezas.Location = new System.Drawing.Point(12, 12);
            this.btnRompecabezas.Name = "btnRompecabezas";
            this.btnRompecabezas.Size = new System.Drawing.Size(177, 175);
            this.btnRompecabezas.TabIndex = 3;
            this.btnRompecabezas.TabStop = false;
            this.btnRompecabezas.Click += new System.EventHandler(this.btnRompecabezas_Click);
            // 
            // Entretenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(585, 291);
            this.Controls.Add(this.btnColorear);
            this.Controls.Add(this.btnMemotest);
            this.Controls.Add(this.btnRompecabezas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entretenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entretenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.btnColorear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMemotest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRompecabezas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnColorear;
        private System.Windows.Forms.PictureBox btnMemotest;
        private System.Windows.Forms.PictureBox btnRompecabezas;
    }
}