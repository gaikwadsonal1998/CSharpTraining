using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
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
					Class1.Addition(num1, num2);
					break;
				case 2:
					Class1.Subtraction(num1, num2);
					break;
				case 3:
					Class1.Multiplication(num1, num2);
					break;
				case 4:
					Class1.Division(num1, num2);
					break;
				case 5:
					Class1.Modulus(num1, num2);
					break;

			}
		}
	}
}
