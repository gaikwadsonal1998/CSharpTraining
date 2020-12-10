using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment_2
{
	class Program
	{
		static void Main(string[] args)
		{
			StructSquareAndCube structObj = new StructSquareAndCube();
			Console.WriteLine("Enter your number : ");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter your choice : ");
			Console.WriteLine("\n1. Square\n2.Cube");
			int op = Convert.ToInt32(Console.ReadLine());

			switch (op)
			{
				case 1:
					structObj.squareOfNumber(num);
					break;
				case 2:
					structObj.CubeOfNumber(num);
					break;
			}
		}
	}
}
