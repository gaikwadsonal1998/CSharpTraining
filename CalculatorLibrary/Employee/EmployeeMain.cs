using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
	class EmployeeMain
	{
		static void Main(string[] args)
		{
			
			Employee emp = new Employee(1, "vishal", 202, "Maharashtra");
			emp.show();
			emp.show(false);
			Console.ReadKey();
            
		}
	}
}
