namespace InsuranceApp.FinancialInfo
{
    using System;
    using InsuranceApp.Models;
    using Contracts;

    class BankAccount
    {
        //Manages bank account information
        //Consists information about bank, account owner, account IBAN
        public IOwner AccountOwner { get; set; }
        public Bank BankOrg { get; set; }
        public string IBAN
        {
            get
            {
                return this.IBAN;
            }
            set
            {

            }
        }
        public BankAccount(IOwner owner, Bank bank, string iban, DateTime start, DateTime end)
        {
            //TODO: Add code here
        }

    }
}
