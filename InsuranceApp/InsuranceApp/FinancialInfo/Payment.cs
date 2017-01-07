namespace InsuranceApp.FinancialInfo
{
    using InsuranceObject;
    using System;
    //Manage payments
    //Consists information for payer, date of payment, amount of payment and premium for which the payment is done
    //When payment is received an event is raised
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(Premium forPremium)
        {
            msg = forPremium.ID;
        }
        private string msg;
        public string Message
        {
            get { return msg; }
        }
    }
    public abstract class Payment:Root
    {
        private HumanEntity payer;
        private decimal amount;
        private Premium forPremium;
        private bool received;
        private DateTime paidAtDate;
        public event EventHandler RaiseReceivePayment; //Add event for received payment, add premium id in the message
        protected abstract void OnPaid(CustomEventArgs e);
    }
    public class BankPayment : Payment
    {
        //Add bank account, constructor, implement abstract method, raise event for received payment
    }
    public class CashPayment : Payment
    {
        //Add constructor, implement abstract method, raise event for received payment
    }
}
