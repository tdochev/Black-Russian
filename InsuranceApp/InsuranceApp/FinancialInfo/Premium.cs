namespace InsuranceApp.FinancialInfo
{
    using Enumerations;
    using System;
    using System.Collections.Generic;
    public class Premium:Root
    {
        //Manage premiums
        //consists information about premiums done for the contract
        //subscrided to event OnPaid
        private bool paid;
        public bool Paid
        {
            get
            {
                return this.paid;
            }
        }
        public DateTime PaidAtDate { get; set; }
        public List<Payment> Payments { get; set; } //list of payments for this premium (it could be paid by several payments)
        public PaymentType PaymentMode { get; set; } //could be by bank transfer or cash
        public decimal Amount { get; set; }
        void Pay(object sender, CustomEventArgs e)
        {
            //TODO: add code to pay premium - if sum of payments = premium amount, set as paid
            //sunscribe to OnPaid raised for received payment
        }
    }
}
