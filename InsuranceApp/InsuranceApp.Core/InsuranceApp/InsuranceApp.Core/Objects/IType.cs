using InsuranceApp.Core.Objects.NonHumanEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Core.Objects
{
    public interface IType
    {
        ObjectTypes Type { get; }
    }
}
