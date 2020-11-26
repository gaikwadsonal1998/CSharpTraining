using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Employee> employeeList = new List<Employee>();
			employeeList.Add(new Employee() { ID = 101, Name = "Sonal", Salary = 40000, Experience = 6 });
			employeeList.Add(new Employee() { ID = 101, Name = "Vishal", Salary = 50000, Experience = 7});
			employeeList.Add(new Employee() { ID = 101, Name = "Praju", Salary = 30000, Experience = 3 });
			employeeList.Add(new Employee() { ID = 101, Name = "Snehal", Salary = 10000, Experience = 1 });

			IsPromotable promot = new IsPromotable(Promote);
			Employee.PromotEmployee(employeeList,promot);
		}

		static bool Promote(Employee emp) {
			if (emp.Experience >= 5)
			{
				return true;
			}
			else
				return false;
		}
	}
}
