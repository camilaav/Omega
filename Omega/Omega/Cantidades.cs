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
        Image Foto1;
        Image Foto2;
        Image Foto3;
        Image Foto4;
        Image Foto5;
        int Respuesta;
        string TipoFoto;

        public Cantidades()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
            if (pictureBox1.Image == Foto1)
            {
                Respuesta = 6;
                if (int.Parse(txtRespuesta.Text) == 6)
                {
                    MessageBox.Show("Respuesta correcta, 6 perros", "Mensaje");
                    pictureBox1.Image = Resources.Foto2;

                }

                else MessageBox.Show("Respuesta incorrecta, volvé a intentar", "Mensaje");
            }

            if (pictureBox1.Image == Foto2)
            {
                Respuesta = 4;
                if (int.Parse(txtRespuesta.Text) == 4)
                {
                    MessageBox.Show("Respuesta correcta, 4 gatos", "Mensaje");
                }
                else MessageBox.Show("Respuesta incorrecta, volvé a intentar", "Mensaje");
            }


            }
        }

        private void Cantidades_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Foto1;
            Foto1 = pictureBox1.Image;
        }
    }
}