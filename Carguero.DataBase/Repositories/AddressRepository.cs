using Carguero.DataBase.Context;
using Carguero.Domain.Entities;
using Carguero.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Carguero.DataBase.Repositories
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public void DeleteAddress(int IdUser, int idAddress)
        {
            using (var context = new CargueroContext())
            {
                var entity = context.User.FirstOrDefault(x => x.Id == IdUser);

                entity.Addresses.FirstOrDefault(x => x.Id == idAddress).Active = false;

                context.SaveChanges();
            }
        }

        public IEnumerable<Address> GetByUserName(string userName)
        {
            IEnumerable<Address> entities;
            using (var context = new CargueroContext())
            {
                entities = context.Address.Where(x => x.User.Name == userName);
            }

            return entities;
        }
    }
}
