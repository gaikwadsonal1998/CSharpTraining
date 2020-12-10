using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Model
{
	class Employee
	{
		//id,name,location
		public int EmployeeId { get; set; }
		public string EmployeeName { get; set; }
		public string Location { get; set; }
		public double Salary { get; set; }
	}
}
