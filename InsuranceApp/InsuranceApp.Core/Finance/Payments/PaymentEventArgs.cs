using System;

namespace InsuranceApp.Core.Finance.Payments
{
    public class PaymentEventArgs : EventArgs
    {
        public PaymentEventArgs(string s)
        {
            msg = s;
        }
        private string msg;
        public string Message
        {
            get { return msg; }
        }
    }
}
