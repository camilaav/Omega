using Regla_de_Negocios;
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
using Omega.Helpers;

namespace Omega
{
    public partial class Suma : Form
    {
        string startupPathNumeros = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes", "Numeros");
        int seg = 0, orden, fondo, fondo2,resultado, intento = 1, puntuacion = 0, idJuego = 2, idDificultad = 0;
        JuegoRN juegoRN = new JuegoRN();
        JuegosHelper juegoHelper = new JuegosHelper();

        Random randommizer = new Random();
        public void Recarga()
        {
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

        public Suma()
        {
            InitializeComponent();
        }

        private void opcionUno_Click(object sender, EventArgs e)
        {
            if (orden == 0)
            {
                respuestaC.Visible = true;
                respuestaC.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                respuestaC.BackgroundImageLayout = ImageLayout.Stretch;
                MessageBox.Show("Muy bien!");
                lblPuntaje.Text = null;
                lblPuntaje.Text = Puntuar().ToString();
                pictureCorrecto1.Visible = true;
                Recarga();
            }
            else
            {
                MessageBox.Show("contestaste mal");
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
                respuestaC.Visible = true;
                respuestaC.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                respuestaC.BackgroundImageLayout = ImageLayout.Stretch;
                MessageBox.Show("Muy bien!");
                lblPuntaje.Text = null;
                lblPuntaje.Text = Puntuar().ToString();
                pictureCorrecto2.Visible = true;
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
                respuestaC.Visible = true;
                respuestaC.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                respuestaC.BackgroundImageLayout = ImageLayout.Stretch;
                MessageBox.Show("Muy bien!");
                lblPuntaje.Text = null;
                lblPuntaje.Text = Puntuar().ToString();
                pictureCorrecto3.Visible = true;
                Recarga();
            }
            else
            {
                MessageBox.Show("contestaste mal");
                intento++;
            }
        }


        private void tiempo_Tick(object sender, EventArgs e)
        {
            seg -= 1;
            if (seg == 0)
            {
                tiempo.Stop();
            }
        }
        private void Suma_Load(object sender, EventArgs e)
        {
            Recarga();
        }

        public int Puntuar()
        {
            if(intento == 1)
            {
                return puntuacion = puntuacion + 100;
            }
            else if(intento == 2)
            {
                return puntuacion = puntuacion + 50;
            }
            else if(intento >= 3)
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

            while (resultado < 0) 
            {
                numero1 = randommizer.Next(limiteMenor, limiteMayor);
                numero2 = randommizer.Next(limiteMenor, limiteMayor);
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
                fondo = randommizer.Next(limiteMenor, limiteMayor);
                fondo2 = randommizer.Next(limiteMenor, limiteMayor);
            }
        }
    }
}
