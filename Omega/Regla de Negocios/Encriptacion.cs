using System;
using Acceso_a_base_de_datos;

namespace Regla_de_Negocios
{
    public class Encriptacion
    {
        public static string Encriptar(string texto)
        {
            return AlgoritmoEncriptacion.GetMD5(texto);
        }
    }
}
