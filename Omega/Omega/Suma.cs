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

namespace Omega
{
    public partial class Suma : Form
    {
        string startupPathNumeros = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes", "Numeros");
        int seg = 0, orden, fondo, fondo2,resultado;
        JuegoRN juegoRN = new JuegoRN();

        Random randommizer = new Random();
        public void Recarga()
        {
            respuestaC.Visible = false;

            if (this.Tag.ToString() == "Facil")
            {
                Juego(1, 10);

            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                Juego(0, 50);
            }
            else if (this.Tag.ToString() == "Dificil")
            {
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
                pictureCorrecto1.Visible = true;
                Recarga();
            }
        }

        private void opcionDos_Click(object sender, EventArgs e)
        {
            if (orden == 1)
            {
                respuestaC.Visible = true;
                respuestaC.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + resultado.ToString() + ".png");
                respuestaC.BackgroundImageLayout = ImageLayout.Stretch;
                MessageBox.Show("Muy bien!");
                pictureCorrecto2.Visible = true;
                Recarga();
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
                pictureCorrecto3.Visible = true;
                Recarga();
            }
        }


        private void tiempo_Tick(object sender, EventArgs e)
        {
            seg -= 1;
            if (seg == 0)
            {
                tiempo.Stop();
                //lblRespuesta.Visible = false;
            }
        }
        private void Suma_Load(object sender, EventArgs e)
        {
            Recarga();
        }

        private void Juego(int limiteMenor, int limiteMayor)
        {
            int numero1;
            int numero2;

            numero1 = randommizer.Next(limiteMenor, limiteMayor);
            numero2 = randommizer.Next(limiteMenor, limiteMayor);
            resultado = (numero1 + numero2);

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
