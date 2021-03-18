using Carguero.DataBase.Context;
using Carguero.Domain.Entities;
using Carguero.Domain.Interfaces.Repositories;
using System.Linq;

namespace Carguero.DataBase.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public User GetByUserName(string userName)
        {
            User user;
            using (var context = new CargueroContext())
            {
                 user = context.User.FirstOrDefault(x => x.Name == userName);
            }

            return user;
        }

    }
}
