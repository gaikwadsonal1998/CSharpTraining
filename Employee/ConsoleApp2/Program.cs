using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{

			Employee emp = new Employee(1,"sonal",9999);
			Console.WriteLine("EmployeeID : {0}", emp.EmployeeID);
			Console.WriteLine("EmployeeName :{0}", emp.EmployeeName);
			Console.WriteLine("EmployeeID : {0}", emp.Salary);
			Console.ReadKey();
		}

	}
	}


