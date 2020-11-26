using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Employee
	{
		
			private int id;
		private string name;
		private double sal;

		public int EmployeeID
		{
			get { return id; }
			set { id = value; }
		}

		public string EmployeeName
		{
			get { return name; }
			set { name = value; }
		}

		public double Salary
		{
			get { return sal; }
			set { sal = value; }
		}

		static Employee()
		{
			Console.WriteLine("Employee static constructor");
		}
		public Employee()
		{
			Console.WriteLine("Default constructor");
			id = 1;
			name = "abc";
			sal = 999;

		}

		public Employee(int id,string name,double sal)
		{
			Console.WriteLine("parametarized");
			this.id = id;
			this.name = name;
			this.sal = sal;

		}
	}
}
