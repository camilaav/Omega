﻿using System;
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

        public void dificultad()
        {
            var dificultades = new Dificultades();
            dificultades.Show();
            this.Hide();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            dificultad();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            dificultad();
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            dificultad();
        }
    }
}
