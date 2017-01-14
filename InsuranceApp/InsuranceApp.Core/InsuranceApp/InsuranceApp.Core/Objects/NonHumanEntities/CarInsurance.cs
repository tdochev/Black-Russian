﻿namespace InsuranceApp.Core.Objects.NonHumanEntities
{
    using System;
    using Exceptions;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CarInsurance : UniqueIdentifier, IGenerateUniqueID, IType
    {
        private string vehicleRegistration;
        private NonHumanObjectsOwner owner;
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
                    throw new RegistrationEmptyException("Registration value cannot stay null or empty");
                }
                if (value.Length < 8)
                {
                    throw new RegistrationLengthException("Registration length cannot be less than 8");
                }

                this.vehicleRegistration = value;
            }
        }

        public ObjectTypes Type
        {
            get
            {
                return ObjectTypes.Car;
            }
        }

        public CarInsurance(string vehicleRegistration, NonHumanObjectsOwner vehicleOwner)
        {
            this.Registration = vehicleRegistration;
            this.owner = vehicleOwner;
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