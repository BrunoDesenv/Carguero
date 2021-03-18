using Carguero.Domain.Entities;
using Carguero.Domain.Interfaces.Repositories;
using Carguero.Domain.Interfaces.Services;

namespace Carguero.Domain.Services
{
    public class GameService : BaseService<GameResult>, IGameService
    {
        private readonly IGameRepository gameRepository;
        public GameService(IGameRepository gameRepository) : base(gameRepository)
        {
            this.gameRepository = gameRepository;
        }
    }
}
