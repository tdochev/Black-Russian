using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.InsuranceObject
{
    public abstract class NonHuman:InsuranceEntity
    {
        public HumanEntity Owner { get; set; }
    }
}
