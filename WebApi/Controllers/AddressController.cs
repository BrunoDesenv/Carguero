using System.Collections.Generic;
using Carguero.Domain.Entities;
using Carguero.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carguero.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private IUserService userService;
        private IAddressService addressService;

        public AddressController(IUserService userService, IAddressService addressService)
        {
            this.userService = userService;
            this.addressService = addressService;
        }

        [HttpGet]
        public IEnumerable<Address> GetAddress(string userName)
        {
            var address = addressService.GetByUserName(userName);

            return address;
        }

        [HttpPut]
        public IActionResult Add(string userName, [FromBody] Address address)
        {
            var user = userService.GetByUserName(userName);
            address.User = user;

            var resultValidate = addressService.CanAdd(address);
            if (!resultValidate.IsValid)
            {
                var errorMessages = new List<string>();
                foreach (var error in resultValidate.Error)
                {
                    errorMessages.Add(error.Message);
                }

                return NotFound(errorMessages);
            }

            addressService.Add(address);

            return StatusCode(200);
        }

        [HttpDelete]
        public IActionResult Delete(int idAddress)
        {
            var address = addressService.GetById(idAddress);
            address.Active = false;

            addressService.Update(address);
            return StatusCode(200);
        }

        [HttpPost]
        public IActionResult Update([FromBody] Address address)
        {
            addressService.Update(address);
            return StatusCode(200);
        }
    }
}
