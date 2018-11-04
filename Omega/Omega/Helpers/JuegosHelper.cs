using System;

namespace Omega.Helpers
{
    public class JuegosHelper
    {
        public int Operacion(int numeroUno, int numeroDos, string signo)
        {
            if(signo == "-")
            {
                return numeroUno - numeroDos;
            }
            else if(signo == "+")
            {
                return numeroUno + numeroDos;
            }
            else
            {
                throw new Exception("No existe un método con ese signo");
            }
        }
    }
}
