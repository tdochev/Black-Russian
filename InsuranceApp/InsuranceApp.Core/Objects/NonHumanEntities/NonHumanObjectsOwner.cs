namespace InsuranceApp.Core.Objects.NonHumanEntities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NonHumanObjectsOwner : Person
    {
        public NonHumanObjectsOwner(string ownerFirstName, string ownerMiddleName, string ownerLastName, string ownerAddress, string ownerPhoneNumber) : base(ownerFirstName, ownerMiddleName, ownerLastName, ownerAddress, ownerAddress)
        {

        }
    }
}
