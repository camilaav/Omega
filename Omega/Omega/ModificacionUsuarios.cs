using System;
using System.Windows.Forms;
using Entidades;
using ReglaDeNegocios;

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
            if(txtContraseñaNueva.Text == txtConfirmacion.Text)
            {
                if (Encriptacion.Encriptar(txtContraseñaVieja.Text) == UsuarioLogueado.Logueado.Contraseña)
                {
                    if (usuarioRN.ModificacionUsuario(usuario))
                    {
                        UsuarioLogueado.Logueado.Contraseña = Encriptacion.Encriptar(usuario.Contraseña);
                        MessageBox.Show("Su contraseña se actualizó con éxito");
                        txtContraseñaNueva.Text = null;
                        txtContraseñaVieja.Text = null;
                        txtConfirmacion.Text = null;
                        txtContraseñaVieja.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la contraseña");
                        txtContraseñaNueva.Text = null;
                        txtContraseñaVieja.Text = null;
                        txtConfirmacion.Text = null;
                        txtContraseñaVieja.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña no se puede cambiar, ya que el valor ingresado en contraseña vieja no corresponde con su contraseña actual");
                    txtContraseñaNueva.Text = null;
                    txtContraseñaVieja.Text = null;
                    txtConfirmacion.Text = null;
                    txtContraseñaVieja.Focus();
                }
            }
            else
            {
                MessageBox.Show("La contraseña nueva no corresponde con la confirmación, vuelva a ingresarlas");
                txtContraseñaNueva.Text = null;
                txtContraseñaVieja.Text = null;
                txtConfirmacion.Text = null;
                txtContraseñaVieja.Focus();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var pantallaPrincipal = new Pantalla_principal_profesores();
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void ModificacionUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
