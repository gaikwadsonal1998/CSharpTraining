using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary7_3;

namespace LabAssignment7_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee emp = new Employee();
			bool ch = true;
			while(ch!=false)
			{
				Console.WriteLine("Choose any of the following");
				Console.WriteLine("\n1.Add new Employee\n2.Search Employee\n3.Delete Record\n4.View All");
				int op = Convert.ToInt32(Console.ReadLine());

				switch(op)
				{
					case 1:
						emp.AddEmployee();
						break;
					case 2:
						Console.WriteLine("Enter employee no to be search :");
						int no = Convert.ToInt32(Console.ReadLine());
						emp.SearchEmployee(no);
						break;
					case 3:
						Console.WriteLine("Enter employee no to be delete :");
						int nod = Convert.ToInt32(Console.ReadLine());
						emp.DeleteEmployee(nod);
						break;
					case 4:
						emp.ViewAllEmployee();
						break;
					case 5:
						ch = false;
						break;
				}
			}
		}
	}
}
