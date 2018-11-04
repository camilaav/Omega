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
    public partial class Numeros : Form
    {
        public Numeros()
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

        private void btnSuma_Click(object sender, EventArgs e)
        {
            dificultad("suma");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            dificultad("resta");
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            dificultad("cantidad");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pantalla_principal PP = new Pantalla_principal();
            PP.Show();
            this.Hide();
        }
    }
}
