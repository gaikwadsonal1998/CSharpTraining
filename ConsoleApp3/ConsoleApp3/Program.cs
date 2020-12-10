using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 1, 2, 3, 4, 5 };
			int? num = numbers?[0];
			Console.WriteLine(num);
			/*string fname = "ajal";
			string lname = "gaik";
			WriteLine("{fname}-{lname}")*/
			;
		}
	}
}
