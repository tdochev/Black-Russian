namespace InsuranceApp.Exceptions
{
    using System;

    public class InvalidIbanValidationExeption : Exception
    {
        public InvalidIbanValidationExeption()
        {
        }

        public InvalidIbanValidationExeption(string message) : base(message)
        {
        }

        public InvalidIbanValidationExeption(string message, Exception inner) : base(message, inner)
        {
        }
    }
}