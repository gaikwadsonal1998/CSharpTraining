using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Manager m1 = new Manager();

			Manager m2 = new Manager(101,"Robert",1000);
			


			Console.ReadKey();
		}
	}
}
