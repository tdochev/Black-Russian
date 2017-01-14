namespace InsuranceApp.Core.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IContractPayment
    {
        string Iban { get; }
        string ContractID { get; }
    }
}
