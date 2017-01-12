using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Core.Common
{
    class Verification
    {
        internal static void String(string value, string firstNameString)
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
        }

        internal static void Phone(string value)
        {
            throw new NotImplementedException();
        }

        internal static void CarRegistration(string value)
        {
            throw new NotImplementedException();
        }

        internal static void PersonalID(string value)
        {
            throw new NotImplementedException();
        }
    }
}
