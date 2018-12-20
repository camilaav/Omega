using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ReglaDeNegocios;
using Entidades;
using System.Configuration;
using Omega.Helpers;

namespace Omega
{
    public partial class CompletarPalabra : Form
    {
        JuegoRN juegoRN = new JuegoRN();
        int posicionInicialArriba = 0, posicionInicialCostado = 0, idDificultad = 0, randomImagen, respuestaCorrecta, respuestaIncorrecta1, respuestaIncorrecta2, intento = 1, puntuacion = 0, contadorGif = 0;
        IList<Imagen> listaImagenes = new List<Imagen>();
        PictureBox pictureGif = new PictureBox();
        PictureBox pictureVacio = new PictureBox();
        public string rutaImagenes = ConfigurationManager.AppSettings["Imagenes"].ToString();
        char[] abecedario = { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        public Imagen imagen = new Imagen();
        Random random = new Random();
        JuegosHelper juegosHelper = new JuegosHelper();

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
                juegosHelper.Gif(pictureGif, this, 654, 430, 155, 219, tiempo, "/bien",true);
                pictureVacio.Visible = true;
                Puntuar();
            }
            else
            {
                juegosHelper.Gif(pictureGif, this, 654, 430, 155, 219, tiempo2, "/mal",true);
                intento++;
            }
        }

        private void opcionTres_Click(object sender, EventArgs e)
        {
            if (respuestaCorrecta == 2)
            {
                juegosHelper.Gif(pictureGif, this, 654, 430, 155, 219, tiempo, "/bien",true);
                pictureVacio.Visible = true;
                Puntuar();
            }
            else
            {
                juegosHelper.Gif(pictureGif, this, 654, 430, 155, 219, tiempo2, "/mal",true);
                intento++;
            }
        }

        public void CargarImagenes()
        {
            string startupObjetos = rutaImagenes + "//Objetos";
            if (imagen == null || imagen.DescripcionImagen == string.Empty)
            {
                CargarImagenes();
            }
            panel1.BackgroundImage = Image.FromFile(startupObjetos + "//" + imagen.NombreImagen + ".png");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void tiempo2_Tick(object sender, EventArgs e)
        {
            contadorGif++;
            if (contadorGif == 1)
            {
                pictureGif.Visible = false;
                pictureGif.Enabled = false;
                tiempo2.Stop();
                contadorGif = 0;
            }
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            contadorGif++;
            if (contadorGif == 1)
            {
                Recarga();
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            var pantallaPrincipal = new Pantalla_principal();
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void opcionUno_Click(object sender, EventArgs e)
        {
            if(respuestaCorrecta == 0)
            {
                juegosHelper.Gif(pictureGif, this, 654, 430, 155, 219, tiempo, "/bien",true);
                pictureVacio.Visible = true;
                Puntuar();
            }
            else
            {
                juegosHelper.Gif(pictureGif, this, 654, 430, 155, 219, tiempo2, "/mal",true);
                intento++;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Letras letra = new Letras();
            this.Close();
            letra.Show();
        }

        public void CargarPalabras()
        {
            CargarRandom();
            string startupPathPalabras = rutaImagenes + "//Letras";

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                PictureBox control = this.Controls[i] as PictureBox;
                if (control == null) continue;

                control.Dispose();
            }
            posicionInicialArriba = 150;
            posicionInicialCostado = 130;

            var letras = new List<char>();
            foreach (var letra in imagen.DescripcionImagen)
            {
                letras.Add(letra);
            }

            var opcionCorrecta = random.Next(1, letras.Count - 1);

            for (int i = 0; i <= letras.Count() - 1; i++)
            {
                if (i != opcionCorrecta)
                {
                    var picture = new PictureBox();
                    Controls.Add(picture);
                    picture.Name = "pictureBox" + letras[i].ToString().ToUpper();
                    picture.Size = new Size(70, 70);
                    picture.Location = new Point(posicionInicialCostado, posicionInicialArriba);
                    picture.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + letras[i].ToString().ToUpper() + ".png");
                    picture.Visible = true;
                    picture.BackColor = Color.Transparent;
                    picture.BackgroundImageLayout = ImageLayout.Stretch;
                    picture.Enabled = true;
                    posicionInicialCostado = posicionInicialCostado + 70;
                }
                else
                {
                    Controls.Add(pictureVacio);
                    pictureVacio.Size = new Size(70, 70);
                    pictureVacio.Location = new Point(posicionInicialCostado, posicionInicialArriba);
                    pictureVacio.BackColor = Color.Transparent;
                    pictureVacio.BackgroundImage = Image.FromFile(startupPathPalabras + @"\" + letras[i].ToString().ToUpper() + ".png");
                    pictureVacio.Visible = false;
                    pictureVacio.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureVacio.Enabled = true;
                    posicionInicialCostado = posicionInicialCostado + 70;
                }
            }
            respuestaCorrecta = random.Next(2);

            respuestaIncorrecta1 = random.Next(1, abecedario.Length - 1);

            respuestaIncorrecta2 = random.Next(1, abecedario.Length - 1);

            while (letras[opcionCorrecta] == abecedario[respuestaIncorrecta1] || letras[opcionCorrecta] == abecedario[respuestaIncorrecta2] || abecedario[respuestaIncorrecta1] == abecedario[respuestaIncorrecta2])
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
            tiempo.Stop();
            contadorGif = 0;
            pictureGif.Visible = false;
            pictureGif.Enabled = false;
            intento = 1;
            lblPuntaje.Text = puntuacion.ToString();
            pictureVacio = new PictureBox();
            CargarJuego();
            CargarPalabras();
            CargarImagenes();
        }
        private void CompletarPalabra_Load(object sender, EventArgs e)
        {
            Recarga();
        }

        public int Puntuar()
        {
            if (intento == 1)
            {
                return puntuacion = puntuacion + 100;
            }
            else if (intento == 2)
            {
                return puntuacion = puntuacion + 50;
            }
            else if (intento >= 3)
            {
                return puntuacion = puntuacion + 25;
            }
            else
            {
                return puntuacion = puntuacion + 0;
            }
        }
    }
}
