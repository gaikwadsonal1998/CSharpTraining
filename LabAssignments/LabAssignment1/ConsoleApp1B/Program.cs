using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraryfor1_B;

namespace ConsoleApp1B
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter first number");
			double num1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter first number");
			double num2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Choose any of the following Operation");
			Console.WriteLine("1. Addition\n 2. Subtraction\n 3. Multiplication\n 4. Division \n 5. Modulus");
			int op = Convert.ToInt32(Console.ReadLine());
			switch (op)
			{
				case 1:
					ArithmeticLibrary.Addition(num1, num2);
					break;
				case 2:
					ArithmeticLibrary.Subtraction(num1, num2);
					break;
				case 3:
					ArithmeticLibrary.Multiplication(num1, num2);
					break;
				case 4:
					ArithmeticLibrary.Division(num1, num2);
					break;
				case 5:
					ArithmeticLibrary.Modulus(num1, num2);
					break;

			}
		}
	}
}
