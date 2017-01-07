namespace InsuranceApp.FinancialInfo
{
    using System;
    using InsuranceApp.InsuranceObject;
    class BankAccount:Root
    {
        //Manages bank account information
        //Consists information about bank, account owner, account IBAN
        public HumanEntity AccountOwner { get; set; }
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
        public BankAccount(HumanEntity owner, Bank bank, string iban, DateTime start, DateTime end)
        {
            //TODO: Add code here
        }

    }
}
