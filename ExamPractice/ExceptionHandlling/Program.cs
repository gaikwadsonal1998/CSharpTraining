using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlling
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Customer c = new Customer();
				Console.WriteLine("Enter card limit");
				c.CreditLimit = Convert.ToInt32(Console.ReadLine());
				if(c.CreditLimit>50000)
				{
					throw new InvalidCreditLimitException("Amount should be less than 50000");
				}
			}
			catch(InvalidCreditLimitException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
