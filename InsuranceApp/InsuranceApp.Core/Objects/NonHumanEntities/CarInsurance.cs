namespace InsuranceApp.Core.Objects.NonHumanEntities
{
    using Common;
    using Constants;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CarInsurance : UniqueIdentifier, IGenerateUniqueID, IType
    {
        private string vehicleRegistration;
        private NonHumanObjectsOwner owner;
        private const string registraionString="Car Registraion";

        protected ObjectTypes Type { get; private set; }

        public string Registration
        {
            get
            {
                return this.vehicleRegistration;
            }
            set
            {
                Verification.String(value, registraionString);
                Verification.CarRegistration(value);
                this.vehicleRegistration = value;
            }
        }

        ObjectTypes IType.Type
        {
            get
            {
                throw new NotImplementedException();
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
