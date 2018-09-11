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
        int fondo;
        int fondo2;
        Random randommizer = new Random();
        int contF;
        int contM;
        int contD;

        private void Resta_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("K26ToyBlocks123", label1.Font.Size);
            tiempo.Enabled = true;

            pictureBox3.Visible = false;

            pictureBox4.Image = Resources.Menos;
            pictureBox5.Image = Resources.Menos;
            pictureBox6.Image = Resources.Menos;


            //if (Dificultado == 1)
            //{
            //    if (contF < 5)
            //    {
            //        JuegoFacil();
            //    }
            //}

            //if (Dificultad == 2)
            //{
            //    if (contM < 5)
            //    {
            //        JuegoMedio();
            //    }
            //}
            //if (Dificultad == 3)
            //{
            //    if (contF < 5)
            //    {
            //        JuegoDificil();
            //    }
            //}


            if (orden == 0)
            {
                Rta1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + resultado.ToString() + ".png"));
                Rta2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + fondo.ToString() + ".png"));
                Rta3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + fondo2.ToString() + ".png"));
            }
            if (orden == 1)
            {
                Rta1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + fondo.ToString() + ".png"));
                Rta2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + resultado.ToString() + ".png"));
                Rta3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + fondo2.ToString() + ".png"));
            }
            if (orden == 2)
            {
                Rta1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + fondo2.ToString() + ".png"));
                Rta2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + fondo.ToString() + ".png"));
                Rta3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + resultado.ToString() + ".png"));
            }
        }

      

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (orden == 0)
            {
                pictureBox3.Image = null;
                MessageBox.Show("Muy bien!");
                pictureBox3.Visible = true;
                pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + resultado.ToString() + ".png"));
            }
            else
            {
                pictureBox3.Image = null;
                //MessageBox.Show("Respuesta incorrecta");                
                pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\cancel.png"));
                pictureBox3.Visible = true;
                tiempo.Enabled = true;
                tiempo.Start();
                if (tiempo.Interval > 10000)
                {
                    pictureBox3.Visible = false;
                }
            }
        }

        private void Rta2_Click(object sender, EventArgs e)
        {
            if (orden == 1)
            {
                pictureBox3.Image = null;
                MessageBox.Show("Muy bien!");
                pictureBox3.Visible = true;
                pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + resultado.ToString() + ".png"));
            }
            else
            {
                pictureBox3.Image = null;
                //MessageBox.Show("Respuesta incorrecta");
                pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\cancel.png"));
                pictureBox3.Visible = true;
            }
        }

        private void Rta3_Click(object sender, EventArgs e)
        {
            if (orden == 2)
            {
                pictureBox3.Image = null;
                MessageBox.Show("Muy bien!");
                pictureBox3.Visible = true;
                pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + resultado.ToString() + ".png"));
            }
            else
            {
                pictureBox3.Image = null;
                //MessageBox.Show("Respuesta incorrecta");
                pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\cancel.png"));
                pictureBox3.Visible = true;
                tiempo.Start();
            }
        }
        private void JuegoFacil()
        {
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
            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + numero1.ToString() + ".png"));
            pictureBox2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + numero2.ToString() + ".png"));
            pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + resultado.ToString() + ".png"));

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
            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + numero1.ToString() + ".png"));
            pictureBox2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + numero2.ToString() + ".png"));
            pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + resultado.ToString() + ".png"));

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
            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + numero1.ToString() + ".png"));
            pictureBox2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + numero2.ToString() + ".png"));
            pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + resultado.ToString() + ".png"));

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
    }
}
