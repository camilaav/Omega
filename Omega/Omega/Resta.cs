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

namespace Omega
{
    public partial class Resta : Form
    {
        public Resta()
        {
            InitializeComponent();
        }
        int numero1;
        int numero2;
        int resultado;
        int orden; //NUMERO DE ORDEN DE RESPUESTA CORRECTA

        private void Resta_Load(object sender, EventArgs e)
        {
            Random randommizer = new Random();

            pictureBox4.Image = Resources._;
            pictureBox5.Image = Resources._;
            pictureBox6.Image = Resources._;

            numero1 = randommizer.Next(10);
            numero2 = randommizer.Next(10);
            resultado = (numero1 - numero2);
           
            while (resultado < 0) //ELIMINA LA POSIBILIDAD DE RESULTADO NEGATIVO
            {
                numero1 = randommizer.Next(10);
                numero2 = randommizer.Next(10);
                resultado = (numero1 - numero2);
            }
            if (numero1 == 1)
                pictureBox1.Image = Resources._1;
            if (numero1 == 2)
                pictureBox1.Image = Resources._2;
            if (numero1 == 3)
                pictureBox1.Image = Resources._3;
            if (numero1 == 4)
                pictureBox1.Image = Resources._4;
            if (numero1 == 5)
                pictureBox1.Image = Resources._5;
            if (numero1 == 6)
                pictureBox1.Image = Resources._6;
            if (numero1 == 7)
                pictureBox1.Image = Resources._7;
            if (numero1 == 8)
                pictureBox1.Image = Resources._8;
            if (numero1 == 9)
                pictureBox1.Image = Resources._9;
            if (numero1 == 0)
                pictureBox1.Image = Resources._0;

            //resultado = (numero1 - numero2);



            //if (numero1 > 5)
            //{
            //    txtNumero2.Text = randommizer.Next(5).ToString();
            //}
            //else
            //    txtNumero2.Text = randommizer.Next(10).ToString();


            //numero2 = int.Parse(txtNumero2.Text);
            if (numero2 == 1)
                pictureBox2.Image = Resources._1;
            if (numero2 == 2)
                pictureBox2.Image = Resources._2;
            if (numero2 == 3)
                pictureBox2.Image = Resources._3;
            if (numero2 == 4)
                pictureBox2.Image = Resources._4;
            if (numero2 == 5)
                pictureBox2.Image = Resources._5;
            if (numero2 == 6)
                pictureBox2.Image = Resources._6;
            if (numero2 == 7)
                pictureBox2.Image = Resources._7;
            if (numero2 == 8)
                pictureBox2.Image = Resources._8;
            if (numero2 == 9)
                pictureBox2.Image = Resources._9;
            if (numero2 == 0)
                pictureBox2.Image = Resources._0;

            resultado = (numero1 - numero2);

            if (resultado == 1)
                pictureBox3.Image = Resources._1;
            if (resultado == 2)
                pictureBox3.Image = Resources._2;
            if (resultado == 3)
                pictureBox3.Image = Resources._3;
            if (resultado == 4)
                pictureBox3.Image = Resources._4;
            if (resultado == 5)
                pictureBox3.Image = Resources._5;
            if (resultado == 6)
                pictureBox3.Image = Resources._6;
            if (resultado == 7)
                pictureBox3.Image = Resources._7;
            if (resultado == 8)
                pictureBox3.Image = Resources._8;
            if (resultado == 9)
                pictureBox3.Image = Resources._9;
            if (resultado == 0)
                pictureBox3.Image = Resources._0;

            // txtResultado.Text = resultado.ToString();

            //if (txtResultado.Text == resultado.ToString())
            //{
            //    MessageBox.Show("Muy bien!");
            //}

            
            orden = randommizer.Next(3);

            int fondo; //NUMERO DE FONDO DE UN PICTURE DE RESPUESTAS
            fondo = randommizer.Next(10);

            int fondo2; //NUMERO DE FONDO DEL OTRO PICTURE DE RESPUESTA
            fondo2 = randommizer.Next(10);


            //VUELVE A HACER RANDOM LOS FONDOS HASTA QUE NO SEAN IGUAL AL RESULTADO
            while (resultado == fondo || resultado == fondo2 || fondo == fondo2)
            {
                fondo = randommizer.Next(10);
                fondo2 = randommizer.Next(10);
            }
            while (orden == 0)
                orden = randommizer.Next(3);

            if (orden == 1)
            {
                
                if (resultado == 1)
                {
                    Rta1.Image = Resources._1;

                    //LE DA IMAGEN AL PRIMER RESPUESTA NO CORRECTA
                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;

                }

                if (resultado == 2)
                {
                    Rta1.Image = Resources._2;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 3)
                {
                    Rta1.Image = Resources._3;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 4)
                {
                    Rta1.Image = Resources._4;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 5)
                {
                    Rta1.Image = Resources._5;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 6)
                {
                    Rta1.Image = Resources._6;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 7)
                {
                    Rta1.Image = Resources._7;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 8)
                {
                    Rta1.Image = Resources._8;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 9)
                {
                    Rta1.Image = Resources._9;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 0)
                {
                    Rta1.Image = Resources._0;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

            }

            if (orden == 2)
            {
                
                if (resultado == 1)
                {
                    Rta2.Image = Resources._1;

                    //LE DA IMAGEN AL PRIMER RESPUESTA NO CORRECTA
                    if (fondo == 1)
                        Rta1.Image = Resources._1;
                    if (fondo == 2)
                        Rta1.Image = Resources._2;
                    if (fondo == 3)
                        Rta1.Image = Resources._3;
                    if (fondo == 4)
                        Rta1.Image = Resources._4;
                    if (fondo == 5)
                        Rta1.Image = Resources._5;
                    if (fondo == 6)
                        Rta1.Image = Resources._6;
                    if (fondo == 7)
                        Rta1.Image = Resources._7;
                    if (fondo == 8)
                        Rta1.Image = Resources._8;
                    if (fondo == 9)
                        Rta1.Image = Resources._9;
                    if (fondo == 0)
                        Rta1.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;

                }

                if (resultado == 2)
                {
                    Rta1.Image = Resources._2;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 3)
                {
                    Rta1.Image = Resources._3;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 4)
                {
                    Rta1.Image = Resources._4;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 5)
                {
                    Rta1.Image = Resources._5;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 6)
                {
                    Rta1.Image = Resources._6;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 7)
                {
                    Rta1.Image = Resources._7;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 8)
                {
                    Rta1.Image = Resources._8;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 9)
                {
                    Rta1.Image = Resources._9;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }

                if (resultado == 0)
                {
                    Rta1.Image = Resources._0;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta3.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta3.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta3.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta3.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta3.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta3.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta3.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta3.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta3.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta3.Image = Resources._0;
                }
            }
            if (orden == 3)
            {              
                if (resultado == 1)
                {
                    Rta3.Image = Resources._1;

                    //LE DA IMAGEN AL PRIMER RESPUESTA NO CORRECTA
                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta1.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta1.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta1.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta1.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta1.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta1.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta1.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta1.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta1.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta1.Image = Resources._0;

                }

                if (resultado == 2)
                {
                    Rta3.Image = Resources._2;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta1.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta1.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta1.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta1.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta1.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta1.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta1.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta1.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta1.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta1.Image = Resources._0;
                }

                if (resultado == 3)
                {
                    Rta3.Image = Resources._3;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta1.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta1.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta1.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta1.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta1.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta1.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta1.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta1.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta1.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta1.Image = Resources._0;
                }

                if (resultado == 4)
                {
                    Rta3.Image = Resources._4;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta1.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta1.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta1.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta1.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta1.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta1.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta1.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta1.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta1.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta1.Image = Resources._0;
                }

                if (resultado == 5)
                {
                    Rta3.Image = Resources._5;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta1.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta1.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta1.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta1.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta1.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta1.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta1.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta1.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta1.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta1.Image = Resources._0;
                }

                if (resultado == 6)
                {
                    Rta3.Image = Resources._6;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta1.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta1.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta1.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta1.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta1.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta1.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta1.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta1.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta1.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta1.Image = Resources._0;
                }

                if (resultado == 7)
                {
                    Rta3.Image = Resources._7;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta1.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta1.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta1.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta1.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta1.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta1.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta1.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta1.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta1.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta1.Image = Resources._0;
                }

                if (resultado == 8)
                {
                    Rta3.Image = Resources._8;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta1.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta1.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta1.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta1.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta1.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta1.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta1.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta1.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta1.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta1.Image = Resources._0;
                }

                if (resultado == 9)
                {
                    Rta3.Image = Resources._9;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta1.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta1.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta1.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta1.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta1.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta1.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta1.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta1.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta1.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta1.Image = Resources._0;
                }

                if (resultado == 0)
                {
                    Rta3.Image = Resources._0;

                    if (fondo == 1)
                        Rta2.Image = Resources._1;
                    if (fondo == 2)
                        Rta2.Image = Resources._2;
                    if (fondo == 3)
                        Rta2.Image = Resources._3;
                    if (fondo == 4)
                        Rta2.Image = Resources._4;
                    if (fondo == 5)
                        Rta2.Image = Resources._5;
                    if (fondo == 6)
                        Rta2.Image = Resources._6;
                    if (fondo == 7)
                        Rta2.Image = Resources._7;
                    if (fondo == 8)
                        Rta2.Image = Resources._8;
                    if (fondo == 9)
                        Rta2.Image = Resources._9;
                    if (fondo == 0)
                        Rta2.Image = Resources._0;
                    //LE DA IMAGEN AL SEGUNDO RESPUESTA NO CORRECTA
                    if (fondo2 == 1)
                        Rta1.Image = Resources._1;
                    if (fondo2 == 2)
                        Rta1.Image = Resources._2;
                    if (fondo2 == 3)
                        Rta1.Image = Resources._3;
                    if (fondo2 == 4)
                        Rta1.Image = Resources._4;
                    if (fondo2 == 5)
                        Rta1.Image = Resources._5;
                    if (fondo2 == 6)
                        Rta1.Image = Resources._6;
                    if (fondo2 == 7)
                        Rta1.Image = Resources._7;
                    if (fondo2 == 8)
                        Rta1.Image = Resources._8;
                    if (fondo2 == 9)
                        Rta1.Image = Resources._9;
                    if (fondo2 == 0)
                        Rta1.Image = Resources._0;
                }

            }

        }

        private void Resta_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muy bien!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (orden == 1)
                MessageBox.Show("Muy bien!");
            else
                MessageBox.Show("Respuesta incorrecta");
        }

        private void Rta2_Click(object sender, EventArgs e)
        {
            if (orden == 2)
                MessageBox.Show("Muy bien!");
            else
                MessageBox.Show("Respuesta incorrecta");
        }

        private void Rta3_Click(object sender, EventArgs e)
        {
            if (orden == 3)
                MessageBox.Show("Muy bien!");
            else
                MessageBox.Show("Respuesta incorrecta");
        }
    }
}
