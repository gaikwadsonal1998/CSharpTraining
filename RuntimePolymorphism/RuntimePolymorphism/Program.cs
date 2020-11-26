using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RuntimePolymorphism;

namespace RuntimePolymorphism
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee emp = new Employee();
			emp.Show();
			emp.Display();
			Manager mg = new Manager();
			mg.Show();

			Employee emgr = new Manager();
			emgr.Show();
			emgr.Display();

			emp.ExtensionMethod();

		}
	}
}
