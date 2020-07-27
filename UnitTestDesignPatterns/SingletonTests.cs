using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace UnitTestDesignPatterns
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void Singleton_CheckIfDifferent_Objects()
        {
            // Arrange
            var s1 = Singleton.Singleton.GetInstance();
            var s2 = Singleton.Singleton.GetInstance();

            // Assert
            Assert.AreSame(s1, s2);
        }
    }
}
