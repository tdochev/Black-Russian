using System;

namespace InsuranceApp.Core.Contracts
{
	public interface IPerson
	{
		string FirstName { get; }

		string MiddleName { get; }

		string LastName { get; }

		string PersonalID { get;  }

		string Address { get; }

		string PhoneNumber { get;  }
	}
}
