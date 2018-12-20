using System;
using System.Collections;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Omega.Helpers;

namespace Omega
{
    public partial class Rompecabezas : Form
    {
        string foto;
        Panel[] panels = new Panel[9];
        PictureBox[] pictures = new PictureBox[9];
        Random random = new Random();
        public static string startupPathObjetos = ConfigurationManager.AppSettings["Imagenes"].ToString() + "//Cartas";
        JuegosHelper juegoHelper = new JuegosHelper();
        Point lugarVacio;
        ArrayList imagenes = new ArrayList();
        int contadorGif;

        public Rompecabezas()
        {
            lugarVacio.X = 180;
            lugarVacio.Y = 180;
            InitializeComponent();
        }

        private void Rompecabezas_Load(object sender, EventArgs e)
        {
            CargarImagen();
        }

        public void CargarImagen()
        {
            imagenes = new ArrayList();
            contadorGif = 0;
            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;
            tiempo.Stop();
            foreach (Button b in panel1.Controls)
                b.Enabled = true;

            foto = null;
            foto = random.Next(0,18).ToString();

            var original = Image.FromFile(startupPathObjetos + "//" + foto + ".png");

            Recortar(original, 270, 270);

            pictureBox1.Image = original;
            AgregarImagenABotones(imagenes);
        }

        private void AgregarImagenABotones(ArrayList images)
        {
            var i = 0;

            var arr = new int[8];

            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 2;
            arr[3] = 3;
            arr[4] = 4;
            arr[5] = 5;
            arr[6] = 6;
            arr[7] = 7;

            arr = Mezclar(arr);

            foreach (Button b in panel1.Controls)
            {
                if (i < arr.Length)
                {
                    b.Image = (Image)images[arr[i]];
                    i++;
                }
            }
        }

        private int[] Mezclar(int[] arr)
        {
            arr = arr.OrderBy(x => random.Next()).ToArray();
            return arr;
        }

        private void Recortar(Image orginal, int w, int h)
        {
            var bmp = new Bitmap(w, h);

            var grafico = Graphics.FromImage(bmp);

            grafico.DrawImage(orginal, 0, 0, w, h);

            grafico.Dispose();

            int movr = 0, movd = 0;

            for (int x = 0; x < 8; x++)
            {
                var pieza = new Bitmap(90, 90);

                for (int i = 0; i < 90; i++)
                    for (int j = 0; j < 90; j++)
                        pieza.SetPixel(i, j,
                            bmp.GetPixel(i + movr, j + movd));

                imagenes.Add(pieza);

                movr += 90;

                if (movr == 270)
                {
                    movr = 0;
                    movd += 90;
                }
            }

        }

        private void MoverPieza(Button btn)
        {
            if (((btn.Location.X == lugarVacio.X - 90 || btn.Location.X == lugarVacio.X + 90)
                && btn.Location.Y == lugarVacio.Y)
                || (btn.Location.Y == lugarVacio.Y - 90 || btn.Location.Y == lugarVacio.Y + 90)
                && btn.Location.X == lugarVacio.X)
            {
                Point swap = btn.Location;
                btn.Location = lugarVacio;
                lugarVacio = swap;
            }

            if (lugarVacio.X == 180 && lugarVacio.Y == 180)
                Chequear();
        }

        private void Chequear()
        {
            int count = 0, index;
            foreach (Button btn in panel1.Controls)
            {
                index = (btn.Location.Y / 90) * 3 + btn.Location.X / 90;
                if (imagenes[index] == btn.Image)
                    count++;
            }
            if (count == 8)
            {
                juegoHelper.Gif(pictureBox2, this, 0, 0, 0, 0, tiempo, "bien", false);
            }
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            CargarImagen();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            MoverPieza((Button)sender);
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            var pantallaPrincipal = new Pantalla_principal();
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            contadorGif++;
            if (contadorGif == 3)
            {
                CargarImagen();
            }
        }
    }
}
