using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritance
{
	class Employee
	{
		public int EmployeeID { get; set; }
		public string EmployeeName { get; set; }
		public double Salary { get; set; }

		public Employee() {
			Console.WriteLine("Default Parent ");

		}
		public Employee(int id, string name, double salary) {
			Console.WriteLine("Parent parametarized");

		}

		

	}

}
