using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabAssignment10_2;

namespace LabAssignment10_2
{

	class Program
	{
		static void Main(string[] args)
		{
			ArithmeticOperation aoObj = new ArithmeticOperation();
			bool op = true;
			while (op != false)
			{
				Console.WriteLine("Enter first number");
				int x= Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter second number");
				int y = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Max Number\n6.Exit");
				int ch = Convert.ToInt32(Console.ReadLine());
				//ArithmeticOperation aoObj = new ArithmeticOperation();
				switch (ch)
				{
					case 1:
						MyDelegate adddel = new MyDelegate(aoObj.addition);
						ArithmeticOperation.PerformArithmeticOperation(x, y, adddel);
						break;
					case 2:
						MyDelegate subdel = new MyDelegate(aoObj.Subtraction);
						ArithmeticOperation.PerformArithmeticOperation(x, y, subdel);
						break;
					case 3:
						MyDelegate muldel = new MyDelegate(aoObj.Multiplication);
						ArithmeticOperation.PerformArithmeticOperation(x, y, muldel);
						break;
					case 4:
						MyDelegate divdel = new MyDelegate(aoObj.Division);
						ArithmeticOperation.PerformArithmeticOperation(x, y, divdel);
						break;
					case 5:
						MyDelegate maxdel = new MyDelegate(aoObj.MaxNumber);
						ArithmeticOperation.PerformArithmeticOperation(x, y, maxdel);
						break;
					case 6:
						Environment.Exit(0);
						break;

				}
			}
		}
	}
}
