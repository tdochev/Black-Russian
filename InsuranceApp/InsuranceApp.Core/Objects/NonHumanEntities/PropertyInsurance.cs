namespace InsuranceApp.Core.Objects.NonHumanEntities
{
    using Common;
    using Constants;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PropertyInsurance : IType
    {
        private string propertyAddress;
        private IPerson propertyOwner;
        private const string propertyAddressString = "Property Adredress ";

        protected ObjectTypes Type { get; private set; }

        public string PropertyAddress
        {
            get
            {
                return this.propertyAddress;
            }
            set
            {
                Verification.String(value, propertyAddressString);
                this.propertyAddress = value;
            }
        }

        ObjectTypes IType.Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PropertyInsurance(string propertyAddress, IPerson propertyOwner)
        {
            this.PropertyAddress = propertyAddress;
            this.propertyOwner = propertyOwner;
            this.Type = ObjectTypes.Property;
        }


    }
}
