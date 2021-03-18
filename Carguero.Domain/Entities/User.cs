using System.Collections.Generic;

namespace Carguero.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
        public string DateRegister { get; set; }
    }
}
