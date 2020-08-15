namespace UnitTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        public object Assert { get; private set; }

        [TestMethod]
            public void TestAdd1()
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