namespace Omega
{
    partial class Login
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
            System.Windows.Forms.PictureBox btnRegresar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnIngresar = new System.Windows.Forms.PictureBox();
            btnRegresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = System.Drawing.Color.Transparent;
            btnIngresar.BackgroundImage = global::Omega.Properties.Resources.check;
            btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnIngresar.Location = new System.Drawing.Point(147, 328);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(50, 50);
            btnIngresar.TabIndex = 6;
            btnIngresar.TabStop = false;
            btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = System.Drawing.Color.Transparent;
            btnRegresar.BackgroundImage = global::Omega.Properties.Resources.cancel;
            btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegresar.Location = new System.Drawing.Point(203, 328);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new System.Drawing.Size(50, 50);
            btnRegresar.TabIndex = 5;
            btnRegresar.TabStop = false;
            btnRegresar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(62, 264);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(191, 26);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(62, 296);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '•';
            this.txtContraseña.Size = new System.Drawing.Size(191, 26);
            this.txtContraseña.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Omega.Properties.Resources.kisspng_new_jersey_vietnam_student_teachers_day_vector_color_bulb_creative_5a8dd6d862f898_6493545315192450164054;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(62, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 218);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 401);
            this.Controls.Add(btnIngresar);
            this.Controls.Add(btnRegresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(btnIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
    }
}

