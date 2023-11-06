using MindboxLibrary.Interfaces.Validators;

namespace MindboxLibrary.Implementations.Validators
{
    /// <summary>
    /// У круга радиус должен быть положительным
    /// </summary>
    public class CircleValidator : ISingleValueValidator
    {
        public CircleValidator(double radius)
        {
            Value = radius;
        }

        public CircleValidator()
            : this(0) { }

        public double Value { get; }

        public bool Validate()
        {
            return Value > 0;
        }
    }
}
