using InsuranceApp.Core.Objects.NonHumanEntities;
using InsuranceApp.Core.Objects.RiskTypes;
using InsuranceApp.InsuranceContract;
using System;

namespace InsuranceApp.Core.InsuranceContract
{
    public class RiskCoveredProperty : IRiskCovered
    {
        public PropertyRiskTypes Risk { get; set; }
        public PropertyInsurance PropertyCovered { get; set; }

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
