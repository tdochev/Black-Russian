namespace InsuranceApp.Core.Finance.Payments
{
    using Contracts;
    using Objects;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PaymentOwner : Person, IPaymentOwner
    {
        public PaymentOwner(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public void Pay()
        {
            // TODO: Implement after Insurance Contracts are done.
        }
    }
}
