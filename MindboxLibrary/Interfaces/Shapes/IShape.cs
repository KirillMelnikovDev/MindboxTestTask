using MindboxLibrary.Interfaces.Calculators;

namespace MindboxLibrary.Interfaces.Shapes
{
    public interface IShape
    {
        IAreaCalculator? AreaCalculator { get; }
    }
}
