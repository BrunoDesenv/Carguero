using Carguero.Domain.Entities;

namespace Carguero.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetByUserName(string userName);
    }
}
