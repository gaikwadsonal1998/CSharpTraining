using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimePolymorphism
{
	class Manager : Employee
	{
		public new void Show()
		{
			Console.WriteLine("Manager(child) Show method");
		}
		public override void Display()
		{
			Console.WriteLine("Manager(child) Display ()");
		}

	}
}
