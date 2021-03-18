using Carguero.Domain.Entities;

namespace Carguero.Domain.Interfaces.Services
{
    public interface IUserService : IBaseService<User>
    {
        User GetByUserName(string userName);
    }
}
