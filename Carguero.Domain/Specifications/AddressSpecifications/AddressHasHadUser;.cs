using Carguero.Domain.Entities;
using Carguero.Domain.Validation.Interfaces.Specification;

namespace Carguero.Domain.Specifications.AddressSpecifications
{
    public class AddressHasHadUser : ISpecification<Address>
    {
        public bool IsSatisfiedBy(Address address)
        {
            return address.User != null;
        }
    }
}
