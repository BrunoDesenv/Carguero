using Carguero.Domain.Entities;
using Carguero.Domain.Interfaces.Repositories;

namespace Carguero.DataBase.Repositories
{
    public class GameRepository : BaseRepository<GameResult>, IGameRepository
    {
    }
}
