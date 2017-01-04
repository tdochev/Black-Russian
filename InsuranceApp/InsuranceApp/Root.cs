using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp
{
    public abstract class Root
    {
        protected DateTime creationDate;
        protected DateTime validDate;
        public bool Valid
        {
            get
            {
                if (DateTime.Now > this.validDate || DateTime.Now < creationDate)
                    return false;
                else
                    return true;
            }
        }
        public bool IsValidAtDate(DateTime date)
        {
            {
                if (DateTime.Now > date || date < creationDate)
                    return false;
                else
                    return true;
            }
        }
    }
}
