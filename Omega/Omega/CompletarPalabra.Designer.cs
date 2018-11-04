namespace Omega
{
    partial class CompletarPalabra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.opcionUno = new System.Windows.Forms.Panel();
            this.opcionDos = new System.Windows.Forms.Panel();
            this.opcionTres = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(312, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 224);
            this.panel1.TabIndex = 1;
            // 
            // opcionUno
            // 
            this.opcionUno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcionUno.Location = new System.Drawing.Point(12, 472);
            this.opcionUno.Name = "opcionUno";
            this.opcionUno.Size = new System.Drawing.Size(221, 215);
            this.opcionUno.TabIndex = 2;
            this.opcionUno.Click += new System.EventHandler(this.opcionUno_Click);
            // 
            // opcionDos
            // 
            this.opcionDos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcionDos.Location = new System.Drawing.Point(317, 472);
            this.opcionDos.Name = "opcionDos";
            this.opcionDos.Size = new System.Drawing.Size(221, 215);
            this.opcionDos.TabIndex = 3;
            this.opcionDos.Click += new System.EventHandler(this.opcionDos_Click);
            // 
            // opcionTres
            // 
            this.opcionTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcionTres.Location = new System.Drawing.Point(619, 472);
            this.opcionTres.Name = "opcionTres";
            this.opcionTres.Size = new System.Drawing.Size(221, 215);
            this.opcionTres.TabIndex = 3;
            this.opcionTres.Click += new System.EventHandler(this.opcionTres_Click);
            // 
            // CompletarPalabra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 699);
            this.Controls.Add(this.opcionTres);
            this.Controls.Add(this.opcionDos);
            this.Controls.Add(this.opcionUno);
            this.Controls.Add(this.panel1);
            this.Name = "CompletarPalabra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompletarPalabra";
            this.Load += new System.EventHandler(this.CompletarPalabra_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel opcionUno;
        private System.Windows.Forms.Panel opcionDos;
        private System.Windows.Forms.Panel opcionTres;
    }
}