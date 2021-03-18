using Carguero.Domain.Validation.Validation;

namespace Carguero.Domain.Validation.Interfaces.Validation
{
    public interface IValidator<in TEntity>
    {
        ValidationResult Validate(TEntity entity);
    }
}
