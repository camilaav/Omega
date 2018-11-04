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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cantidad));
            this.opcionUno = new System.Windows.Forms.Panel();
            this.opcionDos = new System.Windows.Forms.Panel();
            this.opcionTres = new System.Windows.Forms.Panel();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // opcionUno
            // 
            this.opcionUno.BackColor = System.Drawing.Color.Transparent;
            this.opcionUno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcionUno.Location = new System.Drawing.Point(12, 523);
            this.opcionUno.Name = "opcionUno";
            this.opcionUno.Size = new System.Drawing.Size(147, 127);
            this.opcionUno.TabIndex = 3;
            this.opcionUno.Click += new System.EventHandler(this.opcionUno_Click_1);
            // 
            // opcionDos
            // 
            this.opcionDos.BackColor = System.Drawing.Color.Transparent;
            this.opcionDos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcionDos.Location = new System.Drawing.Point(313, 521);
            this.opcionDos.Name = "opcionDos";
            this.opcionDos.Size = new System.Drawing.Size(147, 127);
            this.opcionDos.TabIndex = 4;
            this.opcionDos.Click += new System.EventHandler(this.opcionDos_Click_1);
            this.opcionDos.Paint += new System.Windows.Forms.PaintEventHandler(this.opcionDos_Paint);
            // 
            // opcionTres
            // 
            this.opcionTres.BackColor = System.Drawing.Color.Transparent;
            this.opcionTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcionTres.Location = new System.Drawing.Point(591, 523);
            this.opcionTres.Name = "opcionTres";
            this.opcionTres.Size = new System.Drawing.Size(147, 127);
            this.opcionTres.TabIndex = 4;
            this.opcionTres.Click += new System.EventHandler(this.opcionTres_Click_1);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPuntaje.Location = new System.Drawing.Point(701, 33);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(20, 24);
            this.lblPuntaje.TabIndex = 20;
            this.lblPuntaje.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Omega.Properties.Resources.btvolver;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 69);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Cantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 660);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.opcionTres);
            this.Controls.Add(this.opcionDos);
            this.Controls.Add(this.opcionUno);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Panel panel1;
    }
}