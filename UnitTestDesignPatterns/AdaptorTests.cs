using AdapterPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDesignPatterns
{
    [TestClass]
    public class AdaptorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            // Assert
            Assert.AreEqual("This is 'Specific request.'", target.GetRequest());
        }
    }
}
