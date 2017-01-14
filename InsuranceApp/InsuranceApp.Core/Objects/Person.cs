namespace InsuranceApp.Core.Objects
{
    using Common;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Person : IPerson
    {
        private const string firstNameString = "First Name";
        private const string middleNameString = "Midle Name";
        private const string lastNameString = "Last Name";
        private const string personalIDString = "Personal ID";
        private const string addressString = "Adress";
        private const string phoneNumberString = "Phone Number";

        private string firstName;
        private string middleName;
        private string lastName;
        private string personalID;
        private string address;
        private string phoneNumber;

        public string FirstName
        {
            get
            { 
                return this.firstName;
            }
            private set
            {
                Verification.String(value, firstNameString);
                
               this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            private set
            {

                Verification.String(value, middleNameString);
               this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                Verification.String(value, lastNameString);
               this.lastName = value;
            }
        }

        public string PersonalID
        {
            get
            {
                return this.personalID;
            }
            private set
            {
                Verification.String(value, personalIDString);

                Verification.PersonalID(value);
               this.personalID = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            private set
            {
                Verification.String(value, addressString);

               this.address = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            private set
            {
                Verification.String(value, phoneNumberString);
               
                Verification.Phone(value);

               this.phoneNumber = value;
            }
        }

        /// <summary>
        /// This constructor will be used for Payment Owner.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// This Constructor will be used for Owner and HumanInsurance classes.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="personalID"></param>
        public Person(string firstName, string middleName, string lastName, string address, string phoneNumber, string personalID = "none")
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.PersonalID = personalID;
        }
    }
}
