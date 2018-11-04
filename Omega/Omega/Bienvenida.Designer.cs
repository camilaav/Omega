namespace Omega
{
    partial class Bienvenida
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
            System.Windows.Forms.PictureBox btnIngresar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.picprofesor = new System.Windows.Forms.PictureBox();
            btnIngresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picprofesor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = System.Drawing.Color.Transparent;
            btnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresar.BackgroundImage")));
            btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnIngresar.Location = new System.Drawing.Point(293, 322);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(277, 79);
            btnIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            btnIngresar.TabIndex = 3;
            btnIngresar.TabStop = false;
            btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Cornsilk;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtNombre.Location = new System.Drawing.Point(304, 257);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 25);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // picprofesor
            // 
            this.picprofesor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picprofesor.BackColor = System.Drawing.Color.Transparent;
            this.picprofesor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picprofesor.BackgroundImage")));
            this.picprofesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picprofesor.Location = new System.Drawing.Point(805, -3);
            this.picprofesor.Name = "picprofesor";
            this.picprofesor.Size = new System.Drawing.Size(72, 79);
            this.picprofesor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picprofesor.TabIndex = 5;
            this.picprofesor.TabStop = false;
            this.picprofesor.Click += new System.EventHandler(this.picprofesor_Click);
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 630);
            this.Controls.Add(this.picprofesor);
            this.Controls.Add(btnIngresar);
            this.Controls.Add(this.txtNombre);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.Load += new System.EventHandler(this.Bienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(btnIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picprofesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox picprofesor;
    }
}