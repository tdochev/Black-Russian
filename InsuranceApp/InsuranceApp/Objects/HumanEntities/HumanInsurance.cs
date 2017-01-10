namespace InsuranceApp.Objects.HumanEntities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HumanInsurance : Person
    {
        public HumanInsurance(string firstName, string middleName, string lastName, string address, string phoneNumber, string personalID) : base(firstName, middleName, lastName, address, phoneNumber, personalID)
        {
        }
    }
}
