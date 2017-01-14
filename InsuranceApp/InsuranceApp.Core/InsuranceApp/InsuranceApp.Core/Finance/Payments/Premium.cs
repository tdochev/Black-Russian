using InsuranceApp.InsuranceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Core.Finance.Payments
{
    public class Premium
    {
        //Manage premiums
        //consists information about premiums done for the contract
        //subscrided to event OnPaid
        private bool paid;
        private Contract contract;
        private string id;

        public string ID
        {
            get
            {
                return this.id;
            }
        }
        public void SetID()
        {
            this.id = contract.ID + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
        }
        public bool Paid
        {
            get
            {
                return this.Payments.Amount == this.Amount;
            }
        }
        public DateTime PaidAtDate { get; set; }
        public ContractPayment Payments { get; set; } //list of payments for this premium (it could be paid by several payments)
        public decimal Amount { get; set; }
        
    }
}
