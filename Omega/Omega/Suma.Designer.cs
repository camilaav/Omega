namespace Omega
{
    partial class Suma
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
            this.components = new System.ComponentModel.Container();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblMas = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.lblOp1 = new System.Windows.Forms.Label();
            this.lblOp2 = new System.Windows.Forms.Label();
            this.lblOp3 = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(39, 85);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(35, 13);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "label1";
            // 
            // lblMas
            // 
            this.lblMas.AutoSize = true;
            this.lblMas.Location = new System.Drawing.Point(128, 85);
            this.lblMas.Name = "lblMas";
            this.lblMas.Size = new System.Drawing.Size(13, 13);
            this.lblMas.TabIndex = 1;
            this.lblMas.Text = "+";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(209, 85);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(35, 13);
            this.lblNumero2.TabIndex = 2;
            this.lblNumero2.Text = "label3";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(288, 85);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(13, 13);
            this.lblIgual.TabIndex = 3;
            this.lblIgual.Text = "=";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(363, 85);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(35, 13);
            this.lblRespuesta.TabIndex = 4;
            this.lblRespuesta.Text = "label5";
            // 
            // lblOp1
            // 
            this.lblOp1.AutoSize = true;
            this.lblOp1.Location = new System.Drawing.Point(578, 40);
            this.lblOp1.Name = "lblOp1";
            this.lblOp1.Size = new System.Drawing.Size(35, 13);
            this.lblOp1.TabIndex = 5;
            this.lblOp1.Text = "label6";
            this.lblOp1.Click += new System.EventHandler(this.LblOp1_Click);
            // 
            // lblOp2
            // 
            this.lblOp2.AutoSize = true;
            this.lblOp2.Location = new System.Drawing.Point(578, 147);
            this.lblOp2.Name = "lblOp2";
            this.lblOp2.Size = new System.Drawing.Size(35, 13);
            this.lblOp2.TabIndex = 6;
            this.lblOp2.Text = "label7";
            this.lblOp2.Click += new System.EventHandler(this.LblOp2_Click);
            // 
            // lblOp3
            // 
            this.lblOp3.AutoSize = true;
            this.lblOp3.Location = new System.Drawing.Point(578, 245);
            this.lblOp3.Name = "lblOp3";
            this.lblOp3.Size = new System.Drawing.Size(35, 13);
            this.lblOp3.TabIndex = 7;
            this.lblOp3.Text = "label8";
            this.lblOp3.Click += new System.EventHandler(this.LblOp3_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(231, 290);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(13, 13);
            this.lblPuntaje.TabIndex = 8;
            this.lblPuntaje.Text = "0";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(39, 290);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(46, 13);
            this.lblP.TabIndex = 9;
            this.lblP.Text = "Puntaje:";
            // 
            // tiempo
            // 
            this.tiempo.Interval = 1000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblOp3);
            this.Controls.Add(this.lblOp2);
            this.Controls.Add(this.lblOp1);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblMas);
            this.Controls.Add(this.lblNumero1);
            this.Name = "Suma";
            this.Text = "Suma";
            this.Load += new System.EventHandler(this.Suma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblMas;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label lblOp1;
        private System.Windows.Forms.Label lblOp2;
        private System.Windows.Forms.Label lblOp3;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Timer tiempo;
    }
}