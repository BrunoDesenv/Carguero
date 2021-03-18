using Carguero.Domain.Entities;
using Carguero.Domain.Validation.Interfaces.Specification;

namespace Carguero.Domain.Specifications.AddressSpecifications
{
    public class AddressHasHadState : ISpecification<Address>
    {
        public bool IsSatisfiedBy(Address address)
        {
            return !string.IsNullOrEmpty(address.State);
        }
    }
}
