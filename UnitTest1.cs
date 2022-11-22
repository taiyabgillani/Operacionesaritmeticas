using Ope;


namespace PruebaUnitaria
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void PruebaAreaCuadrado()
        {
            int L1 = 2;

            int Esperado = 4;

            double resultado = Clases.AreaCuadrado(L1);

            Assert.AreEqual(Esperado, resultado);
        }

        [TestMethod]
        public void PruebaAreaRectangulo()
        {
            int Base1 = 2;
            int Altura1 = 1;

            int Esperado = Base1 * Altura1;

            double resultado = Clases.AreaRectangulo(Base1, Altura1);

            Assert.AreEqual(Esperado, resultado);
        }

        [TestMethod]
        public void PruebaAreaTrapecio()
        {
            int Base3 = 2;
            int x = 1;
            int Altura3 = 2;

            int Esperado = (Base3 + x) * Altura3 / 2;

            double resultado = Clases.AreaTrapecio(Base3, x, Altura3);

            Assert.AreEqual(Esperado, resultado);
        }


    }
}
