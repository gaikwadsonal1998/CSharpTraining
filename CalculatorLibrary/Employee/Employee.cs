using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
	class Employee
	{
		public int EmployeeID { get; set; }
		public string Name { get; set; }
		public int DepartmentID { get; set; }
		public string Location { get; set; }

		public Employee() {
			//this.EmployeeID = 1;
			//this.Name = "Sonal";
			//this.DepartmentID = 101;
			//this.Location = "Maharashtra";
		}

		public Employee(int id, string name, int deptid, string location)
		{
			this.EmployeeID = id;
			this.Name = name;
			this.DepartmentID = deptid;
			this.Location = location;
		}

		public void show() {
			Console.WriteLine("EmployeeID : {0} - EmployeeName : {1} - DepartmentID {2} - Location {3}",
				this.EmployeeID, this.Name, this.DepartmentID,this.Location );
		}

		public void show(bool cond)
		{
			if(cond==true)
			Console.WriteLine("Name : {0} - Location : {1}", Name, Location);
		}

	}
}
