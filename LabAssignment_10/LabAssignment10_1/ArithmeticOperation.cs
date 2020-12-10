using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment10_1
{
	/*You need to perform Arithmetic operations on two numbers. The operations include Add Numbers,
Multiply Numbers, Divide Numbers, Subtract Numbers and Find Max Number. */
	class ArithmeticOperation
	{
		
		public int AddNumbers(int a,int b)
		{
			int add = a + b;
			//Console.WriteLine($"Addition is : {add}");
			return add;
		}
		public int Subtract(int a,int b)
		{
			int sub = a - b;
			return sub;
		}
		public int Multiplication(int a, int b)
		{
			int sub = a * b;
			return sub;
		}
		public int Division(int a, int b)
		{
			int sub = a / b;
			return sub;
		}
		public int Max(int a, int b)
		{
			if (a > b)
			{
				return a;
			}
			else
				return b;
		}
	}
}
