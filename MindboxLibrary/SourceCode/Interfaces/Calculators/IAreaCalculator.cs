using MindboxLibrary.SourceCode.Interfaces.Validators;

namespace MindboxLibrary.SourceCode.Interfaces.Calculators
{
    public interface IAreaCalculator
    {
        IValidator Validator { get; }
        double CalculateArea();
    }
}
