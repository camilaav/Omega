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
using Regla_de_Negocios;

namespace Omega
{
    public partial class Dificultades : Form
    {
        JuegoRN juegoRN = new JuegoRN();
        public Dictionary<string, Form> dictionary = new Dictionary<string, Form>();
        public string nombreJuego;

        public Dificultades()
        {
            InitializeComponent();
        }

        void AbrirFormulario(string dificultad)
        {
            var formulario = dictionary[nombreJuego];
            formulario.Tag = dificultad;
            formulario.Show();
            this.Hide();
        }

        private void Dificultades_Load(object sender, EventArgs e)
        {
            dictionary.Add("suma", new Suma());
            dictionary.Add("resta", new Resta());
            dictionary.Add("cantidad", new Cantidad());
            dictionary.Add("sopa", new Sopa());
            dictionary.Add("completar", new CompletarPalabra());
            dictionary.Add("rompe", new MainForm());
            dictionary.Add("memotest", new Memotests());

            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormulario("Facil");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormulario("Intermedia");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirFormulario("Dificil");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pantalla_principal PP = new Pantalla_principal();
            PP.Show();
            this.Hide();
        }
    }
}
