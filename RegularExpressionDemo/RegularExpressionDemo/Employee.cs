using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressionDemo
{
	class Employee
	{
		public int EmployeeID { get; set; }             //6 digit long
		public string EmployeeName { get; set; }        //start with capital alphabet and min 3, max 20
		public double Salary { get; set; }             //should be greater than 20000
		public DateTime DOB { get; set; }				// as per DOB age should be>=18
		public DateTime DOJ { get; set; }				//should be <= today
		public string Email { get; set; }				//10 digit
		public string Phone { get; set; }				//proper format
		public string City { get; set; }

		
		public bool Validate(string email)
		{
			string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]";

			bool isEmailValid = Regex.IsMatch(Email, emailPattern);
			return isEmailValid;
		}
	}
}
