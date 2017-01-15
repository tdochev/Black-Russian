using System;
using System.Collections.Generic;
using System.Linq;

namespace InsuranceApp.Core.Finance.Payments
{
    public class PaymentManager
    {
        private List<ContractPayment> payments;
        private Premium premiumToPay;
        private PaymentOwner owner;
        private decimal amount;
        public event EventHandler<PaymentEventArgs> RaisePaidEvent;
        public void Pay(string contractOwnerIban, string contractId, PaymentOwner owner)
        {
            this.payments.Add(new ContractPayment(this.amount, contractOwnerIban, contractId, this.owner));
            if (this.payments.Sum(payment => payment.Amount) >= this.premiumToPay.Amount)
            {
                OnPay(new PaymentEventArgs(this.premiumToPay.ID));
            }
        }

        private void OnPay(PaymentEventArgs paymentEventArgs)
        {
            EventHandler<PaymentEventArgs> handler = RaisePaidEvent;

            if (handler != null)
            {
                handler(this, paymentEventArgs);
            }
        }
        public PaymentManager(Premium premiumToPay)
        {
            this.premiumToPay = premiumToPay;
            this.amount = premiumToPay.Amount;
        }
    }
}
