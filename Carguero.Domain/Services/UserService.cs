using Carguero.Domain.Entities;
using Carguero.Domain.Interfaces.Repositories;
using Carguero.Domain.Interfaces.Services;

namespace Carguero.Domain.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            this.userRepository = userRepository;
        }

        public User GetByUserName(string userName)
        {
            return userRepository.GetByUserName(userName);
        }
    }
}
