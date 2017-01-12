namespace InsuranceApp.Models
{
    using System;

	using InsuranceApp.Contracts;

	public abstract class Person : IOwner
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string address;
        private string phoneNumber;
        private string iD;

        public string FirstName
        {
            get
            { 
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // TODO: Warn the user that value cannot be left empty
                    throw new NotImplementedException();
                }
                if (string.IsNullOrWhiteSpace(value))
                {
                    // TODO: Warn the user that value cannot be Whitespace
                    throw new NotImplementedException();
                }
                this.firstName = value;
            }
        }

        public virtual string ID
        {
            get
            {
                return this.iD;
            }
            set
            {
                // TODO: Add basic validation
                this.iD = value;
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
                if (string.IsNullOrEmpty(value))
                {
                    // TODO: Warn the user that value cannot be left empty
                    throw new NotImplementedException();
                }
                if (string.IsNullOrWhiteSpace(value))
                {
                    // TODO: Warn the user that value cannot be Whitespace
                    throw new NotImplementedException();
                }
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
                if (string.IsNullOrEmpty(value))
                {
                    // TODO: Warn the user that value cannot be left empty
                    throw new NotImplementedException();
                }
                if (string.IsNullOrWhiteSpace(value))
                {
                    // TODO: Warn the user that value cannot be Whitespace
                    throw new NotImplementedException();
                }
                this.lastName = value;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new NotImplementedException();
                }
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NotImplementedException();
                }
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new NotImplementedException();
                }
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NotImplementedException();
                }
                this.phoneNumber = value;
            }
        }

        /// <summary>
        /// This constructor will be used for Bank Account Owner.
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
        public Person(string firstName, string middleName, string lastName, string address, string phoneNumber, string id) : this (firstName, lastName)
        {
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.iD = id;
        }
    }
}
