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
    public partial class Letras : Form
    {
        public Letras()
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

        private void btnCompletas_Click(object sender, EventArgs e)
        {
            dificultad("completar");
        }

        private void btnSopa_Click(object sender, EventArgs e)
        {
            dificultad("sopa");
        }
    }
}
