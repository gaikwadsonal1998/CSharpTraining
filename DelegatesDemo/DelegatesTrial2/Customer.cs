using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTrial2
{
	delegate bool IsEligibleForCashback(Customer cust);
	class Customer
	{
		 public int CustomerID { get; set; }
		public string CustomerName { get; set; }
		public double TotalPurchase { get; set; }
		public int Duration { get; set; }

		public static void Cashback(List<Customer> custlist, IsEligibleForCashback eligible)
		{
			foreach (Customer c in custlist)
			{
				if (eligible(c))
				{
					Console.WriteLine("{0} is eligible for cashback.", c.CustomerName);
				}
			}
			
		}
	}
}
