namespace Omega
{
    partial class Resta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resta));
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.opcionUno = new System.Windows.Forms.PictureBox();
            this.opcionDos = new System.Windows.Forms.PictureBox();
            this.opcionTres = new System.Windows.Forms.PictureBox();
            this.numeroUno = new System.Windows.Forms.PictureBox();
            this.numeroDos = new System.Windows.Forms.PictureBox();
            this.respuestaCorrecta = new System.Windows.Forms.PictureBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.opcionUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaCorrecta)).BeginInit();
            this.SuspendLayout();
            // 
            // tiempo
            // 
            this.tiempo.Interval = 1000;
            // 
            // opcionUno
            // 
            this.opcionUno.BackColor = System.Drawing.Color.Transparent;
            this.opcionUno.Location = new System.Drawing.Point(179, 358);
            this.opcionUno.Margin = new System.Windows.Forms.Padding(2);
            this.opcionUno.Name = "opcionUno";
            this.opcionUno.Size = new System.Drawing.Size(130, 127);
            this.opcionUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opcionUno.TabIndex = 12;
            this.opcionUno.TabStop = false;
            this.opcionUno.Click += new System.EventHandler(this.opcionUno_Click);
            // 
            // opcionDos
            // 
            this.opcionDos.BackColor = System.Drawing.Color.Transparent;
            this.opcionDos.Location = new System.Drawing.Point(329, 358);
            this.opcionDos.Margin = new System.Windows.Forms.Padding(2);
            this.opcionDos.Name = "opcionDos";
            this.opcionDos.Size = new System.Drawing.Size(130, 127);
            this.opcionDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opcionDos.TabIndex = 13;
            this.opcionDos.TabStop = false;
            this.opcionDos.Click += new System.EventHandler(this.opcionDos_Click);
            // 
            // opcionTres
            // 
            this.opcionTres.BackColor = System.Drawing.Color.Transparent;
            this.opcionTres.Location = new System.Drawing.Point(482, 358);
            this.opcionTres.Margin = new System.Windows.Forms.Padding(2);
            this.opcionTres.Name = "opcionTres";
            this.opcionTres.Size = new System.Drawing.Size(130, 127);
            this.opcionTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opcionTres.TabIndex = 14;
            this.opcionTres.TabStop = false;
            this.opcionTres.Click += new System.EventHandler(this.opcionTres_Click);
            // 
            // numeroUno
            // 
            this.numeroUno.BackColor = System.Drawing.Color.Transparent;
            this.numeroUno.Location = new System.Drawing.Point(95, 141);
            this.numeroUno.Margin = new System.Windows.Forms.Padding(2);
            this.numeroUno.Name = "numeroUno";
            this.numeroUno.Size = new System.Drawing.Size(130, 127);
            this.numeroUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.numeroUno.TabIndex = 15;
            this.numeroUno.TabStop = false;
            // 
            // numeroDos
            // 
            this.numeroDos.BackColor = System.Drawing.Color.Transparent;
            this.numeroDos.Location = new System.Drawing.Point(324, 141);
            this.numeroDos.Margin = new System.Windows.Forms.Padding(2);
            this.numeroDos.Name = "numeroDos";
            this.numeroDos.Size = new System.Drawing.Size(130, 127);
            this.numeroDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.numeroDos.TabIndex = 16;
            this.numeroDos.TabStop = false;
            // 
            // respuestaCorrecta
            // 
            this.respuestaCorrecta.BackColor = System.Drawing.Color.Transparent;
            this.respuestaCorrecta.Location = new System.Drawing.Point(562, 141);
            this.respuestaCorrecta.Margin = new System.Windows.Forms.Padding(2);
            this.respuestaCorrecta.Name = "respuestaCorrecta";
            this.respuestaCorrecta.Size = new System.Drawing.Size(130, 127);
            this.respuestaCorrecta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.respuestaCorrecta.TabIndex = 17;
            this.respuestaCorrecta.TabStop = false;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPuntaje.Location = new System.Drawing.Point(732, 30);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(20, 24);
            this.lblPuntaje.TabIndex = 18;
            this.lblPuntaje.Text = "0";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 79);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSalir_Paint);
            // 
            // Resta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.respuestaCorrecta);
            this.Controls.Add(this.numeroDos);
            this.Controls.Add(this.numeroUno);
            this.Controls.Add(this.opcionTres);
            this.Controls.Add(this.opcionDos);
            this.Controls.Add(this.opcionUno);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Resta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resta";
            this.Load += new System.EventHandler(this.Resta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opcionUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaCorrecta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.PictureBox opcionUno;
        private System.Windows.Forms.PictureBox opcionDos;
        private System.Windows.Forms.PictureBox opcionTres;
        private System.Windows.Forms.PictureBox numeroUno;
        private System.Windows.Forms.PictureBox numeroDos;
        private System.Windows.Forms.PictureBox respuestaCorrecta;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Panel btnSalir;
    }
}