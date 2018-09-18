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
            ((System.ComponentModel.ISupportInitialize)(this.btnSopa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompletas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSopa
            // 
            this.btnSopa.Location = new System.Drawing.Point(233, 12);
            this.btnSopa.Name = "btnSopa";
            this.btnSopa.Size = new System.Drawing.Size(177, 175);
            this.btnSopa.TabIndex = 3;
            this.btnSopa.TabStop = false;
            this.btnSopa.Click += new System.EventHandler(this.btnSopa_Click);
            // 
            // btnCompletas
            // 
            this.btnCompletas.Location = new System.Drawing.Point(50, 12);
            this.btnCompletas.Name = "btnCompletas";
            this.btnCompletas.Size = new System.Drawing.Size(177, 175);
            this.btnCompletas.TabIndex = 2;
            this.btnCompletas.TabStop = false;
            this.btnCompletas.Click += new System.EventHandler(this.btnCompletas_Click);
            // 
            // Letras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(477, 275);
            this.Controls.Add(this.btnSopa);
            this.Controls.Add(this.btnCompletas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Letras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letras";
            ((System.ComponentModel.ISupportInitialize)(this.btnSopa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCompletas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSopa;
        private System.Windows.Forms.PictureBox btnCompletas;
    }
}