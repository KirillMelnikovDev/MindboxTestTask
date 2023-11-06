using MindboxLibrary.SourceCode.Interfaces.Shapes;
using MindboxLibrary.SourceCode.Implementations.Shapes;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CircleWithCorrectValue()
        {
            //Arrange
            var circle = new Circle(10d);

            //Act
            var result = circle.Area;

            //Assert
            var expected = Math.PI * 100d;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CircleWithIncorrectValue()
        {
            //Arrange & Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Circle(-1d));
        }

        [TestMethod]
        public void TriangleWithCorrectValues()
        {
            //Arrange
            var triangle = new Triangle(10d, 10d, 12d);

            //Act
            var result = triangle.Area;

            //Assert
            var expected = 48d;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TriangleWithIncorrectValues()
        {
            //Arrange & Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(10d, 10d, 20d));
        }

        [TestMethod]
        public void TriangleWithRightAngle()
        {
            //Arrange
            var triangle = new Triangle(3d, 4d, 5d);

            //Act
            var result = triangle.IsRightAngle;

            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IShapeCalculator()
        {
            //Arrange
            IShape shape = new Circle(1);

            //Act
            //не знаем, что именно за фигура, но можем вычсилить площадь
            var result = shape.AreaCalculator?.CalculateArea();

            //Assert
            Assert.AreEqual(Math.PI, result);
        }
    }
}