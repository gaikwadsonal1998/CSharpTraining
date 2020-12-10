using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSupportingConcepts
{
	abstract class Employee
	{
		public int EmployeeID { get; set; }
		public string EmployeeName { get; set; }
		public int Salary { get; set; }

		public void show() {
			Console.WriteLine(EmployeeID + "\t" + EmployeeName + "\t" + Salary);
		}

		public Employee() {
			this.EmployeeID = 1;
			this.EmployeeName = "sonal";
			this.Salary = 20000;
		}
		//public abstract void show();
	}
}
