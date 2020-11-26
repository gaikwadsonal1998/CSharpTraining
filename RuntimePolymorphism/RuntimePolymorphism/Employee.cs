using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimePolymorphism
{
	class Employee
	{
		public void Show() {
			Console.WriteLine("Employee(Parent) show method");
		}

		public virtual void Display() {
			Console.WriteLine("Employee(paremt) Display ()");
		}
	}
}
