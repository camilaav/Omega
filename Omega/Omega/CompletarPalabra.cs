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
using Entidades;

namespace Omega
{
    public partial class CompletarPalabra : Form
    {
        JuegoRN juegoRN = new JuegoRN();
        string palabra, randomImagen;
        int posicionInicialArriba = 0, posicionInicialCostado = 0, idDificultad = 0;
        IList<Imagen> listaImagenes = new List<Imagen>();
        PictureBox pictureVacio = new PictureBox();
        public Imagen imagen = new Imagen();
        Random random = new Random();

        public CompletarPalabra()
        {
            InitializeComponent();
        }
        public void CargarRandom()
        {
            randomImagen = random.Next(1, 51).ToString();
            listaImagenes = juegoRN.ListaImagenes();
            imagen = listaImagenes.Where(c => c.NombreImagen == randomImagen).FirstOrDefault();
        }
        public void CargarImagenes()
        {
            string startupObjetos = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes", "Objetos");
            CargarRandom();
            if (imagen == null || imagen.DescripcionImagen == string.Empty)
            {
                CargarImagenes();
            }
            panel1.BackgroundImage = Image.FromFile(startupObjetos + "//" + imagen.NombreImagen + ".png");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            palabra = imagen.DescripcionImagen;
        }

        private void opcionUno_Click(object sender, EventArgs e)
        {
            pictureVacio.Visible = true;
        }

        public void CargarPalabras()
        {
            string startupPathPalabras = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes", "Letras");

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                PictureBox control = this.Controls[i] as PictureBox;
                if (control == null) continue;

                control.Dispose();
            }
            posicionInicialArriba = 10;
            posicionInicialCostado = 10;
            var listaPalabras = juegoRN.ListaPalabras();

            var letras = new List<char>();
            foreach (var letra in palabra)
            {
                letras.Add(letra);
            }

            var opcionCorrecta = random.Next(1, letras.Count() - 1);

            opcionUno.BackgroundImage = Image.FromFile(startupPathPalabras + "//" + letras[opcionCorrecta] + ".png");
            opcionUno.BackgroundImageLayout = ImageLayout.Stretch;

            for (int i = 0; i <= letras.Count() - 1; i++)
            {
                if (i != opcionCorrecta)
                {
                    var picture = new PictureBox();
                    Controls.Add(picture);
                    picture.Name = "pictureBox" + letras[i].ToString().ToUpper();
                    picture.Size = new Size(100, 100);
                    picture.Location = new Point(posicionInicialCostado, posicionInicialArriba);
                    picture.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + letras[i].ToString().ToUpper() + ".png");
                    picture.Visible = true;
                    picture.BackgroundImageLayout = ImageLayout.Stretch;
                    picture.Enabled = true;
                    posicionInicialCostado = posicionInicialCostado + 100;
                }
                else
                {
                    Controls.Add(pictureVacio);
                    pictureVacio.Size = new Size(100, 100);
                    pictureVacio.Location = new Point(posicionInicialCostado, posicionInicialArriba);
                    pictureVacio.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + letras[i].ToString().ToUpper() + ".png");
                    pictureVacio.Visible = false;
                    pictureVacio.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureVacio.Enabled = true;
                    posicionInicialCostado = posicionInicialCostado + 100;
                }
            }
            //foreach (var letra in letras)
            //{
            //    var picture = new PictureBox();
            //    Controls.Add(picture);
            //    picture.Name = "pictureBox" + letra.ToString().ToUpper();
            //    picture.Size = new Size(100, 100);
            //    picture.Location = new Point(posicionInicialCostado, posicionInicialArriba);
            //    picture.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + letra.ToString().ToUpper() + ".png");
            //    picture.Visible = true;
            //    picture.BackgroundImageLayout = ImageLayout.Stretch;
            //    picture.Enabled = true;
            //    posicionInicialCostado = posicionInicialCostado + 100;
            //}
        }
        public void CargarJuego()
        {
            if (this.Tag.ToString() == "Facil")
            {
                idDificultad = 1;
            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                idDificultad = 2;
            }
            else if (this.Tag.ToString() == "Dificil")
            {
                idDificultad = 3;
            }
        }
        private void CompletarPalabra_Load(object sender, EventArgs e)
        {
            CargarJuego();
            CargarImagenes();
            CargarPalabras();
        }
    }
}
