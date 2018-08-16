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

           // if (numero1 == 0)
           //     pictureBox1.Image 

            txtNumero1.Text = randommizer.Next(10).ToString();
            numero1 = int.Parse(txtNumero1.Text);
            if (numero1 > 5)
            {
                txtNumero2.Text = randommizer.Next(5).ToString();
            }
            else
                txtNumero2.Text = randommizer.Next(10).ToString();

            numero2 = int.Parse(txtNumero2.Text);

            resultado = numero1 + numero2;
            if (txtResultado.Text == resultado.ToString())
            {
                MessageBox.Show("Muy bien!");
            }
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
    }
}
