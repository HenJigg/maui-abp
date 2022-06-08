using FluentValidation;
using FluentValidation.Results;

namespace AppFramework.Validations
{
    public class GlobalValidator : ValidatorFactoryBase, IGlobalValidator
    {
        private readonly IContainerProvider provider;

        public GlobalValidator(IContainerProvider provider)
        {
            this.provider = provider;
        }

        public override IValidator CreateInstance(Type validatorType)
        {
            return provider.Resolve(validatorType) as IValidator; 
        }

        public ValidationResult Validate<T>(T model)
        {
            return GetValidator<T>().Validate(model);
        }
    }
}