using InsuranceApp.Core.Finance.Payments;
using InsuranceApp.Core.Objects.NonHumanEntities;
using InsuranceApp.Core.Objects.RiskTypes;
using InsuranceApp.InsuranceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Core.InsuranceContract
{
    public class RiskCoveredCar : IRiskCovered
    {
        public CarRiskTypes Risk { get; set; }
        public CarInsurance CarCovered { get; set; }

        public decimal MaxAmout
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void SetMaxCoverageAmount(Premium payment)
        {
            throw new NotImplementedException();
        }
    }
}
