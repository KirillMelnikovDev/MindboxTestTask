using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxLibrary.App.Implementations.Calculators
{
    public interface IPerimeterCalculator
    {
        public double CalculatePerimeter();
    }
    public struct CirclePerimeterCalculator : IPerimeterCalculator
    {
        double _radius;
        public CirclePerimeterCalculator(double radius) 
        {
            _radius = radius;
        }
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
