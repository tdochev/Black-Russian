
namespace InsuranceApp.InsuranceObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class InsuranceEntity : Root
    {
        public string ID { get; protected set; }
        public abstract void SetID();

    }
}
