using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regla_de_Negocios;

namespace Omega
{
    public partial class CompletarPalabra : Form
    {
        JuegoRN juegoRN = new JuegoRN();
        string palabra;
        int posicionInicial = 1;
        public static readonly string[] abecedario = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

        public CompletarPalabra()
        {
            InitializeComponent();
        }

        public void CargarPalabras()
        {
            var listaPalabras = juegoRN.ListaPalabras();
            var random = new Random();

            palabra = listaPalabras[random.Next(1, listaPalabras.Count)].Palabra;

            var letras = new List<char>();
            foreach (var letra in palabra)
            {
                letras.Add(letra);
            }

            for(int i=0;i<=letras.Count - 1;i++)
            {
                var button = new Button();
                button.Left = posicionInicial;
                button.Top = 20;
                button.Visible = true;
                button.Location = new Point(posicionInicial, 20);
                posicionInicial += 5;
                button.Text = letras[i].ToString().ToUpper();
            }

            //label1.Text = letras[0].ToString();
            //label2.Text = letras[1].ToString();
            //label3.Text = "_";
            //label4.Text = letras[3].ToString();

            //label6.Text = abecedario[random.Next(1,26)];
            //label7.Text = abecedario[random.Next(1,26)];
            //label8.Text = letras[2].ToString();

            //textBox1.Text = letras[0] + "_" + letras[2] + letras[3];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.ToUpper() == palabra.ToUpper())
            {
                MessageBox.Show("Muy bien");
                CargarPalabras();
            }
        }

        private void CompletarPalabra_Load(object sender, EventArgs e)
        {
            CargarPalabras();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            //if (label1.Text + label2.Text + label8.Text + label4.Text == palabra)
            //{
            //    MessageBox.Show("Muy bien!!!!11");
            //    CargarPalabras();
            //}
        }
    }
}
