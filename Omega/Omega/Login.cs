using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReglaDeNegocios;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Bienvenida bienvenida = new Bienvenida();
            bienvenida.Show();
            this.Hide();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            contador++;
            var usuario = new Usuario();
            List<Usuario> usuarios = new List<Usuario>();
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuarios = usuarioRN.SeleccionarUsuario(usuario);
            foreach (var u in usuarios)
            {
                if (txtUsuario.Text == u.NombreUsuario)
                {
                    int id = u.IdUsuario;
                    if (Encriptacion.Encriptar(txtContraseña.Text) == u.Contraseña)
                    {
                        if (u.FechaBloqueo < DateTime.Now)
                        {
                            var pantallaProfesores = new Pantalla_principal_profesores();
                            UsuarioLogueado.Logueado = u;
                            pantallaProfesores.Show();
                            this.Hide();
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
                            u.FechaBloqueo = DateTime.Now.AddMinutes(10);
                            usuarioRN.InsertarBloqueo(u);
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
    }
}
