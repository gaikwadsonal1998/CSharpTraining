using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supporting
{
	class Program
	{
		static void Main(string[] args)
		{
			Arithmetic ar = new Arithmetic();
			Console.WriteLine("Enter first Number : ");
			int x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second Number : ");
			int y = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("1.Addition\n2.Subtraction");
			int op= Convert.ToInt32(Console.ReadLine());
			switch(op)
			{
				case 1:
					MyDelegate deladd = ar.Addition;
					Arithmetic.PerformArithmeticOperation(x, y, deladd);
					break;
				case 2:
					MyDelegate delsub = ar.Addition;
					Arithmetic.PerformArithmeticOperation(x, y, delsub);
					break;

			}
		}
	}
}
