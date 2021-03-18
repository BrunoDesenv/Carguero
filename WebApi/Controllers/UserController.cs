using Carguero.Domain.Entities;
using Carguero.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Carguero.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
                var users = userService.GetAll();

                return users;
        }

        [HttpPost]
        public IActionResult Add([FromBody]User user)
        {
            userService.Add(user);
            return StatusCode(201);
        }
    }
}

