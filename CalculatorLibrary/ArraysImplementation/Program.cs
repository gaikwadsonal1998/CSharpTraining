using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysImplementation
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the numbers : ");
			int[,] my2DArray = new int[2, 3];
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					my2DArray[i, j] = int.Parse(Console.ReadLine());
				}
			}

			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write(my2DArray[i,j]+"\t");
				}
				Console.WriteLine();
			}

		}
	}
}
