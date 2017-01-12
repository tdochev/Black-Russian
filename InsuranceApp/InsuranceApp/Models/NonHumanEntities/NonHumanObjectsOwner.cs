namespace InsuranceApp.Models.NonHumanEntities
{
    using Contracts;

    public class Company : Person, IOwner
    {

        public Company(string ownerFirstName, string ownerMiddleName, string ownerLastName, string ownerAddress, string ownerPhoneNumber, string companyNumber) : base(ownerFirstName, ownerMiddleName, ownerLastName, ownerAddress, ownerAddress, companyNumber)
        {

        }

    }
}
