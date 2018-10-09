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
            }
            else if (this.Tag.ToString() == "Intermedia")
            {
                TablaIntermedia();
            }
            else if (this.Tag.ToString() == "Dificil")
            {
                TablaDificil();
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
                        
                    }
                    else if (this.Tag.ToString() == "Dificil")
                    {
                       
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

        private void IntermediaCfg1()
        {

        }
    }
}
