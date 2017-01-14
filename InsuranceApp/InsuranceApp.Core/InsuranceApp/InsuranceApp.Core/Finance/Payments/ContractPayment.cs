namespace InsuranceApp.Core.Finance.Payments
{
    using Contracts;
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
        public decimal Amount { get; set; }
        public string Iban
        {
            get
            {
                return this.iban;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidIbanValidationException("IBAN value cannot be left empty!");
                }
                else if(string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidCastException("IBAN value cannot be set with White Space!");
                }
                else if(value.Length < 22)
                {
                    throw new InvalidIbanValidationException("Invalid IBAN. Value must be exactly 22 symbols.");
                }
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidContractValidationException("Contract ID cannot be left empty!");
                }
                else if(string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidContractValidationException("Contract ID value cannot be set with White Space!");
                }
                //else if (!ContractsList.contracts.Contains(value))
                //{
                //    // TODO: After the Insurance Contracts are ready implement verification.
                //    throw new NotImplementedException();
                //}
                this.contractId = value;
            }
        }

        public ContractPayment(string contractOwnerIban, string contractId, PaymentOwner owner)
        {
            this.Iban = contractOwnerIban;
            this.ContractID = contractId;
        }
    }
}
