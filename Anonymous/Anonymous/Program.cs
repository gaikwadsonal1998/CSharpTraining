using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
	class Program
	{
		static void Main(string[] args)
		{
			var person1 = new { Name = "Robert", City = "Mumbai", Age = 33 };
			Console.WriteLine("person 1 imfo :");
			Console.WriteLine("Name is {0} : ", person1.Name);
			Console.WriteLine("City is {0} : ", person1.City);
			Console.WriteLine("Age is {0} : ", person1.Age);

			var person2 = new { Name = "John", City = "Pune", Age = 43 };
			Console.WriteLine("person 2 imfo :");
			Console.WriteLine("Name is {0} : ", person1.Name);
			Console.WriteLine("City is {0} : ", person1.City);
			Console.WriteLine("Age is {0} : ", person1.Age);

			var person3 = new { City = "Bangalore", Name = "Maria",  Age = 35.7 };
			Console.WriteLine("person 3 imfo :");
			Console.WriteLine("Name is {0} : ", person1.Name);
			Console.WriteLine("City is {0} : ", person1.City);
			Console.WriteLine("Age is {0} : ", person1.Age);

			var person4 = new { Name = "Rossy", City = "Hyderabad", Age = 35.7 };
			Console.WriteLine("person 4 info :");
			Console.WriteLine("Name is {0} : ", person4.Name);
			Console.WriteLine("City is {0} : ", person4.City);
			Console.WriteLine("Age is {0} : ", person4.Age);

		}
	}
}
