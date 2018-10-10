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

namespace Omega
{
    public partial class Cantidad : Form
    {
        public int posicionInicialArriba, posicionInicialCostado, contador, respuestaCorrecta, respuestaIncorrecta1, respuestaIncorrecta2;

        private void opcionUno_Click_1(object sender, EventArgs e)
        {
            if (respuestaCorrecta == 0)
            {
                MessageBox.Show("Muy bien!");
                Recarga();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }
        }

        private void opcionDos_Click_1(object sender, EventArgs e)
        {
            if (respuestaCorrecta == 1)
            {
                MessageBox.Show("Muy bien!");
                Recarga();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }
        }

        private void opcionTres_Click_1(object sender, EventArgs e)
        {
            if (respuestaCorrecta == 2)
            {
                MessageBox.Show("Muy bien!");
                Recarga();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }
        }



        public Cantidad()
        {
            InitializeComponent();
        }

        private void Cantidad_Load(object sender, EventArgs e)
        {
            Recarga();
        }

        public void Recarga()
        {
            for(int i = this.Controls.Count -1; i >= 0; i--)
            {
                PictureBox control = this.Controls[i] as PictureBox;
                if (control == null) continue;

                control.Dispose();
            }

            string startupPathNumeros = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes", "Numeros");

            posicionInicialArriba = 10;
            posicionInicialCostado = 10;
            if (this.Tag.ToString() == "Facil")
            {
                Juego(1, 5);

            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                Juego(5, 10);
            }
            else if (this.Tag.ToString() == "Dificil")
            {
                Juego(10, 20);
            }
            if (respuestaCorrecta == 0)
            {
                opcionUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + contador.ToString() + ".png");
                opcionUno.BackgroundImageLayout = ImageLayout.Stretch;
                opcionDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + respuestaIncorrecta1.ToString() + ".png");
                opcionDos.BackgroundImageLayout = ImageLayout.Stretch;
                opcionTres.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + respuestaIncorrecta2.ToString() + ".png");
                opcionTres.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (respuestaCorrecta == 1)
            {
                opcionUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + respuestaIncorrecta1.ToString() + ".png");
                opcionUno.BackgroundImageLayout = ImageLayout.Stretch;
                opcionDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + contador.ToString() + ".png");
                opcionDos.BackgroundImageLayout = ImageLayout.Stretch;
                opcionTres.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + respuestaIncorrecta2.ToString() + ".png");
                opcionTres.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (respuestaCorrecta == 2)
            {
                opcionUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + respuestaIncorrecta2.ToString() + ".png");
                opcionUno.BackgroundImageLayout = ImageLayout.Stretch;
                opcionDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + respuestaIncorrecta1.ToString() + ".png");
                opcionDos.BackgroundImageLayout = ImageLayout.Stretch;
                opcionTres.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + contador.ToString() + ".png");
                opcionTres.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        public void Juego(int limiteMenor, int limiteMayor)
        {
            contador = 0;
            string startupPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes","Objetos");
            var nombrePicture = 1;
            var random = new Random();
            var cantidadPictures = random.Next(limiteMenor, limiteMayor);
            var imagen = random.Next(1, 51);

            for (int i = 1; i <= cantidadPictures; i++)
            {
                if (posicionInicialCostado >= 560)
                {
                    posicionInicialCostado = 10;
                    posicionInicialArriba = posicionInicialArriba + 110;
                }

                var picture = new PictureBox();
                Controls.Add(picture);
                picture.Name = "pictureBox" + nombrePicture;
                picture.Size = new Size(100, 100);
                picture.Location = new Point(posicionInicialCostado, posicionInicialArriba);
                picture.BackgroundImage = Image.FromFile(startupPath + @"\" + imagen.ToString() + ".png");
                picture.Visible = true;
                picture.BackgroundImageLayout = ImageLayout.Stretch;
                picture.Enabled = true;
                nombrePicture++;
                posicionInicialCostado = posicionInicialCostado + 110;
                contador++;
            }

            respuestaCorrecta = random.Next(2);

            respuestaIncorrecta1 = random.Next(limiteMenor, limiteMayor);

            respuestaIncorrecta2 = random.Next(limiteMenor, limiteMayor);

            while (contador == respuestaIncorrecta1 || contador == respuestaIncorrecta2 || respuestaIncorrecta1 == respuestaIncorrecta2)
            {
                respuestaIncorrecta1 = random.Next(limiteMenor, limiteMayor);
                respuestaIncorrecta2 = random.Next(limiteMenor, limiteMayor);
            }
        }
    }
}
