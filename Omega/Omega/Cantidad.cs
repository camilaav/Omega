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

namespace Omega
{
    public partial class Cantidad : Form
    {
        public Cantidad()
        {
            InitializeComponent();
        }

        private void Cantidad_Load(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "Facil")
            {
                Juego(1,5);

            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                Juego(5,10);
            }
            else if (this.Tag.ToString() == "Dificil")
            {
                Juego(10,20);
            }
        }

        public void Juego(int limiteMenor, int limiteMayor)
        {
            string startupPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes");

            var cantidad = new Random();

            var imagen = cantidad.Next(1, 15);
            for (int i = 1; i <= cantidad.Next(limiteMenor, limiteMayor); i++)
            {
                var pictureBox = new PictureBox();
                pictureBox.BackgroundImage = Image.FromFile(startupPath + @"\" + imagen.ToString() + ".png");
            }
        }
    }
}
