using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment10_1
{
	class Program
	{
		public delegate int delegateEx(int x,int y);
		static void Main(string[] args)
		{
			ArithmeticOperation ao = new ArithmeticOperation();
			Console.Write("Enter first Number : ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter second Number : ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the choice");
			Console.WriteLine("\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Max Number");
			int op= Convert.ToInt32(Console.ReadLine());
			switch(op)
			{
				case 1:
					delegateEx objsum = new delegateEx(ao.AddNumbers);
					Console.WriteLine(objsum(num1, num2));
					break;
				case 2:
					delegateEx objsub = new delegateEx(ao.Subtract);
					Console.WriteLine(objsub(num1, num2));
					break;
				case 3:
					delegateEx objmul = new delegateEx(ao.Multiplication);
					Console.WriteLine(objmul(num1, num2));
					break;
				case 4:
					delegateEx objdiv = new delegateEx(ao.Division);
					Console.WriteLine(objdiv(num1, num2));
					break;
				case 5:
					delegateEx objmax = new delegateEx(ao.Max);
					Console.WriteLine(objmax(num1, num2));
					break;
			}

		}
	}
}
