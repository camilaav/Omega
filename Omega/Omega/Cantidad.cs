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
using Entidades;

namespace Omega
{
    public partial class Cantidad : Form
    {
        public int posicionInicialArriba, posicionInicialCostado, contador, respuestaCorrecta, respuestaIncorrecta1, respuestaIncorrecta2, intento = 1, puntuacion = 0, idJuego=3, idDificultad=0;
        public JuegoRN juegoRN = new JuegoRN();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MovimientoHelper movimientoHelper = new MovimientoHelper();
            movimientoHelper.GuardarMovimiento(this, idDificultad, puntuacion,idJuego);
        }

        public int Puntuar()
        {
            if (intento == 1)
            {
                return puntuacion = puntuacion + 100;
            }
            else if (intento == 2)
            {
                return puntuacion = puntuacion + 50;
            }
            else if (intento >= 3)
            {
                return puntuacion = puntuacion + 25;
            }
            else
            {
                return puntuacion = puntuacion + 0;
            }
        }

        private void opcionUno_Click_1(object sender, EventArgs e)
        {
            if (respuestaCorrecta == 0)
            {
                MessageBox.Show("Muy bien!");
                Puntuar();
                Recarga();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
                intento++;
            }
        }

        private void opcionDos_Click_1(object sender, EventArgs e)
        {
            if (respuestaCorrecta == 1)
            {
                MessageBox.Show("Muy bien!");
                Puntuar();
                Recarga();
            }
            else
            {
                intento++;
                MessageBox.Show("Respuesta incorrecta");
            }
        }

        private void opcionTres_Click_1(object sender, EventArgs e)
        {
            if (respuestaCorrecta == 2)
            {
                MessageBox.Show("Muy bien!");
                Puntuar();
                Recarga();
            }
            else
            {
                intento++;
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
            intento = 1;
            lblPuntaje.Text = puntuacion.ToString();

            for (int i = this.Controls.Count -1; i >= 0; i--)
            {
                PictureBox control = this.Controls[i] as PictureBox;
                if (control == null) continue;

                control.Dispose();
            }

            string startupPathNumeros = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes", "Numeros");

            posicionInicialArriba = 55;
            posicionInicialCostado = 10;
            if (this.Tag.ToString() == "Facil")
            {
                Juego(1, 5);
                idDificultad = 1;
            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                Juego(5, 10);
                idDificultad = 2;
            }
            else if (this.Tag.ToString() == "Dificil")
            {
                Juego(10, 20);
                idDificultad = 3;
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
                picture.BackColor = Color.Transparent;
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
