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
            
        }

        private void Cantidades_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Foto1;
            Foto1 = pictureBox1.Image;
        }
    }
}