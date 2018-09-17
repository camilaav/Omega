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
    public partial class Pantalla_principal : Form
    {
        public Pantalla_principal()
        {
            InitializeComponent();
        }

        private void Pantalla_principal_Load(object sender, EventArgs e)
        {

        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            var numeros = new Numeros();
            numeros.Show();
            this.Hide();
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            var letras = new Letras();
            letras.Show();
            this.Hide();
        }

        private void btnEntretenimiento_Click(object sender, EventArgs e)
        {
            var entretenimiento = new Entretenimiento();
            entretenimiento.Show();
            this.Hide();
        }
    }
}
