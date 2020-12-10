using LabAssignment4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabAssignment4
{
	 class Employee
	{
		public int EmployeeID { get; set; }
		public string EmployeeName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Department { get; set; }
		public double GetSalary { get; set; }
	}
}
class ContractEmployee : Employee
{
	public double perks { get; set; }
	public double salary { get; set; }
	 public new void GetSalary(double salary,double perks)
	{
		double sal= salary + perks;
		Console.WriteLine("Salary is : {0}", sal);
	}
	
}
class PermanentEmployee : Employee
{
	private int noOfleaves;
	public int NoOfLeaves { get; set; }
	private double providendFund;
	public double ProvidendFund { get; set; }
	public new void GetSalary(double salary,double providendFund)
	{
		double sal = salary - providendFund;
		Console.WriteLine("Salary is : {0}", sal);
	}
}
