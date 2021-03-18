using Carguero.Domain.Entities;
using Carguero.Domain.Validation.Validation;
using System.Collections.Generic;

namespace Carguero.Domain.Interfaces.Services
{
    public interface IAddressService : IBaseService<Address>
    {
        ValidationResult CanAdd(Address address);
        IEnumerable<Address> GetByUserName(string userName);
    }
}
