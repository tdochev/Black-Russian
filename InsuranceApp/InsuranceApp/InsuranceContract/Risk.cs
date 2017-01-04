namespace InsuranceApp.InsuranceContract
{
    using InsuranceObject;
    using System;

    public enum HumanRiskType
    {
        Death,
        TotalIncapacity,
        PartialIncapacity,
        Illness
    }
    public enum PropertyRiskType
    {
        Fire,
        Flood,
        EarthQuake,
        Terorism
    }
    public enum CarRiskType
    {
        Fire,
        Flood,
        Accident
    }
    public abstract class RiskCovered:Root
    {
        private decimal maxCoverageAmount;
        public decimal MaxAmout { get; }
        public abstract void SetMaxCoverageAmount();
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
