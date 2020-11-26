using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo2
{
	delegate bool IsPromotable(Employee empl);
	class Employee
	{
	
		public int ID { get; set; }
		public string Name { get; set; }
		public double Salary { get; set; }
		public int Experience { get; set; }

		public static void PromotEmployee(List<Employee> emp, IsPromotable EligibleToPromot)
		{
			foreach (Employee employee in emp)
			{
				if (EligibleToPromot(employee))
				{
					Console.WriteLine("Employee {0} Promoted", employee.Name);
				}

			}
		}
	}
}

