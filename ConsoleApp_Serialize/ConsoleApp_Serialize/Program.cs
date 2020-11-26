using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Serialize
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee objemp = new Employee();
			//Employee objemp2 = new Employee();
			objemp.SerializeAddEmployee();
			//objemp2.Deserialize();
			Console.ReadLine();
		}
	}
}
