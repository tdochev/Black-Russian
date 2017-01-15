namespace InsuranceApp.Core.Finance.Payments
{
    using Common;
    using Contracts;
    using Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ContractPayment : IContractPayment
    {
        private string iban;
        private string contractId;
        private PaymentOwner owner;
        private const string ibanString = "IBAN value";
        private const string contacIDString = "IBAN value";
        public string Iban
        {
            get
            {
                return this.iban;
            }

            private set
            {
                Verification.StringExcactLength(value, ibanString, 22);
                this.iban = value;
            }
        }

        public string ContractID
        {
            get
            {
                return this.contractId;
            }

            private set
            {
                Verification.String(value, contacIDString);

                //else if (!ContractsList.contracts.Contains(value))
                //{
                //    // TODO: After the Insurance Contracts are ready implement verification.
                //    throw new NotImplementedException();
                //}
                this.contractId = value;
            }
        }

        public decimal Amount { get; internal set; }

        public ContractPayment(decimal amount, string contractOwnerIban, string contractId, PaymentOwner owner)
        {
            this.Iban = contractOwnerIban;
            this.ContractID = contractId;
            this.Amount = amount;
        }
    }
}
