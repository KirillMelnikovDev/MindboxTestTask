namespace MindboxLibrary.App.Interfaces
{
    //Вычислятор плошади
    //public interface IAreaCalculator
    //{
    //    //Вычисли
    //    public double Calculate();
    //}
    public class AreaCalculator //: IAreaCalculator
    {
        private AreaCalculator() { }
        public AreaCalculator(IShape shape)
        {
            Shape = shape;
        }

        public IShape Shape { get; set; }

        public double Calculate()
        {
            return 0;
        }
    }

    public interface IShape
    {
        public double[] GetMeasures();
    }
    public interface ITriangle : IShape
    {
        //Три стороны треугольника
        public (double, double, double) Sides { get; set; }
    }
    
    public interface ICircle : IShape
    {
        //Радиус круга
        public double Radius { get; set; }
    }
    public class Circle : ICircle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }
        public double[] GetMeasures()
        {
            return new double[] { Radius };
        }
    }
    public interface ISquare : IShape
    {
        //Две стороны квадрата
        public (double, double) Sides { get; set; }
    }
    public struct CircleData : ICircle
    {
        public double Radius { get; set; }
        public double[] GetMeasures()
        {
            return new double[] { Radius };
        }
    }
}
