using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    public partial class Colorear : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Black, 1);
        Point punto1 = new Point(0, 0);
        Point punto2 = new Point(0, 0);
        int k = 0;
        int Foto;
        private int cX, cY, x, y, dX, dY;
        Color color;

        public Colorear()
        {
            InitializeComponent();
            color = Color.Black;
        }

        private void Brown_Click(object sender, EventArgs e)
        {
            color = Color.Brown;
            Default1.BackColor = color;
        }

        private void Maroon_Click(object sender, EventArgs e)
        {
            color = Color.Maroon;
            Default1.BackColor = color;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            color = Color.Red;
            Default1.BackColor = color;
        }

        private void OrangeRed_Click(object sender, EventArgs e)
        {
            color = Color.OrangeRed;
            Default1.BackColor = color;
        }

        private void LightSalmon_Click(object sender, EventArgs e)
        {
            color = Color.LightSalmon;
            Default1.BackColor = color;
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            color = Color.Pink;
            Default1.BackColor = color;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
            Default1.BackColor = color;
        }

        private void Gold_Click(object sender, EventArgs e)
        {
            color = Color.Gold;
            Default1.BackColor = color;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            color = Color.Green;
            Default1.BackColor = color;
        }

        private void YellowGreen_Click(object sender, EventArgs e)
        {
            color = Color.YellowGreen;
            Default1.BackColor = color;
        }

        private void SteelBlue_Click(object sender, EventArgs e)
        {
            color = Color.SteelBlue;
            Default1.BackColor = color;
        }

        private void Aqua_Click(object sender, EventArgs e)
        {
            color = Color.Aqua;
            Default1.BackColor = color;
        }

        private void MediumSlateBlue_Click(object sender, EventArgs e)
        {
            color = Color.MediumSlateBlue;
            Default1.BackColor = color;
        }

        private void RoyalBlue_Click(object sender, EventArgs e)
        {
            color = Color.RoyalBlue;
            Default1.BackColor = color;
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            color = Color.Purple;
            Default1.BackColor = color;
        }

        private void Bisque_Click(object sender, EventArgs e)
        {
            color = Color.Bisque;
            Default1.BackColor = color;
        }

        private void Negro_Click(object sender, EventArgs e)
        {
            color = Color.Black;
            Default1.BackColor = color;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Pantalla.Refresh();
            Pantalla.Image = null;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            var bmp = new Bitmap(Pantalla.Width, Pantalla.Height);
            var g = Graphics.FromImage(bmp);
            var rect = Pantalla.RectangleToScreen(Pantalla.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, Pantalla.Size);
            g.Dispose();
            var s = new SaveFileDialog();
            s.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName))
                {
                    File.Delete(s.FileName);
                }
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
            }
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Pantalla.Image = (Image)Image.FromFile(o.FileName).Clone();
            }
        }

        private void Borrador_Click(object sender, EventArgs e)
        {
            Foto = 2;
            color = Color.White;
        }

        private void Lapiz_Click(object sender, EventArgs e)
        {
            Foto = 1;
        }

        private void Pincel_Click(object sender, EventArgs e)
        {
            Foto = 6;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Foto = 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Foto = 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Foto = 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Foto = 10;
        }

        private void Circulo_Click(object sender, EventArgs e)
        {
            Foto = 4;
        }

        private void Cuadrado_Click(object sender, EventArgs e)
        {
            Foto = 5;
        }

        private void Linea_Click(object sender, EventArgs e)
        {
            Foto = 3;
        }

        private void Pantalla_MouseClick(object sender, MouseEventArgs e)
        {
            if (k == 1)
            {
                x = e.X;
                y = e.Y;
                dX = e.X - cX;
                dY = e.Y - cY;
                if (Foto == 3)
                {
                    g.DrawLine(new Pen(color), cX, cY, e.X, e.Y);
                }
                if (Foto == 4)
                {
                    g.DrawEllipse(new Pen(color), cX, cY, dX, dY);
                }
                if (Foto == 5)
                {
                    g.DrawRectangle(new Pen(color), cX, cY, dX, dY);
                }
            }
        }

        private void Pantalla_MouseDown(object sender, MouseEventArgs e)
        {
            punto1 = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                k = 1;
            }
            cX = e.X;
            cY = e.Y;
        }

        private void Colorear_Load(object sender, EventArgs e)
        {
            g = Pantalla.CreateGraphics();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var entretenimiento = new Entretenimiento();
            entretenimiento.Show();
            this.Hide();
        }

        private void Pantalla_MouseMove(object sender, MouseEventArgs e)
        {
            if (k == 1)
            {
                punto2 = e.Location;
                x = e.X;
                y = e.Y;
                switch(Foto)
                {
                    case 1:
                        g.DrawLine(new Pen(color), punto1, punto2);
                        break;
                    case 2:
                        g.FillEllipse(new SolidBrush(color), e.X, e.Y, 60, 60);
                        break;
                    case 6:
                        g.FillEllipse(new SolidBrush(color), e.X, e.Y, 60, 60);
                        break;
                    case 7:

                        g.FillEllipse(new SolidBrush(color), e.X, e.Y, 5, 5);
                        break;
                    case 8:
                        g.FillEllipse(new SolidBrush(color), e.X, e.Y, 15, 15);
                        break;
                    case 9:
                        g.FillEllipse(new SolidBrush(color), e.X, e.Y, 25, 25);
                        break;
                    case 10:
                        g.FillEllipse(new SolidBrush(color), e.X, e.Y, 35, 35);
                        break;
                }
                punto1 = punto2;
            }
        }

        private void Pantalla_MouseUp(object sender, MouseEventArgs e)
        {
            k = 0;
        }

        private void DarkGray_Click(object sender, EventArgs e)
        {
            color = Color.DarkGray;
            Default1.BackColor = color;
        }

        private void Gray_Click(object sender, EventArgs e)
        {
            color = Color.Gray;
            Default1.BackColor = color;
        }

        private void Blanco_Click(object sender, EventArgs e)
        {
            color = Color.White;
            Default1.BackColor = color;
        }
    }
}
