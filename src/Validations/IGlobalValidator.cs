using FluentValidation.Results;

namespace AppFramework.Validations
{
    public interface IGlobalValidator
    {
        ValidationResult Validate<T>(T model);
    }
}