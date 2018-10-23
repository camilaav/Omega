using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Regla_de_Negocios;

namespace Omega
{
    public partial class Resta : Form
    {
        string startupPathNumeros = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes", "Numeros");
        int resultado, orden, fondo, fondo2, intento = 1, puntuacion = 0, idJuego = 1, idDificultad = 0;

        JuegoRN juegoRN = new JuegoRN();
        Random randommizer = new Random();

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

        public void Recarga()
        {
            intento = 1;
            respuestaCorrecta.Visible = false;
            if (this.Tag.ToString() == "Facil")
            {
                Juego(191, 1, 10);
                idDificultad = 1;

            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                Juego(191, 0, 50);
                idDificultad = 2;
            }
            else if (this.Tag.ToString() == "Dificil")
            {
                Juego(258, 0, 100);
                idDificultad = 3;
            }

            tiempo.Enabled = true;
            pictureCorrecto1.Visible = false;
            pictureCorrecto2.Visible = false;
            pictureCorrecto3.Visible = false;

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

        private void Juego(int width, int limiteMenor, int limiteMayor)
        {
            int numero1; //PRIMER NUMERO DE LA RESTA
            int numero2; //SEGUNDO NUMERO DE LA RESTA

            numeroUno.Width = width;
            numeroDos.Width = width;

            numero1 = randommizer.Next(limiteMenor, limiteMayor);
            numero2 = randommizer.Next(limiteMenor, limiteMayor);
            resultado = (numero1 - numero2);

            while (resultado < 0) //ELIMINA LA POSIBILIDAD DE RESULTADO NEGATIVO
            {
                numero1 = randommizer.Next(limiteMenor, limiteMayor);
                numero2 = randommizer.Next(limiteMenor, limiteMayor);
                resultado = (numero1 - numero2);
            }
            //LE DA IMAGENES A LOS 3 PRIMEROS PICTUREBOX
            numeroUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + numero1.ToString() + ".png");
            numeroUno.BackgroundImageLayout = ImageLayout.Stretch;
            numeroDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + numero2.ToString() + ".png");
            numeroDos.BackgroundImageLayout = ImageLayout.Stretch;

            orden = randommizer.Next(2);//NUMERO RANDOM PARA LA POSICION DE LA RESPUESTA CORRECTA

            //NUMERO DE FONDO DE UN PICTURE DE RESPUESTAS
            fondo = randommizer.Next(limiteMenor, limiteMayor);

            //NUMERO DE FONDO DEL OTRO PICTURE DE RESPUESTA
            fondo2 = randommizer.Next(limiteMenor, limiteMayor);

            //VUELVE A HACER RANDOM LOS FONDOS HASTA QUE NO SEAN IGUAL AL RESULTADO
            while (resultado == fondo || resultado == fondo2 || fondo == fondo2)
            {
                fondo = randommizer.Next(limiteMenor, limiteMayor);
                fondo2 = randommizer.Next(limiteMenor, limiteMayor);
            }
        }

        private void opcionUno_Click(object sender, EventArgs e)
        {
            if (orden == 0)
            {
                respuestaCorrecta.Visible = true;
                respuestaCorrecta.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                respuestaCorrecta.BackgroundImageLayout = ImageLayout.Stretch;
                MessageBox.Show("Muy bien!");
                pictureCorrecto1.Visible = true;
                lblPuntaje.Text = null;
                lblPuntaje.Text = Puntuar().ToString();
                Recarga();
            }
            else
            {
                MessageBox.Show("contestaste mal");
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
                MessageBox.Show("Muy bien!");
                pictureCorrecto2.Visible = true;
                lblPuntaje.Text = null;
                lblPuntaje.Text = Puntuar().ToString();
                Recarga();
            }
            else
            {
                MessageBox.Show("contestaste mal");
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
                MessageBox.Show("Muy bien!");
                pictureCorrecto3.Visible = true;
                lblPuntaje.Text = null;
                lblPuntaje.Text = Puntuar().ToString();
                Recarga();
            }
            else
            {
                MessageBox.Show("contestaste mal");
                intento++;
            }
        }
    }
}
