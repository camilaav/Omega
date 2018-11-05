namespace Omega
{
    partial class Memotest
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.panelJuego = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad de intentos";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(607, 30);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(71, 13);
            this.lblRecord.TabIndex = 5;
            this.lblRecord.Text = "Record juego";
            // 
            // panelJuego
            // 
            this.panelJuego.Location = new System.Drawing.Point(12, 12);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(450, 426);
            this.panelJuego.TabIndex = 4;
            this.panelJuego.Paint += new System.Windows.Forms.PaintEventHandler(this.panelJuego_Paint_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Memotest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.panelJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Memotest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Panel panelJuego;
        private System.Windows.Forms.Timer timer1;
    }
}