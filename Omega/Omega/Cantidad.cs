using System;
using System.Drawing;
using System.Windows.Forms;
using ReglaDeNegocios;
using System.Configuration;
using Omega.Helpers;

namespace Omega
{
    public partial class Cantidad : Form
    {
        public string rutaImagenes = ConfigurationManager.AppSettings["Imagenes"].ToString();
        public int posicionInicialArriba, posicionInicialCostado, contador, respuestaCorrecta, respuestaIncorrecta1, respuestaIncorrecta2, intento = 1, puntuacion = 0, idJuego = 3, idDificultad = 0, contadorGif;
        public JuegoRN juegoRN = new JuegoRN();
        PictureBox pictureGif = new PictureBox();
        JuegosHelper juegosHelper = new JuegosHelper();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var pantallaPrincipal = new Pantalla_principal();
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void opcionDos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            var pantallaPrincipal = new Pantalla_principal();
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void opcionUno_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tiempo2_Tick(object sender, EventArgs e)
        {
            contadorGif++;
            if (contadorGif == 1)
            {
                pictureGif.Visible = false;
                pictureGif.Enabled = false;
                tiempo2.Stop();
                contadorGif = 0;
            }
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            contadorGif++;
            if (contadorGif == 1)
            {
                Recarga();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MovimientoHelper movimientoHelper = new MovimientoHelper();
            movimientoHelper.GuardarMovimiento(this, idDificultad, puntuacion, idJuego);
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
                juegosHelper.Gif(pictureGif, this, 654, 430, 47, 229, tiempo, "//bien",true);
                Puntuar();
            }
            else
            {
                juegosHelper.Gif(pictureGif, this, 654, 430, 47, 229, tiempo2, "//mal",true);
                intento++;
            }
        }

        private void opcionDos_Click_1(object sender, EventArgs e)
        {
            if (respuestaCorrecta == 1)
            {
                juegosHelper.Gif(pictureGif, this, 654, 430, 47, 229, tiempo, "//bien",true);
                Puntuar();
            }
            else
            {
                juegosHelper.Gif(pictureGif, this, 654, 430, 47, 229, tiempo2, "//mal",true);
                intento++;
            }
        }

        private void opcionTres_Click_1(object sender, EventArgs e)
        {
            if (respuestaCorrecta == 2)
            {
                juegosHelper.Gif(pictureGif, this, 654, 430, 47, 229, tiempo,"//bien",true);
                Puntuar();
            }
            else
            {
                juegosHelper.Gif(pictureGif, this, 654, 430, 47, 229, tiempo2, "//mal",true);
                intento++;
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
            tiempo.Stop();
            contadorGif = 0;
            pictureGif.Visible = false;
            pictureGif.Enabled = false;
            intento = 1;
            lblPuntaje.Text = puntuacion.ToString();

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                PictureBox control = this.Controls[i] as PictureBox;
                if (control == null) continue;

                control.Dispose();
            }

            string startupPathNumeros = rutaImagenes + "//Numeros";

            posicionInicialArriba = 130;
            posicionInicialCostado = 165;
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
            string startupPathObjetos = rutaImagenes + "//Objetos";
            var nombrePicture = 1;
            var random = new Random();
            var cantidadPictures = random.Next(limiteMenor, limiteMayor);
            int imagen = random.Next(1, 51);
            while (imagen == 13 || imagen == 19 || imagen == 22)
            {
                imagen = random.Next(1, 51);
            }

            for (int i = 1; i <= cantidadPictures; i++)
            {
                if (posicionInicialCostado >= 550)
                {
                    posicionInicialCostado = 165;
                    posicionInicialArriba = posicionInicialArriba + 85;
                }

                var picture = new PictureBox();
                Controls.Add(picture);
                picture.Name = "pictureBox" + nombrePicture;
                picture.Size = new Size(75, 75);
                picture.BackColor = Color.Transparent;
                picture.Location = new Point(posicionInicialCostado, posicionInicialArriba);
                picture.BackgroundImage = Image.FromFile(startupPathObjetos + @"\" + imagen.ToString() + ".png");
                picture.Visible = true;
                picture.BackgroundImageLayout = ImageLayout.Stretch;
                picture.Enabled = true;
                nombrePicture++;
                posicionInicialCostado = posicionInicialCostado + 85;
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
