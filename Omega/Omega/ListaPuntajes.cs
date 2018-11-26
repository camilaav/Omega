using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regla_de_Negocios;

namespace Omega
{
    public partial class ListaPuntajes : Form
    {
        JuegoRN juegoRN = new JuegoRN();
        public ListaPuntajes()
        {
            InitializeComponent();
        }

        private void ListaPuntajes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = juegoRN.TablaMovimientos();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

        }
    }
}
