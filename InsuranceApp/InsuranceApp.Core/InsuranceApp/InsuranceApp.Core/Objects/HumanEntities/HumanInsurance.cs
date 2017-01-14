namespace InsuranceApp.Core.Objects.HumanEntities
{
    using NonHumanEntities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HumanInsurance : Person, IType
    {
        public HumanInsurance(string firstName, string middleName, string lastName, string address, string phoneNumber, string personalID) : base(firstName, middleName, lastName, address, phoneNumber, personalID)
        {
        }

        public ObjectTypes Type
        {
            get
            {
                return ObjectTypes.Human;
            }
        }
    }
}
