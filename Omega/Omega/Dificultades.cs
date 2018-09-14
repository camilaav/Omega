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
        public Dificultades()
        {
            InitializeComponent();
        }

        private void Dificultades_Load(object sender, EventArgs e)
        {
            string startupPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes");
            var listaDificultades = juegoRN.ListaDificultades();
            label1.Text = listaDificultades[0].NombreDificultad;
            label2.Text = listaDificultades[1].NombreDificultad;
            label3.Text = listaDificultades[2].NombreDificultad;
            pictureBox1.BackgroundImage = Image.FromFile(startupPath + @"\" + listaDificultades[0].NombreDificultad+".png");
            pictureBox2.BackgroundImage = Image.FromFile(startupPath + @"\" + listaDificultades[1].NombreDificultad + ".png");
            pictureBox3.BackgroundImage = Image.FromFile(startupPath + @"\" + listaDificultades[2].NombreDificultad + ".png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
