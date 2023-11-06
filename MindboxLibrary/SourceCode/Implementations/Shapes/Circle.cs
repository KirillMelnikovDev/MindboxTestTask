using MindboxLibrary.SourceCode.Interfaces.Shapes;
using MindboxLibrary.SourceCode.Interfaces.Calculators;
using MindboxLibrary.SourceCode.Implementations.Calculators;

namespace MindboxLibrary.SourceCode.Implementations.Shapes
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
