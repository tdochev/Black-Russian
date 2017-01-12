namespace InsuranceApp.Core.InsuranceContract
{
    using System;

    public abstract class RiskCovered:Root
    {
        private decimal maxCoverageAmount; //maximum amount which could be received in case of 
                                           //claim covered by this risk
        public decimal MaxAmout { get; }
        public abstract void SetMaxCoverageAmount(); //Method to implement max available amount for coverage - 
                                                     //as % of premium paid and/or other conditions according to
                                                     //the risk (age, conditions of use, etc)
    }
    public class RiskCoveredHuman: RiskCovered
    {
        public HumanRiskType Risk { get; set; }
        public HumanEntity PersonCovered { get; set; }
    }
    public class RiskCoveredCar : RiskCovered
    {
        public CarRiskType Risk { get; set; }
        public Car CarCovered { get; set; }
       
    }
    public class RiskCoveredProperty : RiskCovered
    {
        public PropertyRiskType Risk { get; set; }
        public Property CarCovered { get; set; }

    }
}
