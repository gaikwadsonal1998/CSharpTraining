using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee emp = new Employee();
			
			Console.Write("Enter EmployeeID : ");
			emp.EmployeeID = Convert.ToInt32(Console.ReadLine());

			if (emp.EmployeeID < 100000 || emp.EmployeeID > 999999)
			{
				Console.WriteLine("EmployeeID should be 6 digit long");
			}

			Console.Write("Enter EmployeeName : ");
			emp.EmployeeName = Console.ReadLine();

			if (!Regex.IsMatch(emp.EmployeeName, "[A-Z][a-z]{2,19}"))
				Console.WriteLine("Employee Name should start with capital Alphabet snd should have minimum 3 and maximum 20 alphabets");


			Console.Write("Enter Salary : ");
			emp.Salary = Convert.ToDouble(Console.ReadLine());
			if (emp.Salary < 20000)
				Console.WriteLine("Salary should be greater than 20,000");

           Console.Write("Enter Date Of Birth : ");
			emp.DOB = Convert.ToDateTime(Console.ReadLine());
			int age = DateTime.Today.Year - emp.DOB.Year;

			if (age < 18)
				Console.WriteLine("Age should be greater than 18");


			Console.Write("Enter Date Of Joining : ");
			emp.DOJ = Convert.ToDateTime(Console.ReadLine());
			if (emp.DOJ > DateTime.Today)
				Console.WriteLine("Date of joining should be less than or equal to today's date");


			Console.Write("Enter Phone number : ");
			emp.Phone = Console.ReadLine();
			if (!Regex.IsMatch(emp.Phone, "[6-9][0-9]{9}"))
				Console.WriteLine("Phone number should start with 6 or 7 or 8 or 9 and should be 10 digits");

			Console.Write("Enter Email-id : ");
			emp.Email = Console.ReadLine();
			if (!Regex.IsMatch(emp.Email, @"[a-z0-9_\-\.]+[@][[a-z0-9]+[\.][a-z]+"))
				Console.WriteLine("Email should be in proper format");

			Console.Write("Enter City : ");
			emp.City = Console.ReadLine();
			if (!Regex.IsMatch(emp.City, "Pune|Mumbai|Bangalore|Hyderabad|Chennai"))
				Console.WriteLine("City should be Pune|Mumbai|Bangalore|Hyderabad|Chennai");

			Console.ReadLine();


		}
	}
}
