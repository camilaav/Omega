using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    public partial class Rompecabezas : Form
    {
        string foto;
        Panel [] panel = new Panel [4];
        PictureBox[] pictureBox = new PictureBox[4];
        int np;

        public void Romper()
        {
            Bitmap bitO, bit;
            int anc, lar, x, y, i;
            Rectangle area;
            bitO = new Bitmap(foto);
            anc = bitO.Width / 2;
            lar = bitO.Height / 2;
            i = 0;
            x = 0;
            y = 0;
            do
            {
                area = new Rectangle(x, y, anc, lar);
                bit = new Bitmap(anc, lar);
                bit = bitO.Clone(area, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                pictureBox[i].Image = bit;
                if ((i + 1) % 2 == 0)
                {
                    y = y + lar;
                    x = 0;
                }
                else
                {
                    x = x + anc;
                }
                i++;
            } while (i<4);
            Revolver();
        }

        public Image Gira(Image ima)
        {
            Bitmap bit;
            bit = new Bitmap(ima);
            bit.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return bit;
        }

        public void Revolver()
        {
            Random random = new Random();
            int i, a, v, j;
            int[] n = new int[4];
            n[0] = 0;
            n[1] = 1;
            n[2] = 2;
            n[3] = 3;
            for(i = 0; i<3;i++)
            {
                a = random.Next(i + 1,3);
                v = n[1];
                n[i] = n[a];
                n[a] = v;
            }
            for(i=0;i<=3;i++)
            {
                pictureBox[i].Parent = panel[n[i]];
                a = random.Next(1, 4);
                for(j=1;j<=a;j++)
                {
                    pictureBox[i].Image = Gira(pictureBox[i].Image);
                }
            }
        }

        public Rompecabezas()
        {
            InitializeComponent();
            panel[0] = panel1;
            panel[1] = panel2;
            panel[2] = panel3;
            panel[3] = panel4;
            pictureBox[0] = pictureBox1;
            pictureBox[1] = pictureBox2;
            pictureBox[2] = pictureBox3;
            pictureBox[3] = pictureBox4;
        }

        private void Elegir_Click(object sender, EventArgs e)
        {
            foto = string.Empty;
            while(foto == string.Empty)
            {
                openFileDialog.ShowDialog();
                foto = openFileDialog.FileName;
            }
            imagen.Load(foto);
            Romper();
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            np = Convert.ToInt16(picture.Tag.ToString());
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(pictureBox[np], DragDropEffects.Move);
            }
            else if (e.Button == MouseButtons.Right)
            {
                pictureBox[np].Image = Gira(pictureBox[np].Image);
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(PictureBox)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            Panel pa = sender as Panel;
            if(e.Data.GetDataPresent(typeof(PictureBox)))
            {
                pictureBox[np].Parent = pa;
                pictureBox[np].BringToFront();
            }
        }
    }
}
