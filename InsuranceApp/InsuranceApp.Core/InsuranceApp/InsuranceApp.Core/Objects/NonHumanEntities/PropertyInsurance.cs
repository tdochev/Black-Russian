namespace InsuranceApp.Core.Objects.NonHumanEntities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PropertyInsurance:IType
    {
        private string propertyAddress;
        private NonHumanObjectsOwner propertyOwner;
        public string PropertyAddress
        {
            get
            {
                return this.propertyAddress;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NotFiniteNumberException();
                }
                this.propertyAddress = value;
            }
        }

        public ObjectTypes Type
        {
            get
            {
                return ObjectTypes.Property;
            }
        }

        public PropertyInsurance(string propertyAddress, NonHumanObjectsOwner propertyOwner)
        {
            this.PropertyAddress = propertyAddress;
            this.propertyOwner = propertyOwner;
        }


    }
}
