using System;
using System.IO;
using HappyStorage.Core;

namespace HappyStorage.FileStorage
{
	public class FileCustomerStore : ICustomerStore
	{
		private readonly IFileCustomerStoreSettings fileCustomerStoreSettings;

		public FileCustomerStore(IFileCustomerStoreSettings fileCustomerStoreSettings) =>
			this.fileCustomerStoreSettings = fileCustomerStoreSettings ?? throw new ArgumentNullException(nameof(fileCustomerStoreSettings));

		public void Create(NewCustomer newCustomer)
		{
			File.WriteAllText(GetFullNamePath(newCustomer.CustomerNumber), newCustomer.FullName);
			File.WriteAllText(GetAddressPath(newCustomer.CustomerNumber), newCustomer.Address);
		}

		public bool CustomerExists(string customerNumber) => File.Exists(GetFullNamePath(customerNumber)) || File.Exists(GetAddressPath(customerNumber));

		public void Delete(string customerNumber)
		{
			File.Delete(GetFullNamePath(customerNumber));
			File.Delete(GetAddressPath(customerNumber));
		}

		private string GetFullNamePath(string customerNumber) => $"{fileCustomerStoreSettings.GetRootPath()}\\{customerNumber}_FullName.txt";

		private string GetAddressPath(string customerNumber) => $"{fileCustomerStoreSettings.GetRootPath()}\\{customerNumber}_Address.txt";
	}
}
