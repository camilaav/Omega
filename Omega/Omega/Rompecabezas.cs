using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    public partial class Rompecabezas : Form
    {
        string foto;
        Panel[] panels = new Panel[9];
        PictureBox[] pictures = new PictureBox[9];
        int np;
        Random random = new Random();
        public static string startupPathObjetos = ConfigurationManager.AppSettings["Imagenes"].ToString() + "//Cartas";

        public Rompecabezas()
        {
            InitializeComponent();
            panels[0] = panel1;
            panels[1] = panel2;
            panels[2] = panel3;
            panels[3] = panel4;
            panels[4] = panel5;
            panels[5] = panel6;
            panels[6] = panel7;
            panels[7] = panel8;
            panels[8] = panel9;
            pictures[0] = pictureBox2;
            pictures[1] = pictureBox3;
            pictures[2] = pictureBox4;
            pictures[3] = pictureBox5;
            pictures[4] = pictureBox6;
            pictures[5] = pictureBox7;
            pictures[6] = pictureBox8;
            pictures[7] = pictureBox9;
            pictures[8] = pictureBox10;
        }

        public void Romper()
        {
            Bitmap bitO, bit;
            int anc, lar, x, y, i;
            Rectangle area;
            bitO = new Bitmap(Image.FromFile(startupPathObjetos + "//" + foto + ".png"),new Size { Height = pictureBox1.Height, Width = pictureBox1.Width});
            anc = bitO.Width / 3;
            lar = bitO.Height / 3;
            i = 0;
            x = 0;
            y = 0;
            do
            {
                pictures[i].BackgroundImageLayout = ImageLayout.Stretch;
                area = new Rectangle(x, y, anc, lar);
                bit = new Bitmap(anc, lar);
                bit = bitO.Clone(area, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                pictures[i].Image = bit;
                if ((i + 1) % 3 == 0)
                {
                    y += lar;
                    x = 0;
                }
                else
                {
                    x += anc;
                }
                i++;
            } while (i < 9);
            Revolver();
        }

        public void Revolver()
        {
            int i, a, v, j;
            int[] n = new int[9];
            n[0] = 0;
            n[1] = 1;
            n[2] = 2;
            n[3] = 3;
            n[4] = 4;
            n[5] = 5;
            n[6] = 6;
            n[7] = 7;
            n[8] = 8;
            for(i = 0; i<8;i++)
            {
                a = random.Next(i + 1, 8);
                v = n[i];
                n[i] = n[a];
                n[a] = v;
            }
            for(i=0;i<=8;i++)
            {
                pictures[i].Parent = panels[n[i]];
                a = random.Next(1, 9);
                for(j=1;j<=a;j++)
                {
                    pictures[i].Image = Gira(pictures[i].Image);
                }
            }
        }
        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            var pantallaPrincipal = new Pantalla_principal();
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            var p = sender as Panel;
            if(e.Data.GetDataPresent(typeof(PictureBox)))
            {
                pictures[np].Parent = p;
                pictures[np].BringToFront();
            }
            else
            {
                e.Effect = DragDropEffects.None;
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

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            var p = sender as PictureBox;
            np = int.Parse(p.Tag.ToString());
            if(e.Button == MouseButtons.Left)
            {
                DoDragDrop(pictures[np], DragDropEffects.Move);
            }
            else
            {
                if(e.Button == MouseButtons.Right)
                {
                    pictures[np].Image = Gira(pictures[np].Image);
                }
            }
        }   

        public Image Gira(Image imagen)
        {
            Bitmap bit;
            bit = new Bitmap(imagen);
            bit.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return bit;
        }

        private void Rompecabezas_Load(object sender, EventArgs e)
        {
            CargarImagen();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            var pantallaPrincipal = new Pantalla_principal();
            pantallaPrincipal.Show();
            this.Hide();
        }
        public void CargarImagen()
        {
            var nombreImagen = random.Next(0, 18);
            pictureBox1.Load(startupPathObjetos + "//" + nombreImagen + ".png");
            foto = nombreImagen.ToString();
            Romper();
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Click(object sender, EventArgs e)
        {
            CargarImagen();
        }
    }
}
