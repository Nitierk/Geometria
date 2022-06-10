using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometriaAPI.Models;
namespace GeometriaTest
{
    [TestClass]
    public class RetanguloTest
    {
        
        [TestMethod]
        public void RetanguloCalcularAreaTestAccept()
        {
            Retangulo retangulo = new Retangulo();
            double esperado = 20;
            string[] medidas = {"4", "5"};
            double resultado = retangulo.CalcularArea(medidas);
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void RetanguloCalcularAreaTestcomtexto()
        {
            Retangulo retangulo = new Retangulo();
            double esperado = -1;
            string[] medidas = {"m", "5"};
            double resultado = retangulo.CalcularArea(medidas);
            Assert.AreEqual(esperado, resultado);
        }


    }
}
