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

                    if (Respuesta == 6)
                    {
                        MessageBox.Show("Respuesta correcta, 6 perros", "Mensaje");
                        TipoFoto = "Gatos";
                        pictureBox1.Image = Resources.Gato;
                        txtRespuesta.Clear();
                    }
                }
                if (TipoFoto == "Gatos")
                {

                    if (Respuesta == 4)
                    {
                        MessageBox.Show("Respuesta correcta, 4 gatos", "Mensaje");
                        TipoFoto = "Conejos";
                        pictureBox1.Image = Resources.Conejos;

                    }

                }
                if (TipoFoto == "Conejos")
                {
                    if (Respuesta == 2)
                    {
                        MessageBox.Show("Respuesta correcta, 2 conejos", "Mensaje");
                        TipoFoto = "Peces";
                        pictureBox1.Image = Resources.Peces;

        }

                }
                if (TipoFoto == "Peces")
                {
                    if (Respuesta == 5)
                    {
                        MessageBox.Show("Respuesta correcta, 5 peces", "Mensaje");
                        TipoFoto = "Loros";
                        pictureBox1.Image = Resources.Loros;

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
            pictureBox1.Image = Resources.Perros;
            Foto = pictureBox1.Image;
            TipoFoto = "Perros";
        }
    }
}