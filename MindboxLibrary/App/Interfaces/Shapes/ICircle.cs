using MindboxLibrary.App.Implementations.Calculators;
using MindboxLibrary.App.Interfaces.Calculators;
using MindboxLibrary.App.Interfaces.Validators;

namespace MindboxLibrary.App.Interfaces.Shapes
{
    public struct CircleStruct : IShape
    {
        public double Radius { get; }

        public IValidator Validator { get; }

        public IAreaCalculator AreaCalculator { get; }

        public IPerimeterCalculator PerimeterCalculator { get; }

        public CircleStruct(double radius)
        {
            Radius = radius;
            Validator = new CircleValidator(radius);
            AreaCalculator = new CircleAreaCalculator(radius);
            PerimeterCalculator = new CirclePerimeterCalculator(radius);
        }

        public CircleStruct() : this(0) { }

        public double CalculateArea()
        {
            return AreaCalculator.CalculateArea();
        }

        public double CalculatePerimeter()
        {
            return PerimeterCalculator.CalculatePerimeter();
        }
    }
}
