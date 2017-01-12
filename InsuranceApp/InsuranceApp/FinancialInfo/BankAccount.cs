namespace InsuranceApp.FinancialInfo
{
    using System;
    using System.Text;
    using Exceptions;
    using Objects;

    internal class BankAccount
    {
        //Manages bank account information
        //Consists information about bank, account owner, account IBAN
        private const int initialExpirationTime = 10; // years
        private string iban;

        public DateTime CreationDate { get; }
        public DateTime ExpirationDate { get; set; }
        public Person AccountOwner { get; }
        public Bank BankOrg { get; }

        public string IBAN
        {
            get
            {
                return this.iban;
            }
            set
            {
                if (!ValidateIban(value))
                {
                    throw new InvalidIbanValidationExeption("Incorrectly entered IBAN: possible reason not allowed char/s");
                }

                this.iban = value.ToUpper();
            }
        }

        public BankAccount(Person owner, Bank bank, string iban)
        {
            this.AccountOwner = owner;
            this.BankOrg = bank;
            this.IBAN = iban;
            this.CreationDate = DateTime.Now;
            this.ExpirationDate = this.CreationDate.AddYears(initialExpirationTime);
        }

        public BankAccount(Person owner, Bank bank, string iban, DateTime creationDate, DateTime expirationDate)
        {
            this.AccountOwner = owner;
            this.BankOrg = bank;
            this.IBAN = iban;
            this.CreationDate = creationDate;
            this.ExpirationDate = expirationDate;
        }

        private static bool ValidateIban(string iban)
        {
            iban = iban.ToUpper(); //IN ORDER TO COPE WITH THE REGEX BELOW
            if (String.IsNullOrEmpty(iban))
                return false;
            else if (System.Text.RegularExpressions.Regex.IsMatch(iban, "^[A-Z0-9]"))
            {
                iban = iban.Replace(" ", String.Empty);
                string bank =
                iban.Substring(4, iban.Length - 4) + iban.Substring(0, 4);
                int asciiShift = 55;
                StringBuilder sb = new StringBuilder();
                foreach (char c in bank)
                {
                    int v;
                    if (Char.IsLetter(c)) v = c - asciiShift;
                    else v = int.Parse(c.ToString());
                    sb.Append(v);
                }
                string checkSumString = sb.ToString();
                int checksum = int.Parse(checkSumString.Substring(0, 1));
                for (int i = 1; i < checkSumString.Length; i++)
                {
                    int v = int.Parse(checkSumString.Substring(i, 1));
                    checksum *= 10;
                    checksum += v;
                    checksum %= 97;
                }
                return checksum == 1;
            }
            else
                return false;
        }
    }
}