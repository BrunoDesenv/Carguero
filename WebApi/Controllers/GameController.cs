using System.Collections.Generic;
using Carguero.Domain.Entities;
using Carguero.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carguero.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private IGameService gameService;

        public GameController(IGameService gameService)
        {
            this.gameService = gameService;
        }

        [HttpGet]
        public IEnumerable<GameResult> Get()
        {
            var results = gameService.GetAll();
            return results;
        }

        [HttpPost]
        public IActionResult Post([FromBody] GameResult model)
        {
            gameService.Add(model);
            return StatusCode(201);
        }
    }
}
