﻿using System;
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

        int numero1;
        int numero2;
        int resultado;
        int orden; //NUMERO DE ORDEN DE RESPUESTA CORRECTA
        int fondo;
        int fondo2;
        Random randommizer = new Random();
        int contF;
        int contM;
        int contD;
        private void Limpiar()
        {
            label1.Text = null;
            label3.Text = null;
            label5.Text = null;
            label6.Text = null;
            label7.Text = null;
            label8.Text = null;
        }

        private void Resta_Load(object sender, EventArgs e)
        {
            if(this.AccessibleName == "Facil")
            {
                JuegoFacil();
            }
            else if(this.AccessibleName == "Intermedia")
            {
                JuegoMedio();
            }
            else if(this.AccessibleName == "Dificil")
            {
                JuegoDificil();
            }

            //label1.Font = new Font("K26ToyBlocks123", label1.Font.Size);
            //label2.Font = new Font("K26ToyBlocks123", label2.Font.Size);
            //label3.Font = new Font("K26ToyBlocks123", label3.Font.Size);
            //label4.Font = new Font("K26ToyBlocks123", label4.Font.Size);
            //label5.Font = new Font("K26ToyBlocks123", label5.Font.Size);
            //label6.Font = new Font("K26ToyBlocks123", label6.Font.Size);
            //label7.Font = new Font("K26ToyBlocks123", label7.Font.Size);
            //label8.Font = new Font("K26ToyBlocks123", label8.Font.Size);

            tiempo.Enabled = true;

            label5.Visible = false;

            if (orden == 0)
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



        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (orden == 0)
            {

                MessageBox.Show("Muy bien!");
                label5.Visible = true;
                label5.Text = resultado.ToString();
            }
            else
            {
                //MessageBox.Show("Respuesta incorrecta");                

                label5.Text = "X";
                label5.Visible = true;
            }
        }
        
        private void JuegoFacil()
        {
            label1.Width = 191;
            label3.Width = 191;
            contF++;
            numero1 = randommizer.Next(1, 10);
            numero2 = randommizer.Next(1, 10);
            resultado = (numero1 - numero2);

            while (resultado < 0) //ELIMINA LA POSIBILIDAD DE RESULTADO NEGATIVO
            {
                numero1 = randommizer.Next(1, 10);
                numero2 = randommizer.Next(1, 10);
                resultado = (numero1 - numero2);
            }
            //LE DA IMAGENES A LOS 3 PRIMEROS PICTUREBOX
            label1.Text = numero1.ToString();
            label3.Text = numero2.ToString();
            label5.Text = resultado.ToString();

            orden = randommizer.Next(2);//NUMERO RANDOM PARA LA POSICION DE LA RESPUESTA CORRECTA

            //NUMERO DE FONDO DE UN PICTURE DE RESPUESTAS
            fondo = randommizer.Next(1, 10);

            //NUMERO DE FONDO DEL OTRO PICTURE DE RESPUESTA
            fondo2 = randommizer.Next(1, 10);

            //VUELVE A HACER RANDOM LOS FONDOS HASTA QUE NO SEAN IGUAL AL RESULTADO
            while (resultado == fondo || resultado == fondo2 || fondo == fondo2)
            {
                fondo = randommizer.Next(1, 10);
                fondo2 = randommizer.Next(1, 10);
            }
        }
        private void JuegoMedio()
        {
            label1.Width = 191;
            label3.Width = 191;
            contM++;
            numero1 = randommizer.Next(0, 50);
            numero2 = randommizer.Next(0, 50);
            resultado = (numero1 - numero2);

            while (resultado < 0) //ELIMINA LA POSIBILIDAD DE RESULTADO NEGATIVO
            {
                numero1 = randommizer.Next(0, 50);
                numero2 = randommizer.Next(0, 50);
                resultado = (numero1 - numero2);
            }
            //LE DA IMAGENES A LOS 3 PRIMEROS PICTUREBOX
            label1.Text = numero1.ToString();
            label3.Text = numero2.ToString();
            label5.Text = resultado.ToString();
            orden = randommizer.Next(2);//NUMERO RANDOM PARA LA POSICION DE LA RESPUESTA CORRECTA

            //NUMERO DE FONDO DE UN PICTURE DE RESPUESTAS
            fondo = randommizer.Next(0, 50);

            //NUMERO DE FONDO DEL OTRO PICTURE DE RESPUESTA
            fondo2 = randommizer.Next(0, 50);

            //VUELVE A HACER RANDOM LOS FONDOS HASTA QUE NO SEAN IGUAL AL RESULTADO
            while (resultado == fondo || resultado == fondo2 || fondo == fondo2)
            {
                fondo = randommizer.Next(0, 50);
                fondo2 = randommizer.Next(0, 50);
            }

        }
        private void JuegoDificil()
        {
            label1.Width = 258;
            label3.Width = 258;
            contD++;
            numero1 = randommizer.Next(0, 100);
            numero2 = randommizer.Next(0, 100);
            resultado = (numero1 - numero2);

            while (resultado < 0) //ELIMINA LA POSIBILIDAD DE RESULTADO NEGATIVO
            {
                numero1 = randommizer.Next(0, 100);
                numero2 = randommizer.Next(0, 100);
                resultado = (numero1 - numero2);
            }
            //LE DA IMAGENES A LOS 3 PRIMEROS PICTUREBOX
            label1.Text = numero1.ToString();
            label3.Text = numero2.ToString();
            label5.Text = resultado.ToString();
            orden = randommizer.Next(2);//NUMERO RANDOM PARA LA POSICION DE LA RESPUESTA CORRECTA

            //NUMERO DE FONDO DE UN PICTURE DE RESPUESTAS
            fondo = randommizer.Next(0, 100);

            //NUMERO DE FONDO DEL OTRO PICTURE DE RESPUESTA
            fondo2 = randommizer.Next(0, 100);

            //VUELVE A HACER RANDOM LOS FONDOS HASTA QUE NO SEAN IGUAL AL RESULTADO
            while (resultado == fondo || resultado == fondo2 || fondo == fondo2)
            {
                fondo = randommizer.Next(0, 100);
                fondo2 = randommizer.Next(0, 100);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (orden == 0)
            {

                MessageBox.Show("Muy bien!");
                label5.Visible = true;
                label5.Text = resultado.ToString();
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
            }
            else
            {
                //MessageBox.Show("Respuesta incorrecta");                

                label5.Text = "X";
                label5.Visible = true;
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            }
            else
            {
                label5.Text = "X";
                label5.Visible = true;
            }
        }
    }
}
