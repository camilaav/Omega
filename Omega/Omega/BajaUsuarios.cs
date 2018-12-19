using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ReglaDeNegocios;
using Entidades;
using System.Configuration;

namespace Omega
{
    public partial class BajaUsuarios : Form
    {
        UsuarioRN usuarioRN = new UsuarioRN();
        public BajaUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var pantallaPrincipal = new Pantalla_principal_profesores();
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void BajaUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuarioRN.ListaPersonas();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            string path = ConfigurationManager.AppSettings["Imagenes"].ToString();
            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var butcell = this.dataGridView1.Rows[e.RowIndex].Cells["btnEliminar"] as DataGridViewButtonCell;
                var iconoeliminar = new Icon(path + @"\eliminar.ico");
                e.Graphics.DrawIcon(iconoeliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.dataGridView1.Rows[e.RowIndex].Height = iconoeliminar.Height + 10;
                this.dataGridView1.Columns[e.ColumnIndex].Width = iconoeliminar.Width + 10;
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString()) != UsuarioLogueado.Logueado.IdUsuario)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    var u = new Usuario();
                    u.IdUsuario = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                    var confirmacion = MessageBox.Show("¿Está seguro de eliminar al usuario " + dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString() + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmacion == DialogResult.Yes)
                    {
                        if (!usuarioRN.BajaUsuario(u))
                        {
                            MessageBox.Show("El usuario no se pudo eliminar correctamente");
                        }
                        else
                        {
                            MessageBox.Show("El usuario fue eliminado correctamente");
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = usuarioRN.ListaPersonas();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar un usuario mientras está logueado al sistema");
            }
        }
    }
}
