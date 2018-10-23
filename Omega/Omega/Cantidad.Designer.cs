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
            this.opcionUno = new System.Windows.Forms.Panel();
            this.opcionDos = new System.Windows.Forms.Panel();
            this.opcionTres = new System.Windows.Forms.Panel();
            this.lblP = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // opcionUno
            // 
            this.opcionUno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcionUno.Location = new System.Drawing.Point(24, 308);
            this.opcionUno.Name = "opcionUno";
            this.opcionUno.Size = new System.Drawing.Size(147, 127);
            this.opcionUno.TabIndex = 3;
            this.opcionUno.Click += new System.EventHandler(this.opcionUno_Click_1);
            // 
            // opcionDos
            // 
            this.opcionDos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcionDos.Location = new System.Drawing.Point(202, 308);
            this.opcionDos.Name = "opcionDos";
            this.opcionDos.Size = new System.Drawing.Size(147, 127);
            this.opcionDos.TabIndex = 4;
            this.opcionDos.Click += new System.EventHandler(this.opcionDos_Click_1);
            // 
            // opcionTres
            // 
            this.opcionTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcionTres.Location = new System.Drawing.Point(386, 308);
            this.opcionTres.Name = "opcionTres";
            this.opcionTres.Size = new System.Drawing.Size(147, 127);
            this.opcionTres.TabIndex = 4;
            this.opcionTres.Click += new System.EventHandler(this.opcionTres_Click_1);
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(627, 36);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(46, 13);
            this.lblP.TabIndex = 21;
            this.lblP.Text = "Puntaje:";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(641, 102);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(13, 13);
            this.lblPuntaje.TabIndex = 20;
            this.lblPuntaje.Text = "0";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(617, 379);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 56);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Cantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 453);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.opcionTres);
            this.Controls.Add(this.opcionDos);
            this.Controls.Add(this.opcionUno);
            this.Name = "Cantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantidad";
            this.Load += new System.EventHandler(this.Cantidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel opcionUno;
        private System.Windows.Forms.Panel opcionDos;
        private System.Windows.Forms.Panel opcionTres;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Panel btnSalir;
    }
}