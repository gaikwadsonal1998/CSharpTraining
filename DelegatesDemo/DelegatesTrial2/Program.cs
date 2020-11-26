using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTrial2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Customer> customerList = new List<Customer>();
			customerList.Add(new Customer() { CustomerID=1,CustomerName="Sonal",Duration = 5,TotalPurchase=2000});
			customerList.Add(new Customer() { CustomerID = 1, CustomerName = "fefe", Duration = 10, TotalPurchase = 20000 });
			customerList.Add(new Customer() { CustomerID = 1, CustomerName = "Shfbjkl", Duration = 7, TotalPurchase = 12000 });
			customerList.Add(new Customer() { CustomerID = 1, CustomerName = "jkdhsdk", Duration = 15, TotalPurchase = 700 });

			IsEligibleForCashback iseligiblefor = new IsEligibleForCashback(NewMethod);
			Customer.Cashback(customerList,iseligiblefor);
		}

		public static bool NewMethod(Customer c)
		{
			if (c.TotalPurchase > 5000 || c.Duration > 5)
			{
				return true;
			}
			else
			{
				return false;

			}
		}
	}
}
