using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSumar2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            SumaController sumaController = new SumaController();
            int a = 5;
            int b = 8;
            int esperado = 13;

            //Act
            int resultado sumaController.Add(a, b);

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
