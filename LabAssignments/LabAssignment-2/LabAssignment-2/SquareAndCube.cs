using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment_2
{
	public struct StructSquareAndCube
	{
		public int Number { get; set; }

		public void squareOfNumber(int Num)
		{
			Console.WriteLine("Square of the number is : {0}", (Num * Num));
		}
		public void CubeOfNumber(int num)
		{
			Console.WriteLine("Cube of Number is : {0}", (num * num * num));
		}
	}
}
