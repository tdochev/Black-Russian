using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceApp.InsuranceObject;

namespace InsuranceApp.FinancialInfo
{
    class BankAccount:Root
    {

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
