namespace InsuranceApp.Models.NonHumanEntities
{
    using System;
    using Enums;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts;

    public class PropertyInsurance
    {
        private string propertyAddress;
        private IOwner propertyOwner;

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

        public PropertyInsurance(string propertyAddress, IOwner propertyOwner)
        {
            this.PropertyAddress = propertyAddress;
            this.propertyOwner = propertyOwner;
            this.Type = ObjectTypes.Property;
        }


    }
}
