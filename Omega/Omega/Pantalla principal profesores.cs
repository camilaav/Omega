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

        private void AbrirForm(Form fh)
        {
                if (this.panel1.Controls.Count > 0)
                    this.panel1.Controls.RemoveAt(0);
                fh.TopLevel = false;
                fh.FormBorderStyle = FormBorderStyle.None;
                fh.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(fh);
                this.panel1.Tag = fh;
                fh.Show();

        }
        private void picAlta_Click(object sender, EventArgs e)
        {

            var form = Application.OpenForms.OfType<AltaUsuarios>().FirstOrDefault();
            AltaUsuarios altaUsuarios = form ?? new AltaUsuarios();
            AbrirForm(altaUsuarios);

        }

        private void picBorrar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<BajaUsuarios>().FirstOrDefault();
            BajaUsuarios bajaUsuarios = form ?? new BajaUsuarios();
            AbrirForm(bajaUsuarios);
        }

        private void picModificar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<ModificacionUsuarios>().FirstOrDefault();
            ModificacionUsuarios modificacionUsuarios = form ?? new ModificacionUsuarios();
            AbrirForm(modificacionUsuarios);
        }

        private void picTabla_Click(object sender, EventArgs e)
        {

        }

        private void Pantalla_principal_profesores_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bienvenida bienvenida = new Bienvenida();
            bienvenida.Show();
            this.Hide();
        }
    }
}
