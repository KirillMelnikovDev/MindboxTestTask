using MindboxLibrary.Interfaces.Validators;

namespace MindboxLibrary.Implementations.Validators
{
    /// <summary>
    /// У треугольника сумма двух его сторон должна быть больше третьей стороны
    /// </summary>
    public class TriangleValidator : IMultipleValuesValidator
    {
        public TriangleValidator(double a, double b, double c)
        {
            Values = new double[] { a, b, c };

        }
        private TriangleValidator()
        : this(0, 0, 0) { }

        public double[] Values { get; }

        public bool Validate()
        {
            return Values.Length >= 3 &&
                   Values[0] > 0 &&
                   Values[1] > 0 &&
                   Values[2] > 0 &&
                   Values[0] + Values[1] > Values[2] &&
                    Values[0] + Values[2] > Values[1] &&
                    Values[1] + Values[2] > Values[0];
        }

    }
}
