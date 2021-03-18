using Carguero.Domain.Entities;
using System.Collections.Generic;

namespace Carguero.Domain.Interfaces.Repositories
{
    public interface IAddressRepository : IBaseRepository<Address>
    {
        IEnumerable<Address> GetByUserName(string userName);
    }
}
