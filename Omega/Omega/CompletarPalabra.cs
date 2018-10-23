using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regla_de_Negocios;

namespace Omega
{
    public partial class CompletarPalabra : Form
    {
        JuegoRN juegoRN = new JuegoRN();
        string palabra;
        int posicionInicialArriba = 0, posicionInicialCostado = 0;
        public static readonly string[] abecedario = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public CompletarPalabra()
        {
            InitializeComponent();
        }

        public void CargarPalabras()
        {
            string startupPathPalabras = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes", "Letras");

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                PictureBox control = this.Controls[i] as PictureBox;
                if (control == null) continue;

                control.Dispose();
            }

            posicionInicialArriba = 10;
            posicionInicialCostado = 10;
            var listaPalabras = juegoRN.ListaPalabras();
            var random = new Random();

            palabra = listaPalabras[random.Next(1, listaPalabras.Count)].Palabra;

            var letras = new List<char>();
            foreach (var letra in palabra)
            {
                letras.Add(letra);
            }
            foreach(var letra in letras)
            {
                //if (posicionInicialCostado >= 560)
                //{
                //    posicionInicialCostado = 10;
                    //posicionInicialArriba = posicionInicialArriba + 110;
                //}

                var picture = new PictureBox();
                Controls.Add(picture);
                picture.Name = "pictureBox" + letra.ToString().ToUpper();
                picture.Size = new Size(100, 100);
                picture.Location = new Point(posicionInicialCostado, posicionInicialArriba);
                picture.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + letra.ToString().ToUpper() + ".png");
                picture.Visible = true;
                picture.BackgroundImageLayout = ImageLayout.Stretch;
                picture.Enabled = true;
                posicionInicialCostado = posicionInicialCostado + 100;
                //contador++;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper() == palabra.ToUpper())
            {
                MessageBox.Show("Muy bien");
                CargarPalabras();
            }
        }

        private void CompletarPalabra_Load(object sender, EventArgs e)
        {
            CargarPalabras();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            //if (label1.Text + label2.Text + label8.Text + label4.Text == palabra)
            //{
            //    MessageBox.Show("Muy bien!!!!11");
            //    CargarPalabras();
            //}
        }
    }
}
