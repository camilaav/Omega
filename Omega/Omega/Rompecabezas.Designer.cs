namespace Omega
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSalir = new System.Windows.Forms.Panel();
            this.picvolver = new System.Windows.Forms.PictureBox();
            this.picAbrir = new System.Windows.Forms.PictureBox();
            this.picpista = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picvolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpista)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.jpe;*.bmp;*.gif";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(1075, 669);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 56);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picvolver
            // 
            this.picvolver.BackColor = System.Drawing.Color.Transparent;
            this.picvolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picvolver.BackgroundImage")));
            this.picvolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picvolver.Location = new System.Drawing.Point(0, 0);
            this.picvolver.Name = "picvolver";
            this.picvolver.Size = new System.Drawing.Size(72, 79);
            this.picvolver.TabIndex = 30;
            this.picvolver.TabStop = false;
            this.picvolver.Click += new System.EventHandler(this.picvolver_Click);
            // 
            // picAbrir
            // 
            this.picAbrir.Location = new System.Drawing.Point(2, 157);
            this.picAbrir.Name = "picAbrir";
            this.picAbrir.Size = new System.Drawing.Size(100, 50);
            this.picAbrir.TabIndex = 31;
            this.picAbrir.TabStop = false;
            this.picAbrir.Click += new System.EventHandler(this.picAbrir_Click);
            // 
            // picpista
            // 
            this.picpista.Location = new System.Drawing.Point(2, 213);
            this.picpista.Name = "picpista";
            this.picpista.Size = new System.Drawing.Size(100, 50);
            this.picpista.TabIndex = 32;
            this.picpista.TabStop = false;
            this.picpista.Click += new System.EventHandler(this.picpista_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.picpista);
            this.Controls.Add(this.picAbrir);
            this.Controls.Add(this.picvolver);
            this.Controls.Add(this.btnSalir);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rompecabezas";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ClientSizeChanged += new System.EventHandler(this.MainForm_ClientSizeChanged_2);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown_2);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove_2);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp_2);
            ((System.ComponentModel.ISupportInitialize)(this.picvolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel btnSalir;
        private System.Windows.Forms.PictureBox picvolver;
        private System.Windows.Forms.PictureBox picAbrir;
        private System.Windows.Forms.PictureBox picpista;
    }
}