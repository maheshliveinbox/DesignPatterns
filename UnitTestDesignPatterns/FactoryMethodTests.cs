using FactoryMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDesignPatterns
{
    [TestClass]
    public class FactoryMethodTests
    {
        [TestMethod]
        public void Client_WithResult_ConcreatCreator1()
        {
            // Arrange
            var client = new Client();

            // Act
            client.ClientCode(new ConcreteCreator1());

            // Assert
            Assert.AreNotEqual(string.Empty, client.Result, client.Result);
        }

        [TestMethod]
        public void Client_WithResult_ConcreatCreator2()
        {
            // Arrange
            var client = new Client();

            // Act
            client.ClientCode(new ConcreteCreator2());

            // Assert
            Assert.AreNotEqual(string.Empty, client.Result, client.Result);
        }
    }
}
