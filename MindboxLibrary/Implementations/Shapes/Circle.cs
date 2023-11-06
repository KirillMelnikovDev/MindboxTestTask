using MindboxLibrary.Implementations.Calculators;
using MindboxLibrary.Interfaces.Calculators;
using MindboxLibrary.Interfaces.Shapes;

namespace MindboxLibrary.Implementations.Shapes
{
    public class Circle : IShape
    {
        public IAreaCalculator AreaCalculator { get; }

        public double Radius { get; }

        public double Area { get; }

        public Circle(double radius)
        {
            AreaCalculator = new CircleAreaCalculator(radius);
            Radius = radius;
            Area = AreaCalculator.CalculateArea();
        }

        private Circle()
            : this(0) { }
    }
}
