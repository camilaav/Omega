namespace Omega
{
    partial class Cantidad
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
            this.opcionUno = new System.Windows.Forms.PictureBox();
            this.opcionDos = new System.Windows.Forms.PictureBox();
            this.opcionTres = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.opcionUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionTres)).BeginInit();
            this.SuspendLayout();
            // 
            // opcionUno
            // 
            this.opcionUno.Location = new System.Drawing.Point(22, 308);
            this.opcionUno.Name = "opcionUno";
            this.opcionUno.Size = new System.Drawing.Size(147, 127);
            this.opcionUno.TabIndex = 0;
            this.opcionUno.TabStop = false;
            // 
            // opcionDos
            // 
            this.opcionDos.Location = new System.Drawing.Point(192, 308);
            this.opcionDos.Name = "opcionDos";
            this.opcionDos.Size = new System.Drawing.Size(147, 127);
            this.opcionDos.TabIndex = 1;
            this.opcionDos.TabStop = false;
            // 
            // opcionTres
            // 
            this.opcionTres.Location = new System.Drawing.Point(359, 308);
            this.opcionTres.Name = "opcionTres";
            this.opcionTres.Size = new System.Drawing.Size(147, 127);
            this.opcionTres.TabIndex = 2;
            this.opcionTres.TabStop = false;
            // 
            // Cantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.opcionTres);
            this.Controls.Add(this.opcionDos);
            this.Controls.Add(this.opcionUno);
            this.Name = "Cantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantidad";
            this.Load += new System.EventHandler(this.Cantidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opcionUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionTres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox opcionUno;
        private System.Windows.Forms.PictureBox opcionDos;
        private System.Windows.Forms.PictureBox opcionTres;
    }
}