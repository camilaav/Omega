using Omega.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    public partial class Cantidades : Form
    {

        private void GenerarJuego()
        {
            Random MyNo = new Random();
            int maxNo = 5;
            int numNo = MyNo.Next(1, maxNo);
            label1.Text = numNo.ToString();

            if (numNo == 1)
            {
                pbAnimales.Image = Resources.P1;
                pbAnimales.Tag = "A";
                pb1.Image = Resources._1;
                pb2.Image = Resources._4;
                pb3.Image = Resources._5;

            }
            if (numNo == 2)
            {
                pbAnimales.Image = Resources.P2;
                pbAnimales.Tag = "B";
                pb1.Image = Resources._3;
                pb2.Image = Resources._5;
                pb3.Image = Resources._8;
            }
            if (numNo == 3)
            {
                pbAnimales.Image = Resources.P3;
                pb1.Image = Resources._9;
                pb2.Image = Resources._3;
                pb3.Image = Resources._2;

            }
            if (numNo == 4)
            {
                pbAnimales.Image = Resources.P4;
                pb1.Image = Resources._4;
                pb2.Image = Resources._7;
                pb3.Image = Resources._1;
            }
            if (numNo == 5)
            {
                pbAnimales.Image = Resources.P5;
                pb1.Image = Resources._7;
                pb2.Image = Resources._3;
                pb3.Image = Resources._4;
            }
        }
        public Cantidades()
        {

            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void Cantidades_Load(object sender, EventArgs e)
        {
            GenerarJuego();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pb1_Click(object sender, EventArgs e)
        {
            if(pbAnimales.Tag.ToString() == "A")
            {
                MessageBox.Show("Bien!");
            }
            else
            {
                MessageBox.Show("¡Mal!");
            }
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if(pbAnimales.Tag.ToString() == "B")
            {
                MessageBox.Show("Bien!");
            }
            else
            {
                MessageBox.Show("¡Mal!");
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {

        }
    }
}