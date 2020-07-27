using System;
using AbstractFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDesignPatterns
{
    [TestClass]
    public class AbstractFactoryTests
    {
        [TestMethod]
        public void Client_WithResult()
        {
            // Arrange
            var client = new Client();

            // Act
            client.ClientMethod(new ConcreteFactory1());

            // Assert
            Assert.AreNotEqual(string.Empty, client.Result);
        }
    }
}
