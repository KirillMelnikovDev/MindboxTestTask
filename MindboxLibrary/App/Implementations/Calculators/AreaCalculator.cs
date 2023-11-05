using MindboxLibrary.App.Interfaces;
using MindboxLibrary.App.Interfaces.Calculators;
using MindboxLibrary.App.Interfaces.Validators;
using System.Security.Cryptography.X509Certificates;

namespace MindboxLibrary.App.Implementations.Calculators
{
    public struct AreaCalculator : IAreaCalculator
    {
        IValidator validator;
        public AreaCalculator(IShape anyShape) 
        {
            
                
        }
        public double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }

    public struct CircleAreaCalculator : IAreaCalculator
    {
        private readonly ISingleValueValidator _validator;

        public CircleAreaCalculator(double radius)
        {
            _validator = new CircleValidator(radius);
        }

        public CircleAreaCalculator(ICircle circle) 
            : this(circle.Radius) { }
        
        public CircleAreaCalculator() 
            : this(0) { }
        
        public double CalculateArea()
        {
            if (_validator.Validate())
            {
                return Math.PI * _validator.Value * _validator.Value;
            }
            else
            {
                throw new ArgumentException("radius is incorrect");
            }
        }
    }

    public struct TriangleAreaCalculator : IAreaCalculator
    {
        private readonly TriangleValidator _validator;
        public TriangleAreaCalculator(double[] sides) 
        {
            _validator = new TriangleValidator(sides);
        }

        public TriangleAreaCalculator(double a, double b, double c) 
            : this(new double[] { a, b, c }) { }

        public TriangleAreaCalculator((double, double, double) sides)
            : this(sides.Item1, sides.Item2, sides.Item3) { }

        public TriangleAreaCalculator() 
            : this(0, 0, 0) { }

        public double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
