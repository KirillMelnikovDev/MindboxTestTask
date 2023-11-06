namespace MindboxLibrary.Interfaces.Validators
{
    public interface IValidator
    {
        bool Validate();
    }

    public interface ISingleValueValidator : IValidator
    {
        double Value { get; }
    }

    public interface IMultipleValuesValidator : IValidator
    {
        double[] Values { get; }
    }
}
