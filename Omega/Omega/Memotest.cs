using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Omega
{
    public partial class Memotest : Form
    {

        int TamañoColumnasFilas = 4;
        int Movimientos = 0;
        int CantidadFotosVolteadas = 0;
        List<string> FotosEnumeradas;
        List<string> FotosRevueltas;
        ArrayList FotosSeleccionadas;
        PictureBox FotoTemp1;
        PictureBox FotoTemp2;
        int FotoActual = 0;


        public Memotest()
        {
            InitializeComponent();
            IniciarJuego(); //Invocar al método Iniciar Juego
        }
        public void IniciarJuego()
        {
            /* ESTRUCTURA DE DISEÑO */

            timer1.Enabled = false;
            timer1.Stop();
            lblRecord.Text = "0";
            CantidadFotosVolteadas = 0;
            Movimientos = 0;
            panelJuego.Controls.Clear();
            FotosEnumeradas = new List<string>(); //Instancia que inicia las fotos enumeradas
            FotosRevueltas = new List<string>(); //Instancia que inicia las fotos revueltas
            FotosSeleccionadas = new ArrayList(); //Instancia que inicia las fotos seleccionadas
            for (int i = 0; i < 8; i++) //Ciclo for para ordenar las fotos y asignarles números de ordenamiento
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
            tablaPanel.RowCount = TamañoColumnasFilas;
            tablaPanel.ColumnCount = TamañoColumnasFilas;
            for (int i = 0; i < TamañoColumnasFilas; i++)
            {
                var Probabilidad = 150f / (float)TamañoColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Probabilidad));//Adapta el tamaño de las columnas al de las imágenes
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Probabilidad));// Adapta el tamaño de las filas al de las imágenes
            }
            int Contador = 1;
            for (var i = 0; i < TamañoColumnasFilas; i++)
            {
                for (var j = 0; j < TamañoColumnasFilas; j++)
                {
                    var FotosJuego = new PictureBox();
                    FotosJuego.Name = string.Format("{0}", Contador);
                    FotosJuego.Dock = DockStyle.Fill;
                    FotosJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    FotosJuego.Image = Omega.Properties.Resources.Volteo;
                    FotosJuego.Cursor = Cursors.Hand;
                    FotosJuego.Click += btnFoto_Click;
                    tablaPanel.Controls.Add(FotosJuego, j, i);
                    Contador++;

                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            panelJuego.Controls.Add(tablaPanel);

            /* FIN ESTRUCTURA DE DISEÑO */


        }
        private void btnJuego_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (FotosSeleccionadas.Count < 2) // Cuenta los clicks sobre las imágenes
            {


                Movimientos++;
                lblRecord.Text = Convert.ToString(Movimientos); //Registra número de movimientos
                var FotoSeleccionadaJugador = (PictureBox)sender;

                FotoActual = Convert.ToInt32(FotosRevueltas[Convert.ToInt32(FotoSeleccionadaJugador.Name) - 1]);
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
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        CantidadFotosVolteadas++;
                        if (CantidadFotosVolteadas > 7)
                        {
                            MessageBox.Show("Juego terminado", "Aviso");
                            IniciarJuego();
                        }
                        FotoTemp1.Enabled = false; FotoTemp2.Enabled = false;
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
                    TempImagen = Omega.Properties.Resources.img16;
                    break;
                default:
                    TempImagen = (Bitmap)Omega.Properties.Resources.ResourceManager.GetObject("img" + NumeroImagenAsignado);
                    break;

            }
            return TempImagen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panelJuego_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fácilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelJuego_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
