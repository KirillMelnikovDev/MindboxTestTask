using MindboxLibrary.Implementations.Validators;
using MindboxLibrary.Interfaces.Calculators;
using MindboxLibrary.Interfaces.Validators;

namespace MindboxLibrary.Implementations.Calculators
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
