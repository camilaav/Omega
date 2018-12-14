using System;
using System.Drawing;
using System.Windows.Forms;
using ReglaDeNegocios;

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
