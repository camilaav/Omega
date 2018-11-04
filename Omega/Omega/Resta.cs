using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Omega.Properties;
using System.IO;
using System.Linq;
using Regla_de_Negocios;

namespace Omega
{
    public partial class Resta : Form
    {
        public Resta()
        {
            InitializeComponent();
        }
        JuegoRN juegoRN = new JuegoRN();
        int resultado;
        int orden; //NUMERO DE ORDEN DE RESPUESTA CORRECTA
        int fondo; //NUMERO DE 1 OPCION NO CORRECTA
        int fondo2; //NUMERO DE LA OTRA OPCION NO CORRECTA
        Random randommizer = new Random();

        public void Recarga()
        {
            label5.Text = "?";

            if (this.Tag.ToString() == "Facil")
            {
                 Juego(191, 1, 10);

            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                Juego(191, 0, 50);
            }
            else if (this.Tag.ToString() == "Dificil")
            {
                Juego(258, 0, 100);
            }

            label1.Font = new Font("Patchwork Stitchlings", label1.Font.Size);
            label2.Font = new Font("Patchwork Stitchlings", label2.Font.Size);
            label3.Font = new Font("Patchwork Stitchlings", label3.Font.Size);
            label4.Font = new Font("Patchwork Stitchlings", label4.Font.Size);
            label5.Font = new Font("Patchwork Stitchlings", label5.Font.Size);
            label6.Font = new Font("Patchwork Stitchlings", label6.Font.Size);
            label7.Font = new Font("Patchwork Stitchlings", label7.Font.Size);
            label8.Font = new Font("Patchwork Stitchlings", label8.Font.Size);

            tiempo.Enabled = true;
            pictureCorrecto1.Visible = false;
            pictureCorrecto2.Visible = false;
            pictureCorrecto3.Visible = false;
            label5.Visible = true;

            if (orden == 0)                                 //PONE LA RESPUESTA CORRECTA EN UNA DE LAS 3 OPCINES EN FORMA ALEATOREA
            {
                label6.Text = resultado.ToString();
                label7.Text = fondo.ToString();
                label8.Text = fondo2.ToString();
            }
            if (orden == 1)
            {
                label6.Text = fondo.ToString();
                label7.Text = resultado.ToString();
                label8.Text = fondo2.ToString();
            }
            if (orden == 2)
            {
                label6.Text = fondo2.ToString();
                label7.Text = fondo.ToString();
                label8.Text = resultado.ToString();
            }
        }

        private void Resta_Load(object sender, EventArgs e)
        {
            Recarga();
        }

        private void Juego(int width, int limiteMenor, int limiteMayor)
        {
            int numero1; //PRIMER NUMERO DE LA RESTA
            int numero2; //SEGUNDO NUMERO DE LA RESTA

            label1.Width = width;
            label3.Width = width;

            numero1 = randommizer.Next(limiteMenor, limiteMayor + 1);
            numero2 = randommizer.Next(limiteMenor, limiteMayor + 1);
            resultado = (numero1 - numero2);

            while (resultado < 0) //ELIMINA LA POSIBILIDAD DE RESULTADO NEGATIVO
            {
                numero1 = randommizer.Next(limiteMenor, limiteMayor + 1);
                numero2 = randommizer.Next(limiteMenor, limiteMayor + 1);
                resultado = (numero1 - numero2);
            }
            //LE DA IMAGENES A LOS 3 PRIMEROS PICTUREBOX
            label1.Text = numero1.ToString();
            label3.Text = numero2.ToString();
            // label5.Text = resultado.ToString();

            orden = randommizer.Next(1,4);//NUMERO RANDOM PARA LA POSICION DE LA RESPUESTA CORRECTA

            //NUMERO DE FONDO DE UN PICTURE DE RESPUESTAS
            fondo = randommizer.Next(limiteMenor, limiteMayor + 1);

            //NUMERO DE FONDO DEL OTRO PICTURE DE RESPUESTA
            fondo2 = randommizer.Next(limiteMenor, limiteMayor + 1);

            //VUELVE A HACER RANDOM LOS FONDOS HASTA QUE NO SEAN IGUAL AL RESULTADO
            while (resultado == fondo || resultado == fondo2 || fondo == fondo2)
            {
                fondo = randommizer.Next(limiteMenor, limiteMayor + 1);
                fondo2 = randommizer.Next(limiteMenor, limiteMayor + 1);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (orden == 0)
            {
                MessageBox.Show("Muy bien!");
                label5.Visible = true;
                label5.Text = resultado.ToString();
                pictureCorrecto1.Visible = true;
                Recarga();
            }
            else
            {
                //MessageBox.Show("Respuesta incorrecta");                

                label5.Text = "X";
                label5.Visible = true;
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
            if (orden == 1)
            {
                MessageBox.Show("Muy bien!");
                label5.Visible = true;
                label5.Text = resultado.ToString();
                pictureCorrecto2.Visible = true;
                Recarga();
            }
            else
            {
                //MessageBox.Show("Respuesta incorrecta");           
                label5.Text = "X";
                label5.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            if (orden == 2)
            {
                MessageBox.Show("Muy bien!");
                label5.Visible = true;
                label5.Text = resultado.ToString();
                pictureCorrecto3.Visible = true;
                Recarga();
            }
            else
            {
                label5.Text = "X";
                label5.Visible = true;
            }
        }
    }
}
