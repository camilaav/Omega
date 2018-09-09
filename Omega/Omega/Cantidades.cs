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
        Image Foto;
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
                Respuesta = int.Parse(txtRespuesta.Text);
                if (TipoFoto == "Perros")
                {

                    if (Respuesta == 6)
                    {
                        MessageBox.Show("Respuesta correcta, 6 perros", "Mensaje");
                        TipoFoto = "Gatos";
                        pictureBox1.Image = Resources.Gato;
                        txtRespuesta.Clear();
                    }
                }
                if (TipoFoto == "Gatos")
                {

                    if (Respuesta == 4)
                    {
                        MessageBox.Show("Respuesta correcta, 4 gatos", "Mensaje");
                        TipoFoto = "Conejos";
                        pictureBox1.Image = Resources.Conejos;

                    }

                }
                if (TipoFoto == "Conejos")
                {
                    if (Respuesta == 2)
                    {
                        MessageBox.Show("Respuesta correcta, 2 conejos", "Mensaje");
                        TipoFoto = "Peces";
                        pictureBox1.Image = Resources.Peces;

                    }

                }
                if (TipoFoto == "Peces")
                {
                    if (Respuesta == 5)
                    {
                        MessageBox.Show("Respuesta correcta, 5 peces", "Mensaje");
                        TipoFoto = "Loros";
                        pictureBox1.Image = Resources.Loros;

                    }


                }
                if (TipoFoto == "Loros")
                {
                    if (Respuesta == 3)
                    {
                        MessageBox.Show("Respuesta correcta, 3 loros", "Mensaje");
                        MessageBox.Show("¡Felicidades, ganaste!", "Mensaje");
                        Application.Exit();


                    }
                }

            }
        }

        private void Cantidades_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Perros;
            Foto = pictureBox1.Image;
            TipoFoto = "Perros";
        }
    }
}