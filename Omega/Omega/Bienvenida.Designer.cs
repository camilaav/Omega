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
            System.Windows.Forms.PictureBox btnProfesor;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            btnIngresar = new System.Windows.Forms.PictureBox();
            btnProfesor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = System.Drawing.Color.Transparent;
            btnIngresar.BackgroundImage = global::Omega.Properties.Resources.verified;
            btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnIngresar.Location = new System.Drawing.Point(326, 276);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(80, 80);
            btnIngresar.TabIndex = 3;
            btnIngresar.TabStop = false;
            btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnProfesor
            // 
            btnProfesor.BackColor = System.Drawing.Color.Transparent;
            btnProfesor.BackgroundImage = global::Omega.Properties.Resources.engranaje1;
            btnProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnProfesor.Location = new System.Drawing.Point(12, 12);
            btnProfesor.Name = "btnProfesor";
            btnProfesor.Size = new System.Drawing.Size(40, 40);
            btnProfesor.TabIndex = 4;
            btnProfesor.TabStop = false;
            btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(215, 217);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingresa tu nombre";
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Omega.Properties.Resources._1086;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(btnProfesor);
            this.Controls.Add(btnIngresar);
            this.Controls.Add(this.txtNombre);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.Load += new System.EventHandler(this.Bienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(btnIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
    }
}