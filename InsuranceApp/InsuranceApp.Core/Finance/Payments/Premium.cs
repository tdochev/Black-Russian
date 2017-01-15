namespace InsuranceApp.Core.Finance.Payments
{
    public class Premium
    {
        internal bool paid;

        public decimal Amount { get; internal set; }
        public string ID { get; internal set; }
        public bool Paid { get; private set; }

        public void Subscribe(PaymentManager paymentManager)
        {
            paymentManager.RaisePaidEvent += this.ChangeStatus;
        }
        public void ChangeStatus(object sender, PaymentEventArgs e)
        {
            if (e.Message == $"{this.ID} paid")
            {
                this.Paid = true;
            }
        }
        public Premium(decimal amount)
        {
            this.Amount = amount;
        }
    }
}