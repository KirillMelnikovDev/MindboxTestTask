using MindboxLibrary.Interfaces.Validators;

namespace MindboxLibrary.Interfaces.Calculators
{
    public interface IAreaCalculator
    {
        IValidator Validator { get; }
        double CalculateArea();
    }
}
