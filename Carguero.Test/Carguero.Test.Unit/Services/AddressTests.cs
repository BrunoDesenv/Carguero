using Carguero.Domain.Entities;
using Carguero.Domain.Specifications.AddressSpecifications;
using Carguero.Domain.Validation.Validation;
using Xunit;

namespace Carguero.Test.Unit.Services
{
    public class AddressTests : Validator<Address>
    {
        private readonly Address address = new Address();

        public static User user =>
            new User
            {
                   Name = "Bruno",
            };

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Check_Zip_Code_Invalid(string zipCode)
        {
            address.ZipCode = zipCode;
            var zipCodeValidation = new AddressHasHadZipCode();

            var isValid = zipCodeValidation.IsSatisfiedBy(address);

            Assert.False(isValid);
        }

        [Theory]
        [InlineData("123456")]
        [InlineData("123")]
        public void Check_Zip_Code_Valid(string zipCode)
        {
            address.ZipCode = zipCode;
            var zipCodeValidation = new AddressHasHadZipCode();

            var isValid = zipCodeValidation.IsSatisfiedBy(address);

            Assert.True(isValid);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Check_Number_Invalid(string number)
        {
            address.Number = number;
            var numberValidation = new AddressHasHadNumber();

            var isValid = numberValidation.IsSatisfiedBy(address);

            Assert.False(isValid);
        }

        [Theory]
        [InlineData("123456")]
        [InlineData("123")]
        public void Check_Number_Valid(string number)
        {
            address.Number = number;
            var numberValidation = new AddressHasHadNumber();

            var isValid = numberValidation.IsSatisfiedBy(address);

            Assert.True(isValid);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Check_City_Invalid(string city)
        {
            address.City = city;
            var cityValidation = new AddressHasHadCity();

            var isValid = cityValidation.IsSatisfiedBy(address);

            Assert.False(isValid);
        }

        [Theory]
        [InlineData("São Paulo")]
        [InlineData("Coritiba")]
        public void Check_City_Valid(string city)
        {
            address.City = city;
            var cityValidation = new AddressHasHadCity();

            var isValid = cityValidation.IsSatisfiedBy(address);

            Assert.True(isValid);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Check_District_Invalid(string district)
        {
            address.District = district;
            var districtValidation = new AddressHasHadDistrict();

            var isValid = districtValidation.IsSatisfiedBy(address);

            Assert.False(isValid);
        }

        [Theory]
        [InlineData("Brasilia")]
        [InlineData("São Paulo")]
        public void Check_District_Valid(string district)
        {
            address.District = district;
            var districtValidation = new AddressHasHadDistrict();

            var isValid = districtValidation.IsSatisfiedBy(address);

            Assert.True(isValid);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Check_Complement_Invalid(string complement)
        {
            address.Complement = complement;
            var complementValidation = new AddressHasHadComplement();

            var isValid = complementValidation.IsSatisfiedBy(address);

            Assert.False(isValid);
        }

        [Theory]
        [InlineData("Brasilia")]
        [InlineData("São Paulo")]
        public void Check_Complement_Valid(string complement)
        {
            address.Complement = complement;
            var complementValidation = new AddressHasHadComplement();

            var isValid = complementValidation.IsSatisfiedBy(address);

            Assert.True(isValid);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Check_State_Invalid(string state)
        {
            address.State = state;
            var stateValidation = new AddressHasHadNumber();

            var isValid = stateValidation.IsSatisfiedBy(address);

            Assert.False(isValid);
        }

        [Theory]
        [InlineData("Pará")]
        [InlineData("São Paulo")]
        public void Check_State_Valid(string state)
        {
            address.State = state;
            var stateValidation = new AddressHasHadState();

            var isValid = stateValidation.IsSatisfiedBy(address);

            Assert.True(isValid);
        }

        [Theory]
        [InlineData(null)]
        public void Check_State_Invalid(User user)
        {
            address.User = user;
            var userValidation = new AddressHasHadUser();

            var isValid = userValidation.IsSatisfiedBy(address);

            Assert.False(isValid);
        }

        [Theory]
        [MemberData(nameof(user))]
        public void Check_User_Valid(User user)
        {
            address.User = user;
            var userValidation = new AddressHasHadUser();

            var isValid = userValidation.IsSatisfiedBy(address);

            Assert.True(isValid);
        }

    }
}
