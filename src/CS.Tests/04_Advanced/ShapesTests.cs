using CS.Impl._04_Advanced;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Tests._04_Advanced
{
    [TestClass]
    public class ShapesTests
    {
        [TestMethod]
        public void CheckSquareAreaAndPerimeter()
        {
            // Arrange
            Shape square = new Square(5);

            // Act
            var area = square.GetArea();
            var perimeter = square.GetPerimeter();

            // Assert
            Assert.AreEqual("Square", square.ToString());
            Assert.AreEqual(25, area);
            Assert.AreEqual(20, perimeter);
        }

        [TestMethod]
        public void CheckRectangleAreaAndPerimeter()
        {
            // Arrange
            Shape rectangle = new Rectangle(5, 7);

            // Act
            var area = rectangle.GetArea();
            var perimeter = rectangle.GetPerimeter();

            // Assert
            Assert.AreEqual("Rectangle", rectangle.ToString());
            Assert.AreEqual(35, area);
            Assert.AreEqual(24, perimeter);
        }

        [TestMethod]
        public void CheckCircleAreaAndPerimeter()
        {
            // Arrange
            Shape circle = new Circle(8);

            // Act
            var area = circle.GetArea();
            var perimeter = circle.GetPerimeter();

            // Assert
            Assert.AreEqual("Circle", circle.ToString());
            Assert.AreEqual(201, area);
            Assert.AreEqual(50, perimeter);
        }
    }
}
