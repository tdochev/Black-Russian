namespace InsuranceApp.InsuranceObject
{
    using System;
    using System.Device.Location;

    public class HumanEntity:InsuranceEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string PersonalID { get; set; } //EGN

        public CivicAddress OwnerAddress { get; set; }
        public override void SetID()
        {
            this.ID = this.FirstName.Substring(0, 1) + this.MiddleName.Substring(0, 1) + this.LastName.Substring(0, 1) + PersonalID;
        }

        public HumanEntity()
        {
                
        }
    }
}
