namespace InsuranceApp.Core.Exceptions
{
    using System;

    public class InvalidIbanValidationException : Exception
    {
        public InvalidIbanValidationException()
        {
        }

        public InvalidIbanValidationException(string message) : base(message)
        {
        }

        public InvalidIbanValidationException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}