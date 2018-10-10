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
        public Suma()
        {
            InitializeComponent();
        }

        int num1, num2, rpt, op1, op2, orden, intentos, seg = 0;
        Random rdm = new Random();
        void NumerosRandom()
        {
            pictureCorrecto1.Visible = false;
            pictureCorrecto2.Visible = false;
            pictureCorrecto3.Visible = false;
            num1 = rdm.Next(1, 11);
            num2 = rdm.Next(1, 11);
            rpt = num1 + num2;
            op1 = rdm.Next(1, 11);
            op2 = rdm.Next(1, 11);
            orden = rdm.Next(1, 4);
            if (rpt < 11 && rpt != op1 && rpt != op2 && op1 != op2)
            {
                if (orden == 1)
                {
                    numeroUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + num1.ToString() + ".png");
                    numeroUno.BackgroundImageLayout = ImageLayout.Stretch;
                    numeroUno.Name = num1.ToString();
                    numeroDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + num2.ToString() + ".png");
                    numeroDos.BackgroundImageLayout = ImageLayout.Stretch;
                    numeroDos.Name = num2.ToString();
                    opcionUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + rpt.ToString() + ".png");
                    opcionUno.BackgroundImageLayout = ImageLayout.Stretch;
                    opcionUno.Name = rpt.ToString();
                    opcionDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + op1.ToString() + ".png");
                    opcionDos.BackgroundImageLayout = ImageLayout.Stretch;
                    opcionDos.Name = op1.ToString();
                    opcionTres.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + op2.ToString() + ".png");
                    opcionTres.BackgroundImageLayout = ImageLayout.Stretch;
                    opcionTres.Name = op2.ToString();

                }
                else if (orden == 2)
                {
                    numeroUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + num1.ToString() + ".png");
                    numeroUno.BackgroundImageLayout = ImageLayout.Stretch;
                    numeroUno.Name = num1.ToString();
                    numeroDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + num2.ToString() + ".png");
                    numeroDos.BackgroundImageLayout = ImageLayout.Stretch;
                    numeroDos.Name = num2.ToString();
                    opcionUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + op1.ToString() + ".png");
                    opcionUno.BackgroundImageLayout = ImageLayout.Stretch;
                    opcionUno.Name = op1.ToString();
                    opcionDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + rpt.ToString() + ".png");
                    opcionDos.BackgroundImageLayout = ImageLayout.Stretch;
                    opcionDos.Name = rpt.ToString();
                    opcionTres.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + op2.ToString() + ".png");
                    opcionTres.BackgroundImageLayout = ImageLayout.Stretch;
                    opcionTres.Name = op2.ToString();
                }
                else if (orden == 3)
                {
                    numeroUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + num1.ToString() + ".png");
                    numeroUno.BackgroundImageLayout = ImageLayout.Stretch;
                    numeroUno.Name = num1.ToString();
                    numeroDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + num2.ToString() + ".png");
                    numeroDos.BackgroundImageLayout = ImageLayout.Stretch;
                    numeroDos.Name = num2.ToString();
                    opcionUno.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + op1.ToString() + ".png");
                    opcionUno.BackgroundImageLayout = ImageLayout.Stretch;
                    opcionUno.Name = op1.ToString();
                    opcionDos.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + op2.ToString() + ".png");
                    opcionDos.BackgroundImageLayout = ImageLayout.Stretch;
                    opcionDos.Name = op2.ToString();
                    opcionTres.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + rpt.ToString() + ".png");
                    opcionTres.BackgroundImageLayout = ImageLayout.Stretch;
                    opcionTres.Name = rpt.ToString();
                }
            }
            else
            {
                NumerosRandom();
            }
        }

        private void opcionUno_Click(object sender, EventArgs e)
        {
            if (rpt == int.Parse(opcionUno.Name))
            {
                RespuestaCorrecta();
                pictureCorrecto1.Visible = true;
            }
            else
            {
                RespuestaIncorrecta();
            }
        }

        private void opcionDos_Click(object sender, EventArgs e)
        {
            if (rpt == int.Parse(opcionDos.Name))
            {
                RespuestaCorrecta();
                pictureCorrecto1.Visible = true;
            }
            {
                RespuestaIncorrecta();
            }
        }

        private void opcionTres_Click(object sender, EventArgs e)
        {
            if (rpt == int.Parse(opcionTres.Name))
            {
                RespuestaCorrecta();
                pictureCorrecto1.Visible = true;
            }
            else
            {
                RespuestaIncorrecta();
            }
        }

        void RespuestaCorrecta()
        {
            respuestaC.BackgroundImage = Image.FromFile(startupPathNumeros + @"\" + rpt.ToString() + ".png");
            respuestaC.BackgroundImageLayout = ImageLayout.Stretch;
            tiempo.Stop();
            MessageBox.Show("bien");
            if (intentos == 0)
            {
                lblPuntaje.Text = (int.Parse(lblPuntaje.Text) + 100).ToString();
                intentos = 0;
            }
            else if (intentos == 1)
            {
                lblPuntaje.Text = (int.Parse(lblPuntaje.Text) + 50).ToString();
                intentos = 0;
            }
            else if (intentos == 2)
            {
                lblPuntaje.Text = (int.Parse(lblPuntaje.Text) + 25).ToString();
                intentos = 0;
            }
            else if (intentos >= 3)
            {
                lblPuntaje.Text = (int.Parse(lblPuntaje.Text) + 0).ToString();
                intentos = 0;
            }
            NumerosRandom();
        }
        void RespuestaIncorrecta()
        {
            //lblRespuesta.Text = "X";
            //lblRespuesta.Visible = true;
            seg = 3;
            tiempo.Start();
            intentos++;
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
            NumerosRandom();
        }
    }
}
