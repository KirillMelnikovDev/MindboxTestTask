using MindboxLibrary.Implementations.Validators;
using MindboxLibrary.Interfaces.Calculators;
using MindboxLibrary.Interfaces.Validators;

namespace MindboxLibrary.Implementations.Calculators
{
    internal class TriangleAreaCalculator : IAreaCalculator
    {
        private double SideA { get; }

        private double SideB { get; }

        private double SideC { get; }

        public IValidator Validator { get; }

        public TriangleAreaCalculator(double a, double b, double c)
        {
            Validator = new TriangleValidator(a, b, c);
            if (!Validator.Validate())
                throw new ArgumentException("sides are incorrect!");

            SideA = a;
            SideB = b;

            SideC = c;
        }

        private TriangleAreaCalculator()
            : this(0, 0, 0) { }

        /// <summary>
        /// Вычисление периметра
        /// </summary>
        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        public double CalculateArea()
        {
            var p = CalculatePerimeter() / 2d;
            var area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return area;
        }
    }
}
