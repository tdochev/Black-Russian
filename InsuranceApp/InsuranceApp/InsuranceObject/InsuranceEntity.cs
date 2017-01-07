namespace InsuranceApp.InsuranceObject
{
    //Root for all insurance types - has ID and a method to implement SetID - to put a code for ID generating
    public abstract class InsuranceEntity : Root
    {
        public string ID { get; protected set; }
        public abstract void SetID();

    }
}
