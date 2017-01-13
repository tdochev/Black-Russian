    namespace InsuranceApp.InsuranceContract
{
    using FinancialInfo;
    using InsuranceObject;
    using System.Collections.Generic;
    public class Contract<T, S>
        where T:RiskCovered
        where S:InsuranceEntity
        //The class describes insurance contract. The contract types depends on RisLCovered and InsuranceEntity - i.e
        //if you want to make a contract for car insurance T must be RiskCoveredCar, S:Car , etc
    {
        private List<T> risksCovered; //list of instances of RiskCovered successors
        private decimal contractAmount; //the sum of premiums paid amount
        private List<Premium> premiumsPaid; //a list of premiums for the contract
        public decimal ContractAmount { get; set; } //Implement contract amount setting
        
        public HumanEntity Owner { get; set; } //person which is contract owner
        public S InsuranceObject { get; set; } //insured object - car, property, person(could be the same as owner)
        public bool Active { get; } //Implement check if the premium isp aid - if yes Active=true
        public void CalculateMaxAmountCoverages()
        {
            //Implment method by calling SetMaxCoverageAmount for each risk covered
        }
    }
}
