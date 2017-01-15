namespace InsuranceApp.Core.Objects.HumanEntities
{
    using Constants;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NonHumanEntities;

    public class HumanInsurance : Person, IType
    {
        public HumanInsurance(string firstName, string middleName, string lastName, string address, string phoneNumber, string personalID) : base(firstName, middleName, lastName, address, phoneNumber, personalID)
        {
        }

        public ObjectTypes Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
