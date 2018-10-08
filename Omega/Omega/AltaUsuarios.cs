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
using Entidades;

namespace Omega
{
    public partial class AltaUsuarios : Form
    {
        UsuarioRN usuarioRN = new UsuarioRN();
        public AltaUsuarios()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Contraseña = txtContraseña.Text,
                NombreUsuario = txtUsuario.Text
            };
            if(usuarioRN.AltaUsuario(usuario))
            {
                MessageBox.Show("Usuario dado de alta con éxito");
            }
            else
            {
                MessageBox.Show("El usuario no pudo darse de alta");
            }
        }

        private void AltaUsuarios_Load(object sender, EventArgs e)
        {
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var pantallaPrincipal = new Pantalla_principal_profesores();
            pantallaPrincipal.Show();
            this.Hide();
        }
    }
}
