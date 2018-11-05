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
            dificultad("rompe");
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
