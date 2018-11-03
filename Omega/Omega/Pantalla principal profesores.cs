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
    public partial class Pantalla_principal_profesores : Form
    {
        public Pantalla_principal_profesores()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var altaUsuarios = new AltaUsuarios();
            altaUsuarios.Show();
            this.Hide();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bajaUsuarios = new BajaUsuarios();
            bajaUsuarios.Show();
            this.Hide();
        }

        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var modificacionUsuarios = new ModificacionUsuarios();
            modificacionUsuarios.Show();
            this.Hide();
        }

        private void Pantalla_principal_profesores_Load(object sender, EventArgs e)
        {

        }
    }
}
