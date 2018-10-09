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

        public void dificultad()
        {
            var dificultades = new Dificultades();
            dificultades.Show();
            this.Hide();
        }

        private void btnRompecabezas_Click(object sender, EventArgs e)
        {
            dificultad();
        }

        private void btnMemotest_Click(object sender, EventArgs e)
        {
            dificultad();
        }

        private void btnColorear_Click(object sender, EventArgs e)
        {
            var colorear = new Colorear();
            colorear.Show();
            this.Hide();
        }
    }
}
