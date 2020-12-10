using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicgrosssalary
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter employee id: ");
			int id = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the name of employee : ");
			string name = Console.ReadLine();

			Console.WriteLine("Enter the salary : ");
			double bassal = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine();
			Console.WriteLine("Enter details are  ");
			Console.WriteLine("Employee id is : " + id);
			Console.WriteLine("Employee name is : " + name);
			Console.WriteLine("Employee basic salary is : " + bassal);


			Console.WriteLine();
			Console.WriteLine("20 % Allowance ");
			double grosssal = bassal + (0.20 * bassal);
			Console.WriteLine("Gross salary is : " + grosssal);

			Console.WriteLine();
			Console.WriteLine("2 % deductions ");
			double netsal = grosssal - (0.02 * bassal);
			Console.WriteLine("Net salary is : " + netsal);

		}
	}
}
