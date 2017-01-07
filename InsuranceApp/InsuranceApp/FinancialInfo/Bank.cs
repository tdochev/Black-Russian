namespace InsuranceApp.FinancialInfo
{
    using System;

    public class Bank:Root
    {
        //Consists information about bank - name, code
        public string BankName { get; set; }
        public string BICCode
        {
            get
            {
                return this.BICCode;
            }
            set
            {
                if (value.Length!=8)
                {
                    throw new ArgumentException("Invalid BIC code: Code length less than 8 symbols");
                }
                if (value.ToUpper().Substring(0, 3) != "STS")
                {
                    throw new ArgumentException("Invalid BIC code: BIC code must start with STS");
                }
                BICCode = value.ToUpper();
            }
        }
        public Bank(string bank, string bicCode)
        {
            this.BankName = bank;
            this.BICCode = bicCode;
        }
    }
}
