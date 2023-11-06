using MindboxLibrary.Interfaces.Calculators;

namespace MindboxLibrary.Implementations.Calculators
{
    internal class RightAngleChecker : IAngleChecker
    {
        protected List<double> _sides { get; }
        public RightAngleChecker(double a, double b, double c)
        {
            _sides = new List<double>() { a, b, c };
        }
        private RightAngleChecker()
            : this(0, 0, 0)
        { }

        /// <summary>
        /// Треугольник прямоугольный, когда квадрат гипотенузы равен сумме квадратов катетов
        /// </summary>
        public bool CheckAngle()
        {
            //чтоб не определять вручную, какая сторона больше
            var hypotenuse = _sides.Max();
            _sides.Remove(hypotenuse);

            var isRightAngle = hypotenuse * hypotenuse == _sides.Sum(side => side * side);
            return isRightAngle;
        }
    }
}
