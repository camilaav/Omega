using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Regla_de_Negocios;

namespace Omega
{
    public partial class ModificacionUsuarios : Form
    {
        UsuarioRN usuarioRN = new UsuarioRN();
        
        public ModificacionUsuarios()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                IdUsuario = UsuarioLogueado.Logueado.IdUsuario,
                Contraseña = txtContraseñaNueva.Text
            };

            if(Encriptacion.Encriptar(txtContraseñaVieja.Text) == UsuarioLogueado.Logueado.Contraseña)
            {
                if(usuarioRN.ModificacionUsuario(usuario))
                {
                    UsuarioLogueado.Logueado.Contraseña = Encriptacion.Encriptar(usuario.Contraseña);
                    MessageBox.Show("Su contraseña se actualizó con éxito");
                    txtContraseñaNueva.Text = null;
                    txtContraseñaVieja.Text = null;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la contraseña");
                    txtContraseñaNueva.Text = null;
                    txtContraseñaVieja.Text = null;
                }
            }
            else
            {
                MessageBox.Show("La contraseña no se puede cambiar, ya que el valor ingresado en contraseña vieja no corresponde con su contraseña actual");
                txtContraseñaNueva.Text = null;
                txtContraseñaVieja.Text = null;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var pantallaPrincipal = new Pantalla_principal_profesores();
            pantallaPrincipal.Show();
            this.Hide();
        }
    }
}
