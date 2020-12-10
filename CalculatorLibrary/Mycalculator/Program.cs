using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace Mycalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("sum is : {0} ",Calculator.Add(20,50));
			Console.WriteLine("subtraction is : {0} ", Calculator.Subtract(20, 50));
			Console.WriteLine("multiplication is : {0} ", Calculator.Multiply(20, 50));
			Console.WriteLine("division is : {0} ", Calculator.Divide(100, 50));
		}
	}
}
