using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningAnObject
{
	class Program
	{
		static void Main(string[] args)


		{


			Console.WriteLine($"Main Thread Started");


			Task<Employee> task = Task<Employee>.Factory.StartNew(() =>


			{


				Employee employee = new Employee()


				{


					ID = 101,


					Name = "Pranaya",


					Salary = 10000


				};





				return employee;


			});


			Employee emp = task.Result;





			Console.WriteLine($"ID: {emp.ID}, Name : {emp.Name}, Salary : {emp.Salary}");


			Console.WriteLine($"Main Thread Completed");


			Console.ReadKey();


		}


	}





	public class Employee


	{


		public int ID { get; set; }


		public string Name { get; set; }


		public double Salary { get; set; }


	}
}
