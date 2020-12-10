using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supporting
{
	delegate void MyDelegate(int x, int y);
	class Arithmetic
	{
		public void Addition(int x,int y)
		{
			Console.WriteLine("Addition is {0}", x + y);

		}
		public void Subtraction(int x,int y)
		{
			Console.WriteLine("Subtraction is : {0}", x - y);
		}
		public static void PerformArithmeticOperation(int num1, int num2, MyDelegate arOperation)
		{
			arOperation(num1, num2);
		}
	}
}
