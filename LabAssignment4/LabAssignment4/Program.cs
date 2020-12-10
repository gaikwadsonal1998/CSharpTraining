using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabAssignment1;

namespace LabAssignment4
{
	class Program
	{
		/*
		  Create a console application to use these classes. Create a Menu driven application to select the
Type of employee. Based on the user selection create the object and accept the details from the user.
Also display the salary of the Employee
		 */

		static void Main(string[] args)
		{
			
			Console.WriteLine("Choose type of employy");
			Console.WriteLine("\n 1. Contract-Type\n2. Permanent-Type");
			int op = Convert.ToInt32(Console.Read());

			try
			{
				if (op == 1)
				{
					ContractEmployee ce = new ContractEmployee();
					Console.WriteLine("Enter the Salary ");
					double sal = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Enter the Perks ");
					double perk = Convert.ToDouble(Console.ReadLine());
					ce.GetSalary(sal, perk);
				}
				else
				{
					PermanentEmployee pe = new PermanentEmployee();
					Console.WriteLine("Enter the Salary ");
					double sal = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Enter the PF ");
					double pf = Convert.ToDouble(Console.ReadLine());
					pe.GetSalary(sal, pf);

				}
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
			/*switch (op)
			{
				case 1:
					ContractEmployee ce = new ContractEmployee();
					Console.WriteLine("Enter the Salary ");
					double sal = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Enter the Perks ");
					double perk = Convert.ToDouble(Console.ReadLine());
					ce.GetSalary(sal,perk);
					break;

				case 2:
					PermanentEmployee pe = new PermanentEmployee();
					Console.WriteLine("Enter the Salary ");
					double sal1 = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Enter the PF ");
					double pf = Convert.ToDouble(Console.ReadLine());
					pe.GetSalary(sal1,pf);
					break;
			}*/
		}
	}
}