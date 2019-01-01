namespace Omega
{
    partial class ModificacionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionUsuarios));
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.txtContraseñaVieja = new System.Windows.Forms.TextBox();
            this.txtConfirmacion = new System.Windows.Forms.TextBox();
            btnIngresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnIngresar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = System.Drawing.Color.Transparent;
            btnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresar.BackgroundImage")));
            btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnIngresar.Location = new System.Drawing.Point(345, 502);
            btnIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(334, 104);
            btnIngresar.TabIndex = 7;
            btnIngresar.TabStop = false;
            btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.BackColor = System.Drawing.Color.Cornsilk;
            this.txtContraseñaNueva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaNueva.Location = new System.Drawing.Point(280, 286);
            this.txtContraseñaNueva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.PasswordChar = '●';
            this.txtContraseñaNueva.Size = new System.Drawing.Size(459, 33);
            this.txtContraseñaNueva.TabIndex = 10;
            this.txtContraseñaNueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContraseñaVieja
            // 
            this.txtContraseñaVieja.BackColor = System.Drawing.Color.Cornsilk;
            this.txtContraseñaVieja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñaVieja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaVieja.Location = new System.Drawing.Point(280, 152);
            this.txtContraseñaVieja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraseñaVieja.Name = "txtContraseñaVieja";
            this.txtContraseñaVieja.PasswordChar = '●';
            this.txtContraseñaVieja.Size = new System.Drawing.Size(459, 33);
            this.txtContraseñaVieja.TabIndex = 9;
            this.txtContraseñaVieja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.BackColor = System.Drawing.Color.Cornsilk;
            this.txtConfirmacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.Location = new System.Drawing.Point(280, 414);
            this.txtConfirmacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.PasswordChar = '●';
            this.txtConfirmacion.Size = new System.Drawing.Size(459, 33);
            this.txtConfirmacion.TabIndex = 11;
            this.txtConfirmacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModificacionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 650);
            this.ControlBox = false;
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.txtContraseñaNueva);
            this.Controls.Add(this.txtContraseñaVieja);
            this.Controls.Add(btnIngresar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificacionUsuarios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModificacionUsuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ModificacionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(btnIngresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.TextBox txtContraseñaVieja;
        private System.Windows.Forms.TextBox txtConfirmacion;
    }
}