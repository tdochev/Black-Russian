using System;

namespace InsuranceApp.Contracts
{
	public interface IOwner
	{
		string FirstName { get; }

		string MiddleName { get; }

		string LastName { get; }

		string ID { get;  }

		string Address { get; }

		string PhoneNumber { get;  }
	}
}
