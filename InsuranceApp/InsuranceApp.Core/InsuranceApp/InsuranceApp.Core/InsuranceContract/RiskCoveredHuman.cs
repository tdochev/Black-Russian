using InsuranceApp.Core.Objects.HumanEntities;
using InsuranceApp.Core.Objects.RiskTypes;
using InsuranceApp.InsuranceContract;
using System;

namespace InsuranceApp.Core.InsuranceContract
{
    public class RiskCoveredHuman : IRiskCovered
    {
        public HumanRiskTypes Risk { get; set; }
        public HumanInsurance PersonCovered { get; set; }

        public decimal MaxAmout
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void SetMaxCoverageAmount()
        {
            throw new NotImplementedException();
        }
    }
}
