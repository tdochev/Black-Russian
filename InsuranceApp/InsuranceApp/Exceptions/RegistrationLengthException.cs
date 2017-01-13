using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Exceptions
{
    public class RegistrationLengthException : ApplicationException
    {
        public RegistrationLengthException()
        {
        }

        public RegistrationLengthException(string message) : base(message)
        {
        }

        public RegistrationLengthException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
