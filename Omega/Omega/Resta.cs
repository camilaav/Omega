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
        private void Resta_Load(object sender, EventArgs e)
        {
            Random randommizer = new Random();

            pictureBox4.Image = Resources._;
            pictureBox5.Image = Resources._;
            pictureBox6.Image = Resources._;

            numero1 = randommizer.Next(10);
            numero2 = randommizer.Next(10);
            resultado = (numero1 - numero2);
            while (resultado < 0)
            {
                numero1 = randommizer.Next(10);
                numero2 = randommizer.Next(10);
                resultado = (numero1 - numero2);
            }
            if (numero1 == 1)
                pictureBox1.Image = Resources._11;
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
                pictureBox2.Image = Resources._11;
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
                pictureBox3.Image = Resources._11;
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
        }

        private void Resta_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == resultado.ToString())
            {
                MessageBox.Show("Muy bien!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
