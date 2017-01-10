namespace InsuranceApp.Objects.NonHumanEntities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CarInsurance : UniqueIdentifier, IGenerateUniqueID
    {
        private string vehicleRegistration;
        private NonHumanObjectsOwner owner;

        protected ObjectTypes Type { get; private set; }

        public string Registration
        {
            get
            {
                return this.vehicleRegistration;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // TODO: Warn that registration value cannot be left empty!
                    throw new NotImplementedException();
                }
                if (value.Length < 8)
                {
                    // TODO: Warn the user that registration cannot be less then eight symbols
                    throw new NotImplementedException();
                }
                this.vehicleRegistration = value;
            }
        }

        public CarInsurance(string vehicleRegistration, NonHumanObjectsOwner vehicleOwner)
        {
            this.Registration = vehicleRegistration;
            this.owner = vehicleOwner;
            this.Type = ObjectTypes.Car;
            base.Identifier = GenerateUniqueNumber();
        }

        public string GenerateUniqueNumber()
        {
            Random rand = new Random();
            string number = Convert.ToString(rand.Next(1, 2000)).PadLeft(4, '0');

            return Convert.ToString((int)this.Type) + number;
        }
    }
}
