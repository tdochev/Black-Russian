using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Exceptions
{
    public class RegistrationEmptyException : ApplicationException
    {
        public RegistrationEmptyException()
        {
        }

        public RegistrationEmptyException(string message) : base(message)
        {
        }

        public RegistrationEmptyException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
