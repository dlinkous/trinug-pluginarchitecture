using System;

namespace HappyStorage.Core
{
	public interface ICustomerStore
	{
		void Create(NewCustomer newCustomer);
		bool CustomerExists(string customerNumber);
		void Delete(string customerNumber);
	}
}
