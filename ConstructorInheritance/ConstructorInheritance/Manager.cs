using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritance
{
	class Manager:Employee
	{
		public int Incentives { get; set; }

		public Manager():base() {
			Console.WriteLine("Manager Default");
		}

		public Manager(int id, string name, double salary)
		{
			Console.WriteLine("Manager Parametarized");
		}
	}
}
