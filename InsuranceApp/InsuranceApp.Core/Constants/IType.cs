namespace InsuranceApp.Core.Constants
{
    using Objects.NonHumanEntities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IType
    {
        ObjectTypes Type { get; }
    }
}
