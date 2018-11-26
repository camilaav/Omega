using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Omega
{
    public partial class Memotests : Form
    {
        int Movimientos = 0, CantidadFotosVolteadas = 0, TamañoColumnas = 0, TamañoFilas = 0,FotoActual = 0;
        string startupPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes");
        List<string> FotosEnumeradas, FotosRevueltas;
        string startupPathCartas = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes", "Cartas");
        int puntuacion = 0, idDificultad = 0, idJuego = 6, contadorGif;
        MovimientoHelper movimientoHelper = new MovimientoHelper();

        public void Gif()
        {
            pictureBox1.Load(startupPath + "//bien.gif");
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
            tiempo2.Enabled = true;
            tiempo2.Start();
        }

        private void Puntuar()
        {
            puntuacion = puntuacion + 25;
            lblPuntuaje.Text = puntuacion.ToString();
        }

        ArrayList FotosSeleccionadas;
        PictureBox FotoTemp1, FotoTemp2;

        private void tiempo2_Tick(object sender, EventArgs e)
        {
            contadorGif++;
            if (contadorGif == 3)
            {
                movimientoHelper.GuardarMovimiento(this, idDificultad, puntuacion, idJuego);
            }
        }

        public Memotests()
        {
            InitializeComponent();
        }

        public void Recarga()
        {
            tiempo2.Stop();
            contadorGif = 0;
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            if (this.Tag.ToString() == "Facil")
            {
                IniciarJuego(4,4);
                idDificultad = 1;

            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                IniciarJuego(5,4);
                idJuego = 2;
            }
            else if (this.Tag.ToString() == "Dificil")
            {
                IniciarJuego(6,6);
                idJuego = 3;
            }
        }
        public void IniciarJuego(int tamañoColumnas, int tamañoFilas)
        {
            TamañoColumnas = tamañoColumnas;
            TamañoFilas = tamañoFilas;
            tiempo.Enabled = false;
            tiempo.Stop();
            lblRecord.Text = "0";
            CantidadFotosVolteadas = 0;
            Movimientos = 0;
            panelJuego.Controls.Clear();
            FotosEnumeradas = new List<string>(); //Instancia que inicia las fotos enumeradas
            FotosRevueltas = new List<string>(); //Instancia que inicia las fotos revueltas
            FotosSeleccionadas = new ArrayList(); //Instancia que inicia las fotos seleccionadas
            for (int i = 0; i < (TamañoColumnas * TamañoFilas)/2 ; i++) //Ciclo for para ordenar las fotos y asignarles números de ordenamiento
            {
                FotosEnumeradas.Add(i.ToString());
                FotosEnumeradas.Add(i.ToString());
            }
            var NumRandom = new Random();
            var Resultado = FotosEnumeradas.OrderBy(item => NumRandom.Next()); //El randomizer se encarga de ordenar de forma aleatoria las fotos

            foreach (string ValorFoto in Resultado)
            {
                FotosRevueltas.Add(ValorFoto);
            }
            var tablaPanel = new TableLayoutPanel(); // Se plasman los valores en el panel a través de ésta instancia
            tablaPanel.RowCount = TamañoFilas;
            tablaPanel.ColumnCount = TamañoColumnas;
            for (int i = 0; i < TamañoColumnas; i++)
            {
                var Probabilidad = 150f / (float)TamañoColumnas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Probabilidad));//Adapta el tamaño de las columnas al de las imágenes
            }
            for (int i = 0; i < TamañoFilas; i++)
            {
                var Probabilidad = 150f / (float)TamañoFilas - 10;
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Probabilidad));// Adapta el tamaño de las filas al de las imágenes
            }
            int Contador = 1;
            for (var i = 0; i < TamañoFilas; i++)
            {
                for (var j = 0; j < TamañoColumnas; j++)
                {
                    var FotosJuego = new PictureBox();
                    FotosJuego.Name = string.Format("{0}", Contador);
                    FotosJuego.Dock = DockStyle.Fill;
                    FotosJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    FotosJuego.Image = Image.FromFile(startupPathCartas + "//" + "CartaDorso.png");
                    FotosJuego.Cursor = Cursors.Hand;
                    FotosJuego.Click += btnFoto_Click;
                    tablaPanel.Controls.Add(FotosJuego, j, i);
                    Contador++;

                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            panelJuego.Controls.Add(tablaPanel);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (FotosSeleccionadas.Count <= 2) // Cuenta los clicks sobre las imágenes
            {
                var FotoSeleccionadaJugador = (PictureBox)sender;

                var posicionJugador = int.Parse(FotoSeleccionadaJugador.Name) - 1; 

                FotoActual = int.Parse(FotosRevueltas[posicionJugador]);
                FotoSeleccionadaJugador.Image = RecuperarImagen(FotoActual);
                FotosSeleccionadas.Add(FotoSeleccionadaJugador);
                // Entra si el evento Click se realizó dos veces
                if (FotosSeleccionadas.Count == 2)
                {
                    FotoTemp1 = (PictureBox)FotosSeleccionadas[0];
                    FotoTemp2 = (PictureBox)FotosSeleccionadas[1];
                    int foto1 = Convert.ToInt32(FotosRevueltas[Convert.ToInt32(FotoTemp1.Name) - 1]);
                    int foto2 = Convert.ToInt32(FotosRevueltas[Convert.ToInt32(FotoTemp2.Name) - 1]);

                    if (foto1 != foto2)
                    {
                        tiempo.Enabled = true;
                        tiempo.Start();
                        Movimientos++;
                        lblRecord.Text = Convert.ToString(Movimientos);
                    }
                    else
                    {
                        CantidadFotosVolteadas++;

                        Puntuar();
                        if (CantidadFotosVolteadas > (TamañoColumnas  * TamañoFilas) / 2-1)
                        {
                            Gif();
                        }
                        FotoTemp1.Enabled = false;
                        FotoTemp2.Enabled = false;
                        FotosSeleccionadas.Clear();
                    }
                }
            }
        }

        public Bitmap RecuperarImagen(int NumeroImagenAsignado)
        {
            Bitmap TempImagen = new Bitmap(200, 100);
            switch (NumeroImagenAsignado)
            {
                case 0:
                    TempImagen = (Bitmap)Image.FromFile(startupPathCartas + "//" + NumeroImagenAsignado + ".png");
                    break;
                default:
                    TempImagen = (Bitmap)Image.FromFile(startupPathCartas + "//" + NumeroImagenAsignado + ".png");
                    break;

            }
            return TempImagen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Recarga();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int TiempoImagen = 1;
            if (TiempoImagen == 1)
            {
                FotoTemp1.Image = Image.FromFile(startupPathCartas + "//" + "CartaDorso.png");
                FotoTemp2.Image = Image.FromFile(startupPathCartas + "//" + "CartaDorso.png");
                FotosSeleccionadas.Clear();
                TiempoImagen = 0;
                tiempo.Stop();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var pantallaPrincipal = new Pantalla_principal();
            pantallaPrincipal.Show();
            this.Hide();
        }
    }
}
