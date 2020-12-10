using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world
{
	class Program3
	{
		static int Add(int num1, int num2) {
			int res = num1 + num2;
			return res;
		}

		static int Sub(int num1, int num2)
		{
			int res = num1 - num2;
			return res;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter number1");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter number2");
			int num2 = int.Parse(Console.ReadLine());
			int Addi= Add(num1,num2);
			//Console.WriteLine(Print);
			int Subt = Sub(num1, num2);
			Console.WriteLine("Addition is :" + Add(num1, num2));
			Console.WriteLine("Subtraction is :" + Sub(num1, num2));
			Console.WriteLine("Addition is :{0} And Subtraction is {1}", Addi,Subt);
		}
	}
}
