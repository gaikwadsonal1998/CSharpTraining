using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary7_3
{
    public class Employee
    {
        int i = 0;
        /*
         Create a private DLL with a class Called Employee. Employee class will have Employee Number, Name
         and Basic Salary, and PF attributes. Define appropriate properties to access the attributes. Write 2 constructors,
        one default & one parameterized, to assign the values of the attributes when the object is created.
         */
        public int EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public double BasicSalary { get; set; }
        public double PF { get; set; }

        List<Employee> empList = new List<Employee>();
        public Employee() { }

        public Employee(int empno, string ename, double basicsal, double pf) {
            this.EmployeeNo = empno;
            this.EmployeeName = ename;
            this.BasicSalary = basicsal;
            this.PF = pf;
        }
        public void AddEmployee()
		{
            Console.WriteLine("Enter employee No. :");
            int no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee Name :");
            string nm = Console.ReadLine();

            Console.WriteLine("Enter basic salary :");
            double bs = Convert.ToDouble(Console.ReadLine());


            double pf = bs * 12 / 100;

            Employee emp = new Employee(no, nm, bs, pf);
            empList.Add(emp);
        }

        //Adding new Employee’s of specified type, Searching
       // Records, Delete Records and View all records operations.
       public void SearchEmployee(int empno)
		{
			foreach (Employee emp in empList)
			{
                if(emp.EmployeeNo==empno)
				{
                    Console.WriteLine($"Employee No. {emp.EmployeeNo}\tEmployee Name : {emp.EmployeeName}\tEmployee Salary {emp.BasicSalary}\tEmployee PF : {emp.PF}");

				}
			}
		}

        public void DeleteEmployee(int empno)
		{
			foreach (Employee item in empList)
			{
                if(item.EmployeeNo==empno)
				{
                    break;
				}
                else
				{
                    i++;
				}
			}
            empList.RemoveAt(i);
            Console.WriteLine(" Employee Removed Successfully");
		}
        public void ViewAllEmployee()
		{
			foreach (Employee item in empList)
			{
                Console.WriteLine($"Employee No. {item.EmployeeNo}\t Employee Name : {item.EmployeeName}\t Employee Basic salary : {item.BasicSalary}\t Employees PF : {item.PF}");
			}
		}
        public void SortEmployee()
		{
			foreach (Employee emp in empList)
			{
                empList.Sort();
			}
		}
    }
}
