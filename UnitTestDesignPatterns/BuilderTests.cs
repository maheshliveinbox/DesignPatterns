using Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDesignPatterns
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void BulderHasMinimalViableProducts_WithDirector()
        {
            // Arrange
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            // Act
            director.buildMinimalViableProduct();

            // Assert
            Assert.AreEqual(1, builder.GetProduct().Parts.Count);
        }

        [TestMethod]
        public void BulderHasAllProducts_WithDirector()
        {
            // Arrange
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            // Act
            director.buildFullFeaturedProduct();

            // Assert
            Assert.AreEqual(3, builder.GetProduct().Parts.Count);
        }

        [TestMethod]
        public void BuilderHasOneProduct_WithoutDirector()
        {
            // Arrange
            var builder = new ConcreteBuilder();

            // Act
            builder.BuildPartA();

            // Assert
            Assert.AreEqual(1, builder.GetProduct().Parts.Count);
        }

        [TestMethod]
        public void BuilderHasTwoProducts_WithoutDirector()
        {
            // Arrange
            var builder = new ConcreteBuilder();

            // Act
            builder.BuildPartA();
            builder.BuildPartB();

            // Assert
            Assert.AreEqual(2, builder.GetProduct().Parts.Count);
        }
    }
}
