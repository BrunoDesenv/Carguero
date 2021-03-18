using Carguero.Domain.Entities;
using Carguero.Domain.Interfaces.Repositories;
using Carguero.Domain.Interfaces.Services;
using Carguero.Domain.Validation.AddressValidations;
using Carguero.Domain.Validation.Validation;
using System.Collections.Generic;

namespace Carguero.Domain.Services
{
    public class AddressService : BaseService<Address>, IAddressService
    {
        private readonly IAddressRepository addressRepository;
        public AddressService(IAddressRepository addressRepository) : base(addressRepository)
        {
            this.addressRepository = addressRepository;
        }

        public ValidationResult CanAdd(Address address)
        {
            var registerValidaiton = new AddressCanAdd(address);

            var validation = registerValidaiton.Validate(address);

            return validation;
        }

        public IEnumerable<Address> GetByUserName(string userName)
        {
            return addressRepository.GetByUserName(userName);
        }
    }
}
