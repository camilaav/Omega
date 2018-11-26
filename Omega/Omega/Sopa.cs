using Omega.Helpers;
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
    public partial class Sopa : Form
    {
        //FALTA AGREGAR ANIMACIÓN

        Random letras = new Random();
        Random cfg = new Random();
        MovimientoHelper movimientoHelper = new MovimientoHelper();
        int cfgelegido, puntuacion = 0;
        public int contador,contadorGif, idDificultad = 0;
        bool esCasa = false, esGato = false, esEscuela = false, esRaton = false, esBanana = false, esPlato = false, esPizza = false, esLapiz = false, esMuñeca = false, esPapa = false, esRegla = false, esReloj = false, esMilanesa = false, esAbuelo = false, esAzul = false;
        string startupPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Omega", "Imágenes");
        
        public void Gif()
        {
            pictureBox1.Load(startupPath + "//bien.gif");
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
            tiempo.Enabled = true;
            tiempo.Start();
        }

        public Sopa()
        {
            InitializeComponent();
        }
        private void JuegoCompleto()
        {
            if (this.Tag.ToString() == "Facil")
            {
                if (label1.ForeColor == Color.DarkSlateGray && label2.ForeColor == Color.DarkSlateGray && label3.ForeColor == Color.DarkSlateGray)
                {
                    Gif();
                }
            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                if (label1.ForeColor == Color.DarkSlateGray && label2.ForeColor == Color.DarkSlateGray &&
                    label3.ForeColor == Color.DarkSlateGray && label4.ForeColor == Color.DarkSlateGray &&
                    label5.ForeColor == Color.DarkSlateGray)
                {
                    Gif();
                }
            }
            else if (this.Tag.ToString() == "Dificil")
            {
                if (label1.ForeColor == Color.DarkSlateGray && label2.ForeColor == Color.DarkSlateGray &&
                    label3.ForeColor == Color.DarkSlateGray && label4.ForeColor == Color.DarkSlateGray &&
                    label5.ForeColor == Color.DarkSlateGray && label6.ForeColor == Color.DarkSlateGray &&
                    label7.ForeColor == Color.DarkSlateGray)
                {
                    Gif();
                }
            }
        }
        private void Juego()
        {
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            esCasa = false;
            esGato = false;
            esEscuela = false;
            esRaton = false;
            esBanana = false;
            esPlato = false;
            esPizza = false;
            esLapiz = false;
            esMuñeca = false; 
            esPapa = false;
            esRegla = false;
            esReloj = false; 
            esMilanesa = false; 
            esAbuelo = false;
            esAzul = false;

            if (this.Tag.ToString() == "Facil")
            {
                idDificultad = 1;
                TablaFacil();
                label1.Text = "CASA";
                label2.Text = "GATO";
                label3.Text = "RATON";
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                idDificultad = 2;
                TablaIntermedia();
                label1.Text = "ESCUELA";
                label2.Text = "BANANA";
                label3.Text = "PLATO";
                label4.Text = "PIZZA";
                label5.Text = "LAPIZ";
                label6.Visible = false;
                label7.Visible = false;
            }
            else if (this.Tag.ToString() == "Dificil")
            {
                idDificultad = 3;
                TablaDificil();
                label1.Text = "RELOJ";
                label2.Text = "MUÑECA";
                label3.Text = "ABUELO";
                label4.Text = "PAPA";
                label5.Text = "REGLA";
                label6.Text = "AZUL";
                label7.Text = "MILANESA";
            }
            IniciarPalabras();
            dataGridView1.Font = label1.Font;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            var dataGridHeight = dataGridView1.Size.Height;
            var rowHeight = dataGridHeight / dataGridView1.RowCount;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = rowHeight;
            }
            dataGridView1.ScrollBars = ScrollBars.None;
        }

        private void Sopa_Load(object sender, EventArgs e)
        {
            Juego();
        }

        private void IniciarPalabras()
        {
            cfgelegido = cfg.Next(1, 4);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[j, i].Value = Convert.ToChar(letras.Next(65, 90));
                    if (this.Tag.ToString() == "Facil")
                    {
                        switch (cfgelegido)
                        {
                            case 1:
                                Facilcfg1();
                                break;
                            case 2:
                                Facilcfg2();
                                break;
                            case 3:
                                Facilcfg3();
                                break;
                        }
                    }
                    else if (this.Tag.ToString() == "Intermedia")
                    {
                        switch (cfgelegido)
                        {
                            case 1:
                                Mediocfg1();
                                break;
                            case 2:
                                Mediocfg2();
                                break;
                            case 3:
                                Mediocfg3();
                                break;
                        }
                    }
                    else if (this.Tag.ToString() == "Dificil")
                    {
                        switch (cfgelegido)
                        {
                            case 1:
                                Dificilcfg1();
                                break;
                            case 2:
                                Dificilcfg2();
                                break;
                            case 3:
                                Dificilcfg3();
                                break;
                        }
                    }
                }
            }
        }

        private void Facilcfg1()
        {
            dataGridView1[1, 0].Value = 'C';
            dataGridView1[1, 1].Value = 'A';
            dataGridView1[1, 2].Value = 'S';
            dataGridView1[1, 3].Value = 'A';

            dataGridView1[0, 3].Value = 'G';
            dataGridView1[1, 3].Value = 'A';
            dataGridView1[2, 3].Value = 'T';
            dataGridView1[3, 3].Value = 'O';
            //raton
            dataGridView1[3, 0].Value = 'R';
            dataGridView1[3, 1].Value = 'A';
            dataGridView1[3, 2].Value = 'T';
            dataGridView1[3, 3].Value = 'O';
            dataGridView1[3, 4].Value = 'N';
        }

        private void Facilcfg2()
        {
            dataGridView1[1, 2].Value = 'G';
            dataGridView1[2, 2].Value = 'A';
            dataGridView1[3, 2].Value = 'T';
            dataGridView1[4, 2].Value = 'O';

            dataGridView1[0, 1].Value = 'C';
            dataGridView1[1, 1].Value = 'A';
            dataGridView1[2, 1].Value = 'S';
            dataGridView1[3, 1].Value = 'A';
            //raton
            dataGridView1[3, 0].Value = 'R';
            dataGridView1[3, 1].Value = 'A';
            dataGridView1[3, 2].Value = 'T';
            dataGridView1[3, 3].Value = 'O';
            dataGridView1[3, 4].Value = 'N';
        }

        private void Facilcfg3()
        {
            dataGridView1[4, 0].Value = 'C';
            dataGridView1[4, 1].Value = 'A';
            dataGridView1[4, 2].Value = 'S';
            dataGridView1[4, 3].Value = 'A';

            dataGridView1[0, 1].Value = 'G';
            dataGridView1[1, 1].Value = 'A';
            dataGridView1[2, 1].Value = 'T';
            dataGridView1[3, 1].Value = 'O';
            //raton
            dataGridView1[1, 0].Value = 'R';
            dataGridView1[1, 1].Value = 'A';
            dataGridView1[1, 2].Value = 'T';
            dataGridView1[1, 3].Value = 'O';
            dataGridView1[1, 4].Value = 'N';
        }


        private void Mediocfg1()
        {
            //Escuela//Banana//Plato//Pizza//Lapiz
            dataGridView1[0, 0].Value = 'E';
            dataGridView1[0, 1].Value = 'S';
            dataGridView1[0, 2].Value = 'C';
            dataGridView1[0, 3].Value = 'U';
            dataGridView1[0, 4].Value = 'E';
            dataGridView1[0, 5].Value = 'L';
            dataGridView1[0, 6].Value = 'A';

            dataGridView1[1, 3].Value = 'B';
            dataGridView1[2, 3].Value = 'A';
            dataGridView1[3, 3].Value = 'N';
            dataGridView1[4, 3].Value = 'A';
            dataGridView1[5, 3].Value = 'N';
            dataGridView1[6, 3].Value = 'A';

            dataGridView1[2, 1].Value = 'P';
            dataGridView1[2, 2].Value = 'L';
            dataGridView1[2, 3].Value = 'A';
            dataGridView1[2, 4].Value = 'T';
            dataGridView1[2, 5].Value = 'O';

            dataGridView1[2, 1].Value = 'P';
            dataGridView1[3, 1].Value = 'I';
            dataGridView1[4, 1].Value = 'Z';
            dataGridView1[5, 1].Value = 'Z';
            dataGridView1[6, 1].Value = 'A';

            dataGridView1[6, 2].Value = 'L';
            dataGridView1[6, 3].Value = 'A';
            dataGridView1[6, 4].Value = 'P';
            dataGridView1[6, 5].Value = 'I';
            dataGridView1[6, 6].Value = 'Z';
        }

        private void Mediocfg2()
        {
            dataGridView1[0, 6].Value = 'E';
            dataGridView1[1, 6].Value = 'S';
            dataGridView1[2, 6].Value = 'C';
            dataGridView1[3, 6].Value = 'U';
            dataGridView1[4, 6].Value = 'E';
            dataGridView1[5, 6].Value = 'L';
            dataGridView1[6, 6].Value = 'A';

            dataGridView1[2, 0].Value = 'B';
            dataGridView1[2, 1].Value = 'A';
            dataGridView1[2, 2].Value = 'N';
            dataGridView1[2, 3].Value = 'A';
            dataGridView1[2, 4].Value = 'N';
            dataGridView1[2, 5].Value = 'A';

            dataGridView1[0, 3].Value = 'P';
            dataGridView1[1, 3].Value = 'L';
            dataGridView1[2, 3].Value = 'A';
            dataGridView1[3, 3].Value = 'T';
            dataGridView1[4, 3].Value = 'O';

            dataGridView1[6, 2].Value = 'P';
            dataGridView1[6, 3].Value = 'I';
            dataGridView1[6, 4].Value = 'Z';
            dataGridView1[6, 5].Value = 'Z';
            dataGridView1[6, 6].Value = 'A';

            dataGridView1[1, 1].Value = 'L';
            dataGridView1[2, 1].Value = 'A';
            dataGridView1[3, 1].Value = 'P';
            dataGridView1[4, 1].Value = 'I';
            dataGridView1[5, 1].Value = 'Z';
        }

        private void Mediocfg3()
        {
            dataGridView1[0, 3].Value = 'E';
            dataGridView1[1, 3].Value = 'S';
            dataGridView1[2, 3].Value = 'C';
            dataGridView1[3, 3].Value = 'U';
            dataGridView1[4, 3].Value = 'E';
            dataGridView1[5, 3].Value = 'L';
            dataGridView1[6, 3].Value = 'A';

            dataGridView1[6, 0].Value = 'B';
            dataGridView1[6, 1].Value = 'A';
            dataGridView1[6, 2].Value = 'N';
            dataGridView1[6, 3].Value = 'A';
            dataGridView1[6, 4].Value = 'N';
            dataGridView1[6, 5].Value = 'A';

            dataGridView1[0, 6].Value = 'P';
            dataGridView1[1, 6].Value = 'L';
            dataGridView1[2, 6].Value = 'A';
            dataGridView1[3, 6].Value = 'T';
            dataGridView1[4, 6].Value = 'O';

            dataGridView1[2, 5].Value = 'P';
            dataGridView1[3, 5].Value = 'I';
            dataGridView1[4, 5].Value = 'Z';
            dataGridView1[5, 5].Value = 'Z';
            dataGridView1[6, 5].Value = 'A';

            dataGridView1[0, 0].Value = 'L';
            dataGridView1[1, 0].Value = 'A';
            dataGridView1[2, 0].Value = 'P';
            dataGridView1[3, 0].Value = 'I';
            dataGridView1[4, 0].Value = 'Z';
        }
        private void Dificilcfg1()
        {
            //Munheca
            //Papa
            //Regla
            //Reloj
            //Milanesa
            //Abuelo
            //Azul
            dataGridView1[1, 1].Value = 'M';
            dataGridView1[2, 1].Value = 'U';
            dataGridView1[3, 1].Value = 'Ñ';
            dataGridView1[4, 1].Value = 'E';
            dataGridView1[5, 1].Value = 'C';
            dataGridView1[6, 1].Value = 'A';

            dataGridView1[0, 8].Value = 'P';
            dataGridView1[1, 8].Value = 'A';
            dataGridView1[2, 8].Value = 'P';
            dataGridView1[3, 8].Value = 'A';

            dataGridView1[3, 4].Value = 'R';
            dataGridView1[3, 5].Value = 'E';
            dataGridView1[3, 6].Value = 'G';
            dataGridView1[3, 7].Value = 'L';
            dataGridView1[3, 8].Value = 'A';

            dataGridView1[4, 0].Value = 'R';
            dataGridView1[5, 0].Value = 'E';
            dataGridView1[6, 0].Value = 'L';
            dataGridView1[7, 0].Value = 'O';
            dataGridView1[8, 0].Value = 'J';

            dataGridView1[1, 7].Value = 'M';
            dataGridView1[2, 7].Value = 'I';
            dataGridView1[3, 7].Value = 'L';
            dataGridView1[4, 7].Value = 'A';
            dataGridView1[5, 7].Value = 'N';
            dataGridView1[6, 7].Value = 'E';
            dataGridView1[7, 7].Value = 'S';
            dataGridView1[8, 7].Value = 'A';

            dataGridView1[6, 1].Value = 'A';
            dataGridView1[6, 2].Value = 'B';
            dataGridView1[6, 3].Value = 'U';
            dataGridView1[6, 4].Value = 'E';
            dataGridView1[6, 5].Value = 'L';
            dataGridView1[6, 6].Value = 'O';

            dataGridView1[0, 3].Value = 'A';
            dataGridView1[1, 3].Value = 'Z';
            dataGridView1[2, 3].Value = 'U';
            dataGridView1[3, 3].Value = 'L';
        }

        private void Dificilcfg2()
        {
            dataGridView1[8, 0].Value = 'M';
            dataGridView1[8, 1].Value = 'U';
            dataGridView1[8, 2].Value = 'Ñ';
            dataGridView1[8, 3].Value = 'E';
            dataGridView1[8, 4].Value = 'C';
            dataGridView1[8, 5].Value = 'A';

            dataGridView1[0, 5].Value = 'P';
            dataGridView1[0, 6].Value = 'A';
            dataGridView1[0, 7].Value = 'P';
            dataGridView1[0, 8].Value = 'A';

            dataGridView1[4, 3].Value = 'R';
            dataGridView1[4, 4].Value = 'E';
            dataGridView1[4, 5].Value = 'G';
            dataGridView1[4, 6].Value = 'L';
            dataGridView1[4, 7].Value = 'A';

            dataGridView1[5, 0].Value = 'R';
            dataGridView1[5, 1].Value = 'E';
            dataGridView1[5, 2].Value = 'L';
            dataGridView1[5, 3].Value = 'O';
            dataGridView1[5, 4].Value = 'J';

            dataGridView1[0, 1].Value = 'M';
            dataGridView1[1, 1].Value = 'I';
            dataGridView1[2, 1].Value = 'L';
            dataGridView1[3, 1].Value = 'A';
            dataGridView1[4, 1].Value = 'N';
            dataGridView1[5, 1].Value = 'E';
            dataGridView1[6, 1].Value = 'S';
            dataGridView1[7, 1].Value = 'A';

            dataGridView1[0, 6].Value = 'A';
            dataGridView1[1, 6].Value = 'B';
            dataGridView1[2, 6].Value = 'U';
            dataGridView1[3, 6].Value = 'E';
            dataGridView1[4, 6].Value = 'L';
            dataGridView1[5, 6].Value = 'O';

            dataGridView1[3, 1].Value = 'A';
            dataGridView1[3, 2].Value = 'Z';
            dataGridView1[3, 3].Value = 'U';
            dataGridView1[3, 4].Value = 'L';
        }

        private void Dificilcfg3()
        {
            dataGridView1[0, 3].Value = 'M';
            dataGridView1[0, 4].Value = 'U';
            dataGridView1[0, 5].Value = 'Ñ';
            dataGridView1[0, 6].Value = 'E';
            dataGridView1[0, 7].Value = 'C';
            dataGridView1[0, 8].Value = 'A';

            dataGridView1[3, 3].Value = 'P';
            dataGridView1[4, 3].Value = 'A';
            dataGridView1[5, 3].Value = 'P';
            dataGridView1[6, 3].Value = 'A';

            dataGridView1[3, 5].Value = 'R';
            dataGridView1[4, 5].Value = 'E';
            dataGridView1[5, 5].Value = 'G';
            dataGridView1[6, 5].Value = 'L';
            dataGridView1[7, 5].Value = 'A';

            dataGridView1[2, 2].Value = 'R';
            dataGridView1[3, 2].Value = 'E';
            dataGridView1[4, 2].Value = 'L';
            dataGridView1[5, 2].Value = 'O';
            dataGridView1[6, 2].Value = 'J';

            dataGridView1[4, 0].Value = 'M';
            dataGridView1[4, 1].Value = 'I';
            dataGridView1[4, 2].Value = 'L';
            dataGridView1[4, 3].Value = 'A';
            dataGridView1[4, 4].Value = 'N';
            dataGridView1[4, 5].Value = 'E';
            dataGridView1[4, 6].Value = 'S';
            dataGridView1[4, 7].Value = 'A';

            dataGridView1[0, 8].Value = 'A';
            dataGridView1[1, 8].Value = 'B';
            dataGridView1[2, 8].Value = 'U';
            dataGridView1[3, 8].Value = 'E';
            dataGridView1[4, 8].Value = 'L';
            dataGridView1[5, 8].Value = 'O';

            dataGridView1[7, 5].Value = 'A';
            dataGridView1[7, 6].Value = 'Z';
            dataGridView1[7, 7].Value = 'U';
            dataGridView1[7, 8].Value = 'L';
        }

        private void TablaFacil()
        {
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
        }
        private void TablaIntermedia()
        {
            dataGridView1.RowCount = 7;
            dataGridView1.ColumnCount = 7;
        }

        private void TablaDificil()
        {
            dataGridView1.RowCount = 9;
            dataGridView1.ColumnCount = 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            contadorGif++;
            if (contadorGif == 3)
            {
                movimientoHelper.GuardarMovimiento(this, idDificultad, puntuacion, 4);
            }
        }

        private void Validar()
        {
            if (this.Tag.ToString() == "Facil")
            {
                switch (cfgelegido)
                {
                    case 1:
                        VerificacionLVL1CFG1();
                        break;
                    case 2:
                        VerificacionLVL1CFG2();
                        break;
                    case 3:
                        VerificacionLVL1CFG3();
                        break;
                }
            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                switch (cfgelegido)
                {
                    case 1:
                        VerificacionLVL2CFG1();
                        break;
                    case 2:
                        VerificacionLVL2CFG2();
                        break;
                    case 3:
                        VerificacionLVL2CFG3();
                        break;
                }
            }
            else if (this.Tag.ToString() == "Dificil")
            {
                switch (cfgelegido)
                {
                    case 1:
                        VerificacionLVL3CFG1();
                        break;
                    case 2:
                        VerificacionLVL3CFG2();
                        break;
                    case 3:
                        VerificacionLVL3CFG3();
                        break;
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Validar();
            JuegoCompleto();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Validar();
            JuegoCompleto();
        }

        private void Puntuar()
        {
            puntuacion = puntuacion + 25;
            lblPuntaje.Text = puntuacion.ToString();
        }
        private void VerificacionLVL1CFG1()
        {
            //CASA
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //GATO
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //RATON
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;


            if (dataGridView1[1, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[1, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 3].Style.BackColor == Color.DarkSlateGray && !esCasa)
            {
                label1.ForeColor = Color.DarkSlateGray; //CASA
                esCasa = true;
                Puntuar();
            }

            if (dataGridView1[0, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 3].Style.BackColor == Color.DarkSlateGray && !esGato)
            {
                label2.ForeColor = Color.DarkSlateGray; //GATO
                esGato = true;
                Puntuar();
            }

            if (dataGridView1[3, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[3, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[3, 4].Style.BackColor == Color.DarkSlateGray && !esGato)
            {
                label3.ForeColor = Color.DarkSlateGray; //RATON
                esGato = true;
                Puntuar();
            }

        }

        private void VerificacionLVL1CFG2()
        {

            //CASA
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //GATO
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //RATON
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            if (dataGridView1[1, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[2, 2].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[3, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 2].Style.BackColor == Color.DarkSlateGray && !esGato)
            {
                label2.ForeColor = Color.DarkSlateGray; //GATO
                esGato = true;
                Puntuar();
            }


            if (dataGridView1[0, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 1].Style.BackColor == Color.DarkSlateGray && !esCasa)
            {
                label1.ForeColor = Color.DarkSlateGray; //CASA
                esCasa = true;
                Puntuar();
            }

            if (dataGridView1[3, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[3, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[3, 4].Style.BackColor == Color.DarkSlateGray && !esRaton)
            {
                label3.ForeColor = Color.DarkSlateGray; //RATON
                esRaton = true;
                Puntuar();
            }

        }

        private void VerificacionLVL1CFG3()
        {
            //CASA
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //GATO
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //RATON
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            if (dataGridView1[4, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 3].Style.BackColor == Color.DarkSlateGray && !esCasa)
            {
                label1.ForeColor = Color.DarkSlateGray; //CASA
                esCasa = true;
                Puntuar();
            }

            if (dataGridView1[0, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 1].Style.BackColor == Color.DarkSlateGray && !esGato)
            {
                label2.ForeColor = Color.DarkSlateGray; //GATO
                esGato = true;
                Puntuar();
            }

            if (dataGridView1[1, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[1, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[1, 4].Style.BackColor == Color.DarkSlateGray && !esRaton)
            {
                label3.ForeColor = Color.DarkSlateGray; //RATON
                esRaton = true;
                Puntuar();
            }

        }
        private void VerificacionLVL2CFG1()
        {
            //ESCUELA
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //BANANA
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //PLATO
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //PIZZA
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //LAPIZ
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;


            if (dataGridView1[0, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[0, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[0, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[0, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[0, 4].Style.BackColor == Color.DarkSlateGray && dataGridView1[0, 5].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[0, 6].Style.BackColor == Color.DarkSlateGray && !esEscuela)
            {
                label1.ForeColor = Color.DarkSlateGray; //ESCUELA
                esEscuela = true;
                Puntuar();
            }

            if (dataGridView1[1, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[2, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[3, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[5, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 3].Style.BackColor == Color.DarkSlateGray && !esBanana)
            {
                label2.ForeColor = Color.DarkSlateGray; //BANANA
                esBanana = true;
                Puntuar();
            }

            if (dataGridView1[2, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[2, 2].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[2, 4].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 5].Style.BackColor == Color.DarkSlateGray && !esPlato)
            {
                label3.ForeColor = Color.DarkSlateGray; //PLATO
                esPlato = true;
                Puntuar();
            }
            if (dataGridView1[2, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[5, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 1].Style.BackColor == Color.DarkSlateGray && !esPizza)
            {
                label4.ForeColor = Color.DarkSlateGray; //PIZZA
                esPizza = true;
                Puntuar();
            }
            if (dataGridView1[6, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 4].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 5].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 6].Style.BackColor == Color.DarkSlateGray && !esLapiz)
            {
                label5.ForeColor = Color.DarkSlateGray; //LAPIZ
                esLapiz = true;
                Puntuar();
            }
        }
        private void VerificacionLVL2CFG2()
        {

            //ESCUELA
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //BANANA
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //PLATO
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //PIZZA
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //LAPIZ
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;


            if (dataGridView1[0, 6].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 6].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 6].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 6].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 6].Style.BackColor == Color.DarkSlateGray && dataGridView1[5, 6].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 6].Style.BackColor == Color.DarkSlateGray && !esEscuela)
            {
                label1.ForeColor = Color.DarkSlateGray; //ESCUELA
                esEscuela = true;
                Puntuar();
            }

            if (dataGridView1[2, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[2, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[2, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 4].Style.BackColor == Color.DarkSlateGray && dataGridView1[2, 5].Style.BackColor == Color.DarkSlateGray && !esBanana)
            {
                label2.ForeColor = Color.DarkSlateGray; //BANANA
                esBanana = true;
                Puntuar();
            }

            if (dataGridView1[0, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 3].Style.BackColor == Color.DarkSlateGray && !esPlato)
            {
                label3.ForeColor = Color.DarkSlateGray; //PLATO
                esPlato = true;
                Puntuar();
            }
            if (dataGridView1[6, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 4].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 5].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 6].Style.BackColor == Color.DarkSlateGray && !esPizza)
            {
                label4.ForeColor = Color.DarkSlateGray; //PIZZA
                esPizza = true;
                Puntuar();
            }
            if (dataGridView1[1, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[2, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[3, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[5, 1].Style.BackColor == Color.DarkSlateGray && !esLapiz)
            {
                label5.ForeColor = Color.DarkSlateGray; //LAPIZ
                esLapiz = true;
                Puntuar();
            }
        }
        private void VerificacionLVL2CFG3()
        {
            //ESCUELA
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //BANANA
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //PLATO
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //PIZZA
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //LAPIZ
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;


            if (dataGridView1[0, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[5, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 3].Style.BackColor == Color.DarkSlateGray && !esEscuela)
            {
                label1.ForeColor = Color.DarkSlateGray; //ESCUELA
                esEscuela = true;
                Puntuar();
            }

            if (dataGridView1[6, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 4].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 5].Style.BackColor == Color.DarkSlateGray && !esBanana)
            {
                label2.ForeColor = Color.DarkSlateGray; //BANANA
                esBanana = true;
                Puntuar();
            }

            if (dataGridView1[0, 6].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 6].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 6].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 6].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 6].Style.BackColor == Color.DarkSlateGray && !esPlato)
            {
                label3.ForeColor = Color.DarkSlateGray; //PLATO
                esPlato = true;
                Puntuar();
            }
            if (dataGridView1[2, 5].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 5].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 5].Style.BackColor == Color.DarkSlateGray && dataGridView1[5, 5].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 5].Style.BackColor == Color.DarkSlateGray && !esPizza)
            {
                label4.ForeColor = Color.DarkSlateGray; //PIZZA
                esPizza = true;
                Puntuar();
            }
            if (dataGridView1[0, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 0].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[5, 0].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 0].Style.BackColor == Color.DarkSlateGray && !esLapiz)
            {
                label5.ForeColor = Color.DarkSlateGray; //LAPIZ
                esLapiz = true;
                Puntuar();
            }
        }
        private void VerificacionLVL3CFG1()
        {

            //muñeca
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //papa
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //regla
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //reloj
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[7, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[8, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //milanesa
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[7, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[8, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //abuelo
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //azul
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            if (dataGridView1[1, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[2, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[3, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[5, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 1].Style.BackColor == Color.DarkSlateGray && !esMuñeca)
            {
                label2.ForeColor = Color.DarkSlateGray; //munheca
                esMuñeca = true;
                Puntuar();
            }
            if (dataGridView1[0, 8].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 8].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 8].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 8].Style.BackColor == Color.DarkSlateGray && !esPapa)
            {
                label4.ForeColor = Color.DarkSlateGray; //papa
                esPapa = true;
                Puntuar();
            }
            if (dataGridView1[3, 4].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 5].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[3, 6].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 7].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[3, 8].Style.BackColor == Color.DarkSlateGray && !esRegla)
            {
                label5.ForeColor = Color.DarkSlateGray; //regla
                esRegla = true;
                Puntuar();
            }
            if (dataGridView1[4, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[5, 0].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[7, 0].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[8, 0].Style.BackColor == Color.DarkSlateGray && !esReloj)
            {
                label1.ForeColor = Color.DarkSlateGray; //reloj
                esReloj = true;
                Puntuar();
            }
            if (dataGridView1[1, 7].Style.BackColor == Color.DarkSlateGray && dataGridView1[2, 7].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[3, 7].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 7].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[5, 7].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 7].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[7, 7].Style.BackColor == Color.DarkSlateGray && dataGridView1[8, 7].Style.BackColor == Color.DarkSlateGray && !esMilanesa)
            {
                label7.ForeColor = Color.DarkSlateGray; //milanesa
                esMilanesa = true;
                Puntuar();
            }
            if (dataGridView1[6, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 2].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 4].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 5].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 6].Style.BackColor == Color.DarkSlateGray && !esAbuelo)
            {
                label3.ForeColor = Color.DarkSlateGray; //abuelo
                esAbuelo = true;
                Puntuar();
            }
            if (dataGridView1[0, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 3].Style.BackColor == Color.DarkSlateGray && !esAzul)
            {
                label6.ForeColor = Color.DarkSlateGray; //azul
                esAzul = true;
                Puntuar();
            }
        }
        private void VerificacionLVL3CFG2()
        {

            //muñeca
            if (dataGridView1.CurrentCell.Selected == dataGridView1[8, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[8, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[8, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[8, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[8, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[8, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //papa
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //regla
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //reloj
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //milanesa
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[7, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //abuelo
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //azul
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            if (dataGridView1[8, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[8, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[8, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[8, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[8, 4].Style.BackColor == Color.DarkSlateGray && dataGridView1[8, 5].Style.BackColor == Color.DarkSlateGray && !esMuñeca)
            {
                label2.ForeColor = Color.DarkSlateGray; //munheca
                esMuñeca = true;
                Puntuar();
            }
            if (dataGridView1[0, 5].Style.BackColor == Color.DarkSlateGray && dataGridView1[0, 6].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[0, 7].Style.BackColor == Color.DarkSlateGray && dataGridView1[0, 8].Style.BackColor == Color.DarkSlateGray && !esPapa)
            {
                label4.ForeColor = Color.DarkSlateGray; //papa
                esPapa = true;
                Puntuar();
            }
            if (dataGridView1[4, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 4].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 5].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 6].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 7].Style.BackColor == Color.DarkSlateGray && !esRegla)
            {
                label5.ForeColor = Color.DarkSlateGray; //regla
                esRegla = true;
                Puntuar();
            }
            if (dataGridView1[5, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[5, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[5, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[5, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[5, 4].Style.BackColor == Color.DarkSlateGray && !esReloj)
            {
                label1.ForeColor = Color.DarkSlateGray; //reloj
                esReloj = true;
                Puntuar();
            }
            if (dataGridView1[0, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[5, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[7, 1].Style.BackColor == Color.DarkSlateGray && !esMilanesa)
            {
                label7.ForeColor = Color.DarkSlateGray; //milanesa
                esMilanesa = true;
                Puntuar();
            }
            if (dataGridView1[0, 6].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 6].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 6].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 6].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 6].Style.BackColor == Color.DarkSlateGray && dataGridView1[5, 6].Style.BackColor == Color.DarkSlateGray && !esAbuelo)
            {
                label3.ForeColor = Color.DarkSlateGray; //abuelo
                esAbuelo = true;
                Puntuar();
            }
            if (dataGridView1[3, 1].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 2].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[3, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 4].Style.BackColor == Color.DarkSlateGray && !esAzul)
            {
                label6.ForeColor = Color.DarkSlateGray; //azul
                esAzul = true;
                Puntuar();
            }
        }
        private void VerificacionLVL3CFG3()
        {

            //muñeca
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //papa
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //regla
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[7, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //reloj
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[6, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //milanesa
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 0].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 1].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 2].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 3].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 4].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //abuelo
            if (dataGridView1.CurrentCell.Selected == dataGridView1[0, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[1, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[2, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[3, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[4, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[5, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            //azul
            if (dataGridView1.CurrentCell.Selected == dataGridView1[7, 5].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[7, 6].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[7, 7].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;
            if (dataGridView1.CurrentCell.Selected == dataGridView1[7, 8].Selected)
                dataGridView1.CurrentCell.Style.BackColor = Color.DarkSlateGray;

            if (dataGridView1[0, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[0, 4].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[0, 5].Style.BackColor == Color.DarkSlateGray && dataGridView1[0, 6].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[0, 7].Style.BackColor == Color.DarkSlateGray && dataGridView1[0, 8].Style.BackColor == Color.DarkSlateGray && !esMuñeca)
            {
                label2.ForeColor = Color.DarkSlateGray; //munheca
                esMuñeca = true;
                Puntuar();
            }
            if (dataGridView1[3, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[5, 3].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 3].Style.BackColor == Color.DarkSlateGray && !esPapa)
            {
                label4.ForeColor = Color.DarkSlateGray; //papa
                esPapa = true;
                Puntuar();
            }
            if (dataGridView1[3, 5].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 5].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[5, 5].Style.BackColor == Color.DarkSlateGray && dataGridView1[6, 5].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[7, 5].Style.BackColor == Color.DarkSlateGray && !esRegla)
            {
                label5.ForeColor = Color.DarkSlateGray; //regla
                esRegla = true;
                Puntuar();
            }
            if (dataGridView1[2, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 2].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[5, 2].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[6, 2].Style.BackColor == Color.DarkSlateGray && !esReloj)
            {
                label1.ForeColor = Color.DarkSlateGray; //reloj
                esReloj = true;
                Puntuar();
            }
            if (dataGridView1[4, 0].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 1].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 2].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 3].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 4].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 5].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 6].Style.BackColor == Color.DarkSlateGray && dataGridView1[4, 7].Style.BackColor == Color.DarkSlateGray && !esMilanesa)
            {
                label7.ForeColor = Color.DarkSlateGray; //milanesa
                esMilanesa = true;
                Puntuar();
            }
            if (dataGridView1[0, 8].Style.BackColor == Color.DarkSlateGray && dataGridView1[1, 8].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[2, 8].Style.BackColor == Color.DarkSlateGray && dataGridView1[3, 8].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[4, 8].Style.BackColor == Color.DarkSlateGray && dataGridView1[5, 8].Style.BackColor == Color.DarkSlateGray && !esAbuelo)
            {
                label3.ForeColor = Color.DarkSlateGray; //abuelo
                esAbuelo = true;
                Puntuar();
            }
            if (dataGridView1[7, 5].Style.BackColor == Color.DarkSlateGray && dataGridView1[7, 6].Style.BackColor == Color.DarkSlateGray &&
                dataGridView1[7, 7].Style.BackColor == Color.DarkSlateGray && dataGridView1[7, 8].Style.BackColor == Color.DarkSlateGray && !esAzul)
            {
                label6.ForeColor = Color.DarkSlateGray; //azul
                esAzul = true;
                Puntuar();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var pantallaPrincipal = new Pantalla_principal();
            pantallaPrincipal.Show();
            this.Hide();
        }
    }
}