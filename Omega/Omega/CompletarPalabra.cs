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
        int posicionInicialArriba = 0, posicionInicialCostado = 0, idDificultad = 0, randomImagen, respuestaCorrecta, respuestaIncorrecta1, respuestaIncorrecta2;
        IList<Imagen> listaImagenes = new List<Imagen>();
        PictureBox pictureVacio = new PictureBox();
        char[] abecedario = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        public Imagen imagen = new Imagen();
        Random random = new Random();

        public CompletarPalabra()
        {
            InitializeComponent();
        }
        public void CargarRandom()
        {
            listaImagenes = juegoRN.ListaImagenes();
            if(idDificultad == 1)
            {
                listaImagenes = listaImagenes.Where(c => c.DescripcionImagen.Length > 6).ToList();
                randomImagen = random.Next(0, listaImagenes.Count - 1);
                imagen = listaImagenes[randomImagen];
            }
            else if(idDificultad ==2)
            {
                listaImagenes = listaImagenes.Where(c => c.DescripcionImagen.Length  == 6 ).ToList();
                randomImagen = random.Next(0, listaImagenes.Count - 1);
                imagen = listaImagenes[randomImagen];
            }
            else if(idDificultad == 3)
            {
                listaImagenes = listaImagenes.Where(c => c.DescripcionImagen.Length <= 5).ToList();
                randomImagen = random.Next(0, listaImagenes.Count - 1);
                imagen = listaImagenes[randomImagen];
            }
        }

        private void opcionDos_Click(object sender, EventArgs e)
        {
            if (respuestaCorrecta == 1)
            {
                MessageBox.Show("Muy bien!");
                pictureVacio.Visible = true;
                Recarga();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }
        }

        private void opcionTres_Click(object sender, EventArgs e)
        {
            if (respuestaCorrecta == 2)
            {
                MessageBox.Show("Muy bien!");
                pictureVacio.Visible = true;
                Recarga();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }
        }

        public void CargarImagenes()
        {
            string startupObjetos = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes", "Objetos");
            if (imagen == null || imagen.DescripcionImagen == string.Empty)
            {
                CargarImagenes();
            }
            panel1.BackgroundImage = Image.FromFile(startupObjetos + "//" + imagen.NombreImagen + ".png");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void opcionUno_Click(object sender, EventArgs e)
        {
            if(respuestaCorrecta == 0)
            {
                MessageBox.Show("Muy bien!");
                pictureVacio.Visible = true;
                Recarga();

            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }
        }

        public void CargarPalabras()
        {
            CargarRandom();
            string startupPathPalabras = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes", "Letras");

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                PictureBox control = this.Controls[i] as PictureBox;
                if (control == null) continue;

                control.Dispose();
            }
            posicionInicialArriba = 10;
            posicionInicialCostado = 10;

            var letras = new List<char>();
            foreach (var letra in imagen.DescripcionImagen)
            {
                letras.Add(letra);
            }

            var opcionCorrecta = random.Next(1, letras.Count());

            for (int i = 0; i <= letras.Count() - 1; i++)
            {
                if (i != opcionCorrecta)
                {
                    var picture = new PictureBox();
                    Controls.Add(picture);
                    picture.Name = "pictureBox" + letras[i].ToString().ToUpper();
                    picture.Size = new Size(90, 90);
                    picture.Location = new Point(posicionInicialCostado, posicionInicialArriba);
                    picture.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + letras[i].ToString().ToUpper() + ".png");
                    picture.Visible = true;
                    picture.BackgroundImageLayout = ImageLayout.Stretch;
                    picture.Enabled = true;
                    posicionInicialCostado = posicionInicialCostado + 90;
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
            respuestaCorrecta = random.Next(2);

            respuestaIncorrecta1 = random.Next(1, imagen.DescripcionImagen.Length);

            respuestaIncorrecta2 = random.Next(1, imagen.DescripcionImagen.Length);

            while (opcionCorrecta == respuestaIncorrecta1 || opcionCorrecta == respuestaIncorrecta2 || respuestaIncorrecta1 == respuestaIncorrecta2)
            {
                respuestaIncorrecta1 = random.Next(1, imagen.DescripcionImagen.Length);
                respuestaIncorrecta2 = random.Next(1, imagen.DescripcionImagen.Length);
            }

            if(respuestaCorrecta == 0)
            {
                opcionUno.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + letras[opcionCorrecta].ToString() + ".png");
                opcionUno.BackgroundImageLayout = ImageLayout.Stretch;
                opcionDos.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + abecedario[respuestaIncorrecta1].ToString() + ".png");
                opcionDos.BackgroundImageLayout = ImageLayout.Stretch;
                opcionTres.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + abecedario[respuestaIncorrecta2].ToString() + ".png");
                opcionTres.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if(respuestaCorrecta == 1)
            {
                opcionUno.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + abecedario[respuestaIncorrecta1].ToString() + ".png");
                opcionUno.BackgroundImageLayout = ImageLayout.Stretch;
                opcionDos.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + letras[opcionCorrecta].ToString() + ".png");
                opcionDos.BackgroundImageLayout = ImageLayout.Stretch;
                opcionTres.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + abecedario[respuestaIncorrecta2].ToString() + ".png");
                opcionTres.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if(respuestaCorrecta == 2)
            {
                opcionUno.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + abecedario[respuestaIncorrecta2].ToString() + ".png");
                opcionUno.BackgroundImageLayout = ImageLayout.Stretch;
                opcionDos.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + abecedario[respuestaIncorrecta1].ToString() + ".png");
                opcionDos.BackgroundImageLayout = ImageLayout.Stretch;
                opcionTres.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + letras[opcionCorrecta].ToString() + ".png");
                opcionTres.BackgroundImageLayout = ImageLayout.Stretch;
            }
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

        private void Recarga()
        {
            CargarJuego();
            CargarPalabras();
            CargarImagenes();
        }
        private void CompletarPalabra_Load(object sender, EventArgs e)
        {
            Recarga();
        }
    }
}
