using Carguero.Domain.Entities;
using Carguero.Domain.Specifications.AddressSpecifications;
using Carguero.Domain.Validation.Validation;

namespace Carguero.Domain.Validation.AddressValidations
{
    public class AddressCanAdd : Validator<Address>
    {
        public AddressCanAdd(Address address)
        {
            var oneCity = new AddressHasHadCity();
            base.Add("Endereço deve possuir cidade.", new Rule<Address>(oneCity, "Cidade não informada."));

            var oneComplement = new AddressHasHadComplement();
            base.Add("Endereço deve possuir complemento.", new Rule<Address>(oneComplement, "Complemento não informada."));

            var oneDistrict = new AddressHasHadDistrict();
            base.Add("Endereço deve possuir distrito.", new Rule<Address>(oneDistrict, "Distrito não informada."));

            var oneNumber = new AddressHasHadNumber();
            base.Add("Endereço deve possuir número.", new Rule<Address>(oneNumber, "Número não foi informada."));

            var oneState = new AddressHasHadState();
            base.Add("Endereço deve possuir estado.", new Rule<Address>(oneState, "Estado não foi informado."));

            var oneUser = new AddressHasHadUser();
            base.Add("Endereço deve possuir usuário.", new Rule<Address>(oneUser, "Usuário não foi informado."));

            var oneZipCode = new AddressHasHadZipCode();
            base.Add("Endereço deve possuir cep.", new Rule<Address>(oneZipCode, "CEP não foi informado."));
        }   
    }
}
