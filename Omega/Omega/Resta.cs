using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Regla_de_Negocios;
using Omega.Helpers;

namespace Omega
{
    public partial class Resta : Form
    {
        string startupPathNumeros = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes", "Numeros");
        string startupPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes");

        int resultado, orden, fondo, fondo2, intento = 1, puntuacion = 0, idJuego = 1, idDificultad = 0, contadorGif = 0;

        JuegosHelper juegoHelper = new JuegosHelper();

        JuegoRN juegoRN = new JuegoRN();
        Random randommizer = new Random();

        public void Gif()
        {
            pictureBox1.Load(startupPath + "//bien.gif");
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
            tiempo.Enabled = true;
            tiempo.Start();
        }

        public void GifMal()
        {
            pictureBox1.Load(startupPath + "//mal.gif");
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
            tiempo2.Enabled = true;
            tiempo2.Start();
        }

        public Resta()
        {
            InitializeComponent();
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

        private void btnSalir_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            contadorGif++;
            if (contadorGif == 3)
            {
                Recarga();
                contadorGif = 0;
            }
        }

        private void tiempo2_Tick(object sender, EventArgs e)
        {
            contadorGif++;
            if (contadorGif == 3)
            {
                pictureBox1.Visible = false;
                pictureBox1.Enabled = false;
                tiempo2.Stop();
                contadorGif = 0;
            }
        }

        public void Recarga()
        {
            tiempo.Stop();
            contadorGif = 0;
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            intento = 1;
            respuestaCorrecta.Visible = false;
            if (this.Tag.ToString() == "Facil")
            {
                Juego(0, 10);
                idDificultad = 1;

            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                Juego(0, 50);
                idDificultad = 2;
            }
            else if (this.Tag.ToString() == "Dificil")
            {
                Juego(0, 100);
                idDificultad = 3;
            }

            if (orden == 0)                                 //PONE LA RESPUESTA CORRECTA EN UNA DE LAS 3 OPCINES EN FORMA ALEATOREA
            {
                opcionUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                opcionUno.BackgroundImageLayout = ImageLayout.Stretch;
                opcionDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + fondo.ToString() + ".png");
                opcionDos.BackgroundImageLayout = ImageLayout.Stretch;
                opcionTres.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + fondo2.ToString() + ".png");
                opcionTres.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (orden == 1)
            {
                opcionUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + fondo.ToString() + ".png");
                opcionUno.BackgroundImageLayout = ImageLayout.Stretch;
                opcionDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                opcionDos.BackgroundImageLayout = ImageLayout.Stretch;
                opcionTres.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + fondo2.ToString() + ".png");
                opcionTres.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (orden == 2)
            {
                opcionUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + fondo2.ToString() + ".png");
                opcionUno.BackgroundImageLayout = ImageLayout.Stretch;
                opcionDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + fondo.ToString() + ".png");
                opcionDos.BackgroundImageLayout = ImageLayout.Stretch;
                opcionTres.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                opcionTres.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MovimientoHelper movimientoHelper = new MovimientoHelper();
            movimientoHelper.GuardarMovimiento(this, idDificultad, puntuacion, idJuego);
        }

        private void Resta_Load(object sender, EventArgs e)
        {
            Recarga();
        }

        private void Juego(int limiteMenor, int limiteMayor)
        {
            int numero1;
            int numero2;

            numero1 = randommizer.Next(limiteMenor, limiteMayor);
            numero2 = randommizer.Next(limiteMenor, limiteMayor);
            resultado = juegoHelper.Operacion(numero1, numero2, "-");

            while (resultado < 0)
            {
                numero1 = randommizer.Next(limiteMenor, limiteMayor + 1);
                numero2 = randommizer.Next(limiteMenor, limiteMayor + 1);
                resultado = (numero1 - numero2);
            }
            numeroUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + numero1.ToString() + ".png");
            numeroUno.BackgroundImageLayout = ImageLayout.Stretch;
            numeroDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + numero2.ToString() + ".png");
            numeroDos.BackgroundImageLayout = ImageLayout.Stretch;

            orden = randommizer.Next(2);

            fondo = randommizer.Next(limiteMenor, limiteMayor);

            fondo2 = randommizer.Next(limiteMenor, limiteMayor);

            while (resultado == fondo || resultado == fondo2 || fondo == fondo2)
            {
                fondo = randommizer.Next(limiteMenor, limiteMayor + 1);
                fondo2 = randommizer.Next(limiteMenor, limiteMayor + 1);
            }
        }

        private void opcionUno_Click(object sender, EventArgs e)
        {
            if (orden == 0)
            {
                respuestaCorrecta.Visible = true;
                respuestaCorrecta.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                respuestaCorrecta.BackgroundImageLayout = ImageLayout.Stretch;               
                lblPuntaje.Text = null;
                lblPuntaje.Text = Puntuar().ToString();
                Gif();
            }
            else
            {
                GifMal();
                intento++;
            }
        }

        private void opcionDos_Click(object sender, EventArgs e)
        {
            if (orden == 1)
            {
                respuestaCorrecta.Visible = true;
                respuestaCorrecta.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                respuestaCorrecta.BackgroundImageLayout = ImageLayout.Stretch;
                Gif();
                lblPuntaje.Text = null;
                lblPuntaje.Text = Puntuar().ToString();
            }
            else
            {
                GifMal();
                intento++;
            }
        }

        private void opcionTres_Click(object sender, EventArgs e)
        {
            if (orden == 2)
            {
                respuestaCorrecta.Visible = true;
                respuestaCorrecta.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                respuestaCorrecta.BackgroundImageLayout = ImageLayout.Stretch;
                Gif();
                lblPuntaje.Text = null;
                lblPuntaje.Text = Puntuar().ToString();
            }
            else
            {
                GifMal();
                intento++;
            }
        }
    }
}
