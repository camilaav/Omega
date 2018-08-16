using System;

namespace Entidades
{
    public class Usuario
    {
        public string IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaBloqueo { get; set; }
        public Boolean Eliminado { get; set; }
    }
}
