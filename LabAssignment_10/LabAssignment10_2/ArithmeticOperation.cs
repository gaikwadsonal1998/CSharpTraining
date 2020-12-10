using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment10_2
{
	public delegate void MyDelegate(int a, int b);
	class ArithmeticOperation
	{
		
		public void addition(int a,int b)
		{
			Console.WriteLine($"Addition is :{a + b}");
		}
		public void Subtraction(int a, int b)
		{
			Console.WriteLine($"subtraction is :{a - b}");
		}
		public void Multiplication(int a, int b)
		{
			Console.WriteLine($"Multiplocation is :{a * b}");
		}
		public void Division(int a, int b)
		{
			Console.WriteLine($"Division is :{a / b}");
		}
		public void MaxNumber(int a, int b)
		{
			if (a > b)
			{
				Console.WriteLine("Max no is :" + a);
			}
			else
				Console.WriteLine("Max no is :" + b);
		}
		public static void PerformArithmeticOperation(int num1, int num2, MyDelegate arOperation)
		{
			arOperation(num1, num2);
		}

	}
}
