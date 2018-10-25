using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omega.Helpers;
using System;

namespace Tests
{
    [TestClass]
    public class JuegosTest
    {
        JuegosHelper juegoHelper = new JuegosHelper();

        [TestMethod]
        public void Suma_ResultadoOk()
        {
            int numero1 = 4, numero2 = 3;
            var signo = "+";

            var resultado = juegoHelper.Operacion(numero1, numero2, signo);

            Assert.AreEqual(7, resultado);
        }

        [TestMethod]
        public void Suma_MalSigno()
        {
            int numero1 = 4, numero2 = 3;
            Exception expectedException = null;
            var signo = "/";

            try
            {
                var resultado = juegoHelper.Operacion(numero1, numero2, signo);
            }
            catch(Exception e)
            {
                expectedException = e;
            }

            Assert.IsNotNull(expectedException);
            Assert.AreEqual("No existe un método con ese signo", expectedException.Message);
        }
    }
}
