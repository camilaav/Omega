using Omega.Properties;
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
    public partial class Cantidades : Form
    {


        public Cantidades()
        {

            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void Cantidades_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Random MyNo = new Random();
            int maxNo = 5;
            int numNo = MyNo.Next(1, maxNo);

            if (numNo == 1)
            {
                pictureBox1.Image = Resources.img1;
            }

        }
    }
}