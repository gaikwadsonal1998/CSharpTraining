using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment6
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Customer customer = new Customer();

				Console.WriteLine("Enter the employeeID : ");
				customer.CustomerID = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Enter the employee Name : ");
				customer.CustomerName = Console.ReadLine();

				Console.WriteLine("Enter the Address : ");
				customer.Address = Console.ReadLine();

				Console.WriteLine("Enter the city : ");
				customer.City = Console.ReadLine();

				Console.WriteLine("Enter the Phone : ");
				customer.Phone = Console.ReadLine();

				Console.WriteLine("Enter the CreditLimit : ");
				customer.CreditLimit = Convert.ToInt32(Console.ReadLine());
				if (customer.CreditLimit > 50000)
				{
					
					throw new InvalidCreditLimitException("Credit limit should be less than 50000");
				}
			}
			catch (InvalidCreditLimitException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
