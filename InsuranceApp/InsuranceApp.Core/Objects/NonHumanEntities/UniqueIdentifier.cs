namespace InsuranceApp.Core.Objects.NonHumanEntities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class UniqueIdentifier
    {
        private string identifier;

        protected string Identifier
        {
            get
            {
                return this.identifier;
            }
            set
            {
                //Verification ?
                if (value.Length < 6)
                {
                    throw new NotImplementedException();
                }
                this.identifier = value;
            }
        }
    }
}
