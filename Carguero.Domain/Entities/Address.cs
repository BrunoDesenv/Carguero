namespace Carguero.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string ZipCode { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Complement { get; set; }
        public string State { get; set; }
        public bool Active { get; set; }
    }
}
