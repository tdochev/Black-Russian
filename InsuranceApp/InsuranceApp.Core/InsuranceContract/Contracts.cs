namespace InsuranceApp.Core.InsuranceContract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Contracts
    {
    }
}
<<<<<<< HEAD:InsuranceApp/InsuranceApp/InsuranceContract/Contract.cs
    namespace InsuranceApp.InsuranceContract
{
    using Core.Exceptions;
    using Core.Finance.Payments;
    using Core.InsuranceContract;
    using Core.Objects;
    using Core.Objects.NonHumanEntities;
    using System;
    using System.Collections.Generic;
    public class Contract : IID
    //The class describes insurance contract. The contract types depends on RiskCovered and InsuranceEntity - i.e

    {
        private List<IRiskCovered> risksCovered; //list of instances of RiskCovered successors
        private Premium premiumPaid; //premium for the contract
        private string id;
        public Person Owner { get; set; } //person which is contract owner
        public IType InsuranceObject { get; set; } //insured object - car, property, person(could be the same as owner)
        public bool Active
        //Implement check if the premium isp aid - if yes Active=true
        {
            get
            {
                if (this.premiumPaid.paid)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = this.Owner.FirstName + Owner.PersonalID + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
            }
        }

        public void AddRisk(IRiskCovered risk)
        {
            //Control the insured type and risk type consistency
            if (((risk as RiskCoveredHuman) != null) && this.InsuranceObject.Type != ObjectTypes.Human)
                throw new InvalidContractValidationException("Risk must be of human type");
            if (((risk as RiskCoveredCar) != null) && this.InsuranceObject.Type != ObjectTypes.Car)
                throw new InvalidContractValidationException("Risk must be of car type");
            if (((risk as RiskCoveredProperty) != null) && this.InsuranceObject.Type != ObjectTypes.Property)
                throw new InvalidContractValidationException("Risk must be of property type");
            risk.SetMaxCoverageAmount(this.premiumPaid);
            this.risksCovered.Add(risk);
        }
        public Contract(Person owner, IType insuranceObject, decimal amountOfPremium)
        {
            if (owner == null)
            {
                throw new InvalidContractValidationException("Contract owner null");
            }
            if (insuranceObject == null)
            {
                throw new InvalidContractValidationException("Insurance object null");
            }
            this.risksCovered = new List<IRiskCovered>();
            this.premiumPaid = new Premium(amountOfPremium);
        }
    }
}
>>>>>>> origin/master:InsuranceApp/InsuranceApp.Core/InsuranceContract/Contract.cs
