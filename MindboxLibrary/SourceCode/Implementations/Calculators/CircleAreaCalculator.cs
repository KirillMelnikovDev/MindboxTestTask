using MindboxLibrary.SourceCode.Interfaces.Calculators;
using MindboxLibrary.SourceCode.Interfaces.Validators;
using MindboxLibrary.SourceCode.Implementations.Validators;

namespace MindboxLibrary.SourceCode.Implementations.Calculators
{
    internal class CircleAreaCalculator : IAreaCalculator
    {
        private double Radius { get; }

        public IValidator Validator { get; }

        public CircleAreaCalculator(double radius)
        {
            Validator = new CircleValidator(radius);
            if (!Validator.Validate())
                throw new ArgumentException("radius is incorrect!");
            Radius = radius;
        }

        public CircleAreaCalculator()
            : this(0) { }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
