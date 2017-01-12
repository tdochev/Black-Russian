namespace InsuranceApp.FinancialInfo
{
    using System;

    public struct Bank 
    {
        //Consists information about bank - name, code
        private string bic;
        public string BankName { get; set; }

        public string BICCode
        {
            get
            {
                return this.bic;
            }
            set
            {
                if (value.Length!=8)
                {
                    throw new ArgumentException("Invalid BIC/SWIFT code: Code length less than 8 symbols");
                }

                if (value.Contains("0") || value.Contains("1") || value.Contains("2") || value.Contains("3") ||
                    value.Contains("4") || value.Contains("5") || value.Contains("6") || value.Contains("7") ||
                    value.Contains("8") || value.Contains("9"))
                {
                    throw new ArgumentException("Invalid BIC/SWIFT code: Code cannot contain digits!");
                }

                bic = value.ToUpper();
            }
        }
    }
}
