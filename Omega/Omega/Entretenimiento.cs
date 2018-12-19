using System;
using System.Windows.Forms;

namespace Omega
{
    public partial class Entretenimiento : Form
    {
        public Entretenimiento()
        {
            InitializeComponent();
        }

        public void dificultad(string nombreJuego)
        {
            var dificultades = new Dificultades();
            dificultades.nombreJuego = nombreJuego;
            dificultades.Show();
            this.Hide();
        }

        private void btnRompecabezas_Click(object sender, EventArgs e)
        {
            var rompecabezas = new Rompecabezas();
            rompecabezas.Show();
            this.Hide();
        }

        private void btnMemotest_Click(object sender, EventArgs e)
        {
            dificultad("memotest");
        }

        private void btnColorear_Click(object sender, EventArgs e)
        {
            var colorear = new Colorear();
            colorear.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pantalla_principal PP = new Pantalla_principal();
            PP.Show();
            this.Hide();
        }
    }
}
