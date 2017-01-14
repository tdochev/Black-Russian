
﻿namespace InsuranceApp.InsuranceContract
{
    using Core.Objects.HumanEntities;
    using Core.Objects.NonHumanEntities;
    using Core.Objects.RiskTypes;
    using System;

    public interface IRiskCovered
    {
       
        decimal MaxAmout { get; }
        void SetMaxCoverageAmount(); //Method to implement max available amount for coverage - 
                                     //as % of premium paid and/or other conditions according to
                                     //the risk (age, conditions of use, etc)
    }
}
