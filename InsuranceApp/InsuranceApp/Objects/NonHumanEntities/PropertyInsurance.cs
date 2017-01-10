namespace InsuranceApp.Objects.NonHumanEntities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PropertyInsurance
    {
        private string propertyAddress;
        private NonHumanObjectsOwner propertyOwner;

        protected ObjectTypes Type { get; private set; }

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

        public PropertyInsurance(string propertyAddress, NonHumanObjectsOwner propertyOwner)
        {
            this.PropertyAddress = propertyAddress;
            this.propertyOwner = propertyOwner;
            this.Type = ObjectTypes.Property;
        }


    }
}
