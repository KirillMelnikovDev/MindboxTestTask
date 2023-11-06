using MindboxLibrary.Interfaces.Calculators;

namespace MindboxLibrary.Interfaces.Shapes
{
    public interface IShape
    {
        IAreaCalculator? AreaCalculator { get; }
    }

    //public class UnknownShape : IShape 
    //{
    //    public IAreaCalculator? AreaCalculator { get; }
    //    public UnknownShape() 
    //    {
    //        AreaCalculator = null;
    //    }
    //}
}
