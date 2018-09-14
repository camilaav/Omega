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
        public Sopa()
        {
            InitializeComponent();
            var dificultad = 1;
            if(dificultad == 1)
            {
                dataGridView1.RowCount = 4;
                dataGridView1.ColumnCount = 4;
                dataGridView1.RowTemplate.Height = 30;
            }
            else if(dificultad == 2)
            {
                dataGridView1.RowCount = 5;
                dataGridView1.ColumnCount = 5;
            }
            else
            {
                dataGridView1.RowCount = 6;
                dataGridView1.ColumnCount = 6;
            }
//             4x5 3 o 4 letras.
//5x5 y las palabras a buscar serán de 4 o 5 letras.
//6x6 y las palabras a buscar serán de 5 o 6 letras.

        }

        private void Sopa_Load(object sender, EventArgs e)
        {

        }
    }
}
