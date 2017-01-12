using System;

namespace InsuranceApp.Engine
{

    public class Verification
    {
        internal static void String(string value,string Name)
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
    }
}
