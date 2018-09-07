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

        private void Resta_Load(object sender, EventArgs e)
        {
            Random randommizer = new Random();
            tiempo.Enabled = true;
            pictureBox4.Image = Resources._;
            pictureBox5.Image = Resources._;
            pictureBox6.Image = Resources._;
            pictureBox3.Visible = false;

            numero1 = randommizer.Next(10);
            numero2 = randommizer.Next(10);
            resultado = (numero1 - numero2);

            while (resultado < 0) //ELIMINA LA POSIBILIDAD DE RESULTADO NEGATIVO
            {
                numero1 = randommizer.Next(10);
                numero2 = randommizer.Next(10);
                resultado = (numero1 - numero2);
            }

            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + numero1.ToString() + ".png"));
            pictureBox2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + numero2.ToString() + ".png"));
            pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + resultado.ToString() + ".png"));


            resultado = (numero1 - numero2);



            // txtResultado.Text = resultado.ToString();

            //if (txtResultado.Text == resultado.ToString())
            //{
            //    MessageBox.Show("Muy bien!");
            //}


            orden = randommizer.Next(2);

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
            //while (orden == 0)
            //  orden = randommizer.Next(3);

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
            if (orden == 0)
            {
                MessageBox.Show("Muy bien!");
                pictureBox3.Visible = true;
                pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + resultado.ToString() + ".png"));
            }
            else
            {
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
                MessageBox.Show("Muy bien!");
                pictureBox3.Visible = true;
                pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + resultado.ToString() + ".png"));
            }
            else
            {
                //MessageBox.Show("Respuesta incorrecta");
                pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\cancel.png"));
                pictureBox3.Visible = true;
                tiempo.Enabled = true;
                tiempo.Start();
                if (tiempo.Interval > 10000)
                {
                    pictureBox3.Visible = false;
                    tiempo.Stop();
                }
            }
        }

        private void Rta3_Click(object sender, EventArgs e)
        {
            if (orden == 2)
            {
                MessageBox.Show("Muy bien!");
                pictureBox3.Visible = true;
                pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\" + resultado.ToString() + ".png"));
            }
            else
            {
                //MessageBox.Show("Respuesta incorrecta");
                pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img\\cancel.png"));
                pictureBox3.Visible = true;
                tiempo.Start();
            }
        }
        int n = 5;
        private void tiempo_Tick(object sender, EventArgs e)
        {
            n--;
        }

    }
}
