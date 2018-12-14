using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Movimiento
    {
        public int IdMovimiento { get; set; }
        public int Puntuacion { get; set; }
        public DateTime Fecha { get; set; }
        public static string Jugador { get; set; }
        public int IdJuego { get; set; }
        public int IdDificultad { get; set; }
    }
}
