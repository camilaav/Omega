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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suma));
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.numeroDos = new System.Windows.Forms.PictureBox();
            this.numeroUno = new System.Windows.Forms.PictureBox();
            this.opcionTres = new System.Windows.Forms.PictureBox();
            this.opcionDos = new System.Windows.Forms.PictureBox();
            this.opcionUno = new System.Windows.Forms.PictureBox();
            this.respuestaC = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numeroDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaC)).BeginInit();
            this.SuspendLayout();
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
            this.lblPuntaje.TabIndex = 8;
            this.lblPuntaje.Text = "0";
            // 
            // tiempo
            // 
            this.tiempo.Interval = 1000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // numeroDos
            // 
            this.numeroDos.BackColor = System.Drawing.Color.Transparent;
            this.numeroDos.Location = new System.Drawing.Point(324, 137);
            this.numeroDos.Margin = new System.Windows.Forms.Padding(2);
            this.numeroDos.Name = "numeroDos";
            this.numeroDos.Size = new System.Drawing.Size(130, 127);
            this.numeroDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.numeroDos.TabIndex = 26;
            this.numeroDos.TabStop = false;
            // 
            // numeroUno
            // 
            this.numeroUno.BackColor = System.Drawing.Color.Transparent;
            this.numeroUno.Location = new System.Drawing.Point(93, 137);
            this.numeroUno.Margin = new System.Windows.Forms.Padding(2);
            this.numeroUno.Name = "numeroUno";
            this.numeroUno.Size = new System.Drawing.Size(130, 127);
            this.numeroUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.numeroUno.TabIndex = 25;
            this.numeroUno.TabStop = false;
            // 
            // opcionTres
            // 
            this.opcionTres.BackColor = System.Drawing.Color.Transparent;
            this.opcionTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcionTres.Location = new System.Drawing.Point(482, 356);
            this.opcionTres.Margin = new System.Windows.Forms.Padding(2);
            this.opcionTres.Name = "opcionTres";
            this.opcionTres.Size = new System.Drawing.Size(130, 127);
            this.opcionTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opcionTres.TabIndex = 24;
            this.opcionTres.TabStop = false;
            this.opcionTres.Click += new System.EventHandler(this.opcionTres_Click);
            // 
            // opcionDos
            // 
            this.opcionDos.BackColor = System.Drawing.Color.Transparent;
            this.opcionDos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcionDos.Location = new System.Drawing.Point(331, 356);
            this.opcionDos.Margin = new System.Windows.Forms.Padding(2);
            this.opcionDos.Name = "opcionDos";
            this.opcionDos.Size = new System.Drawing.Size(130, 127);
            this.opcionDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opcionDos.TabIndex = 23;
            this.opcionDos.TabStop = false;
            this.opcionDos.Click += new System.EventHandler(this.opcionDos_Click);
            // 
            // opcionUno
            // 
            this.opcionUno.BackColor = System.Drawing.Color.Transparent;
            this.opcionUno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opcionUno.Location = new System.Drawing.Point(179, 356);
            this.opcionUno.Margin = new System.Windows.Forms.Padding(2);
            this.opcionUno.Name = "opcionUno";
            this.opcionUno.Size = new System.Drawing.Size(130, 127);
            this.opcionUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opcionUno.TabIndex = 22;
            this.opcionUno.TabStop = false;
            this.opcionUno.Click += new System.EventHandler(this.opcionUno_Click);
            // 
            // respuestaC
            // 
            this.respuestaC.BackColor = System.Drawing.Color.Transparent;
            this.respuestaC.Location = new System.Drawing.Point(563, 137);
            this.respuestaC.Margin = new System.Windows.Forms.Padding(2);
            this.respuestaC.Name = "respuestaC";
            this.respuestaC.Size = new System.Drawing.Size(130, 127);
            this.respuestaC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.respuestaC.TabIndex = 27;
            this.respuestaC.TabStop = false;
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
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSalir_Paint);
            // 
            // Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.respuestaC);
            this.Controls.Add(this.numeroDos);
            this.Controls.Add(this.numeroUno);
            this.Controls.Add(this.opcionTres);
            this.Controls.Add(this.opcionDos);
            this.Controls.Add(this.opcionUno);
            this.Controls.Add(this.lblPuntaje);
            this.DoubleBuffered = true;
            this.Name = "Suma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suma";
            this.Load += new System.EventHandler(this.Suma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeroDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.PictureBox numeroDos;
        private System.Windows.Forms.PictureBox numeroUno;
        private System.Windows.Forms.PictureBox opcionTres;
        private System.Windows.Forms.PictureBox opcionDos;
        private System.Windows.Forms.PictureBox opcionUno;
        private System.Windows.Forms.PictureBox respuestaC;
        private System.Windows.Forms.Panel btnSalir;
    }
}