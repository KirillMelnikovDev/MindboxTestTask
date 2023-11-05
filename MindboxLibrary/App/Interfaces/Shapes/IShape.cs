using MindboxLibrary.App.Implementations.Calculators;
using MindboxLibrary.App.Interfaces.Calculators;
using MindboxLibrary.App.Interfaces.Validators;

namespace MindboxLibrary.App.Interfaces.Shapes
{
    /// <summary>
    /// Данные по фигуре
    /// </summary>
    public interface IShape
    {
        public IValidator Validator {get;}
        public IAreaCalculator AreaCalculator { get;}
        public IPerimeterCalculator PerimeterCalculator { get;}
        public double CalculateArea();
        public double CalculatePerimeter();
    }

    public struct Shape : IShape
    {
        public IValidator Validator { get;}
        public IAreaCalculator AreaCalculator { get;}

        public IPerimeterCalculator PerimeterCalculator { get; }

        public Shape(IShape shape)
        {
            Validator = shape.Validator;
            AreaCalculator = shape.AreaCalculator;
            PerimeterCalculator = shape.PerimeterCalculator;
        }

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
