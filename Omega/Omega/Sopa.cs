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
    public partial class Sopa : Form
    {
        Random letras = new Random();
        Random cfg = new Random();
        public Sopa()
        {
            InitializeComponent();
            //var dificultad = 1;
            //if (dificultad == 1)
            //{
            //    dataGridView1.RowCount = 4;
            //    dataGridView1.ColumnCount = 4;
            //    dataGridView1.RowTemplate.Height = 30;
            //}
            //else if (dificultad == 2)
            //{
            //    dataGridView1.RowCount = 5;
            //    dataGridView1.ColumnCount = 5;
            //}
            //else
            //{
            //    dataGridView1.RowCount = 6;
            //    dataGridView1.ColumnCount = 6;
            //}
            //             4x4 y 5x5 3 o 4 letras.
            //6x6 7x7 y las palabras a buscar serán de 4 o 5 letras.
            //8x8 9x9 y las palabras a buscar serán de 5 o 6 letras.

        }


        private void Juego()
        {
            if (this.Tag.ToString() == "Facil")
            {
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
        }

        int cfgelegido;
        private void Sopa_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = label1.Font;
            Juego();
        }

        private void IniciarPalabras()
        {
            cfgelegido = cfg.Next(1, 3);
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

            dataGridView1[3, 0].Value = 'A';
            dataGridView1[3, 1].Value = 'Z';
            dataGridView1[3, 2].Value = 'U';
            dataGridView1[3, 3].Value = 'L';
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

        
    }
}
