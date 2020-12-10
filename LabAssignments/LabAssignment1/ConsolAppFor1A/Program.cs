using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabAssignment1;

namespace ConsolAppFor1A
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee emp = new Employee();
			Employee[] arr = new Employee[2];
			
			for(int i = 0; i < arr.Length; i++) 
			{
				Console.Write("Enter the EmployeeID : ");
				emp.EmployeeID = Convert.ToInt32(Console.ReadLine());

				Console.Write("Enter Employee Name : ");
				emp.EmployeeName = Console.ReadLine();

				Console.Write("Enter Address : ");
				emp.Address = Console.ReadLine();

				Console.Write("Enter City : ");
				emp.City = Console.ReadLine();

				Console.Write("Enter Department : ");
				emp.Department = Console.ReadLine();

				Console.Write("Enter Salary : ");
				emp.Salary = Convert.ToDouble(Console.ReadLine());
			}

			Console.WriteLine("******** Enter Details Are : ***********");

			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine("EmployeeID is : {0}", emp.EmployeeID);
				Console.WriteLine("Employee Name is : {0}", emp.EmployeeName);
				Console.WriteLine("Employee Address is : {0}", emp.Address);
				Console.WriteLine("Employee City is : {0}", emp.City);
				Console.WriteLine("Employee Department is : {0}", emp.Department);
				Console.WriteLine("Employee Salary is : {0}", emp.Salary);

			}

			
		}
	}
}
