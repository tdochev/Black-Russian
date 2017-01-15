using InsuranceApp.Core.Contracts;
using InsuranceApp.Core.Objects.NonHumanEntities;
using InsuranceApp.InsuranceContract;

namespace InsuranceApp.Core.Engine.Factories
{
    public class ContractFactory
    {
        public Contract CreatePropertyContract(IPerson person, decimal amount)
        {
            var property = new PropertyInsurance(person.Address, person);
            return new Contract(person, property, amount);
        }
    }
}
