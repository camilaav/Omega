using ReglaDeNegocios;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Omega.Helpers;
using System.Configuration;

namespace Omega
{
    public partial class Suma : Form
    {
        public static string rutaImagenes = ConfigurationManager.AppSettings["Imagenes"].ToString();
        string startupPathNumeros = rutaImagenes + "//Numeros";
        int orden, fondo, fondo2, resultado, intento = 1, puntuacion = 0, idJuego = 2, idDificultad = 0, contadorGif;
        JuegoRN juegoRN = new JuegoRN();
        JuegosHelper juegoHelper = new JuegosHelper();
        Random randommizer = new Random();

        public void Gif()
        {
            pictureBox1.Load(rutaImagenes + "//bien.gif");
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
            tiempo.Enabled = true;
            tiempo.Start();
        }

        public void GifMal()
        {
            pictureBox1.Load(rutaImagenes + "//mal.gif");
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
            tiempo2.Enabled = true;
            tiempo2.Start();
        }

        public void Recarga()
        {
            tiempo.Stop();
            contadorGif = 0;
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            intento = 1;
            respuestaC.Visible = false;

            if (this.Tag.ToString() == "Facil")
            {
                idDificultad = 1;
                Juego(1, 10);

            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                idDificultad = 2;
                Juego(0, 50);
            }
            else if (this.Tag.ToString() == "Dificil")
            {
                idDificultad = 3;
                Juego(0, 100);
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

        public Suma()
        {
            InitializeComponent();
        }

        private void btnSalir_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

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

        private void opcionUno_Click(object sender, EventArgs e)
        {
            if (orden == 0)
            {
                Gif();
                respuestaC.Visible = true;
                respuestaC.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                respuestaC.BackgroundImageLayout = ImageLayout.Stretch;
                lblPuntaje.Text = null;
                lblPuntaje.Text = Puntuar().ToString();
            }
            else
            {
                GifMal();
                intento++;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MovimientoHelper movimientoHelper = new MovimientoHelper();
            movimientoHelper.GuardarMovimiento(this, idDificultad, puntuacion, idJuego);
        }

        private void opcionDos_Click(object sender, EventArgs e)
        {
            if (orden == 1)
            {
                Gif();
                respuestaC.Visible = true;
                respuestaC.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                respuestaC.BackgroundImageLayout = ImageLayout.Stretch;
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
                Gif();
                respuestaC.Visible = true;
                respuestaC.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                respuestaC.BackgroundImageLayout = ImageLayout.Stretch;
                lblPuntaje.Text = null;
                lblPuntaje.Text = Puntuar().ToString();
            }
            else
            {
                GifMal();
                intento++;
            }
        }


        private void tiempo_Tick(object sender, EventArgs e)
        {
            contadorGif++;
            if (contadorGif == 3)
            {
                Recarga();
            }
        }
        private void Suma_Load(object sender, EventArgs e)
        {
            Recarga();
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

        private void Juego(int limiteMenor, int limiteMayor)
        {
            int numero1;
            int numero2;

            numero1 = randommizer.Next(limiteMenor, limiteMayor);
            numero2 = randommizer.Next(limiteMenor, limiteMayor);
            resultado = juegoHelper.Operacion(numero1, numero2, "+");

            if(idDificultad == 1)
            {
                while (resultado > 10)
                {
                    numero1 = randommizer.Next(limiteMenor, limiteMayor);
                    numero2 = randommizer.Next(limiteMenor, limiteMayor);
                    resultado = juegoHelper.Operacion(numero1, numero2, "+");
                }
            }
            if(idDificultad == 2)
            {
                while (resultado > 50)
                {
                    numero1 = randommizer.Next(limiteMenor, limiteMayor);
                    numero2 = randommizer.Next(limiteMenor, limiteMayor);
                    resultado = juegoHelper.Operacion(numero1, numero2, "+");
                }
            }
            if(idDificultad == 3)
            {
                while (resultado > 100)
                {
                    numero1 = randommizer.Next(limiteMenor, limiteMayor);
                    numero2 = randommizer.Next(limiteMenor, limiteMayor);
                    resultado = juegoHelper.Operacion(numero1, numero2, "+");
                }
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
                fondo = randommizer.Next(limiteMenor, limiteMayor);
                fondo2 = randommizer.Next(limiteMenor, limiteMayor);
            }
        }
    }
}
