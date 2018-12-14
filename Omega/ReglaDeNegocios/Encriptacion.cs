
using AccesoDatos;

namespace ReglaDeNegocios
{
    public class Encriptacion
    {
        public static string Encriptar(string texto)
        {
            return AlgoritmoEncriptacion.GetMD5(texto);
        }
    }
}
