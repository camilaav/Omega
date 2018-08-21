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
    public partial class Login : Form
    {
        UsuarioRN usuarioRN = new UsuarioRN();
        int contador = 0;
        public Login()
        {
            InitializeComponent();
        }
        void Limpiar()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            contador++;
            Usuario u = new Usuario();
            List<Usuario> usuarios = new List<Usuario>();
            u.NombreUsuario = txtUsuario.Text;
            u.Contraseña = txtContraseña.Text;
            usuarios = usuarioRN.SeleccionarUsuario(u);
            foreach (var usuario in usuarios)
            {
                if (txtUsuario.Text == usuario.NombreUsuario)
                {
                    int id = usuario.IdUsuario;
                    if (Encriptacion.Encriptar(txtContraseña.Text) == usuario.Contraseña)
                    {
                        if (usuario.FechaBloqueo < DateTime.Now)
                        {
                            MessageBox.Show("Ingresaste bien");
                        }
                        else
                        {
                            MessageBox.Show("No puede ingresar, usuario bloqueado");
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (contador == 3)
                        {
                            MessageBox.Show("Limite alcanzado, usuario bloqueado por 10 minutos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            usuario.FechaBloqueo = DateTime.Now.AddMinutes(10);
                            usuarioRN.InsertarBloqueo(usuario);
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto");
                    Limpiar();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bienvenida b = new Bienvenida();
            b.Show();
            this.Hide();
        }
    }
}
