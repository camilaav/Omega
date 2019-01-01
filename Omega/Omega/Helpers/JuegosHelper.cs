using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Omega.Helpers
{
    public class JuegosHelper
    {
        public string rutaImagenes = ConfigurationManager.AppSettings["Imagenes"].ToString();

        public int Operacion(int numeroUno, int numeroDos, string signo)
        {
            if (signo == "-")
            {
                return numeroUno - numeroDos;
            }
            else if (signo == "+")
            {
                return numeroUno + numeroDos;
            }
            else
            {
                throw new Exception("No existe un método con ese signo");
            }
        }

        public void Gif(PictureBox pictureGif, Form formulario, int sizeWidth, int sizeHeight, int locationX, int locationY, Timer timer, string nombreGif, bool needLocation)
        {
            try
            {
                if (needLocation)
                {
                    pictureGif = new PictureBox();
                    pictureGif.Size = new Size(sizeWidth, sizeHeight);
                    pictureGif.Location = new Point(locationX, locationY);
                    pictureGif.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureGif.BackColor = Color.Transparent;
                    formulario.Controls.Add(pictureGif);
                    pictureGif.BringToFront();
                    pictureGif.Name = "gif";
                }
                pictureGif.Image = Image.FromFile(rutaImagenes + nombreGif + ".png");
                pictureGif.Enabled = true;
                pictureGif.Visible = true;
                timer.Enabled = true;
                timer.Start();
            }
            catch { }
        }
    }
}
