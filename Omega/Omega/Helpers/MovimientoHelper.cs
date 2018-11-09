using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regla_de_Negocios;

namespace Omega
{
    public class MovimientoHelper
    {
        JuegoRN juegoRN = new JuegoRN();

        public void GuardarMovimiento(Form formulario,int idDificultad, int puntuacion, int idJuego)
        {
            var movimiento = new Movimiento
            {
                Fecha = DateTime.Now,
                IdJuego = idJuego,
                IdDificultad = idDificultad,
                Puntuacion = puntuacion,

            };
            juegoRN.NuevoMovimiento(movimiento);

            MessageBox.Show("Terminaste perfectamente las consignas", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            var pantallaPrincipal = new Pantalla_principal();
            pantallaPrincipal.Show();
            formulario.Hide();
        }
    }
}
