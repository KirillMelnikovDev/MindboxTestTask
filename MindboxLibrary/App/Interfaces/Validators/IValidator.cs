using MindboxLibrary.App.Interfaces.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxLibrary.App.Interfaces.Validators
{
    public interface IValidator
    {
        public bool Validate();
    }

    public interface ISingleValueValidator : IValidator
    {
        public double Value { get; }
    }

    public interface IMultipleValuesValidator : IValidator 
    {
        public double[] Values { get; }
    }

    /// <summary>
    /// У круга радиус должен быть положительным
    /// </summary>
    public struct CircleValidator : ISingleValueValidator
    {
        public CircleValidator(double radius)
        {
            Value = radius;
            
        }
        public CircleValidator() : this(0) { }

        public double Value { get; }

        public bool Validate() 
        {
            return double.IsPositive(Value);
        }
    }

    /// <summary>
    /// У треугольника сумма двух его сторон должна быть больше третьей стороны
    /// </summary>
    public struct TriangleValidator : IMultipleValuesValidator
    {
        public double[] Values { get; }

        public TriangleValidator(double[] sides)
        {
            Values = sides;

        }

        public bool Validate()
        {
            return (Values.Length >= 3) &&
                   (Values[0] + Values[1] > Values[2] &&
                    Values[0] + Values[2] > Values[1] &&
                    Values[1] + Values[2] > Values[0]);
        }

    }
}
