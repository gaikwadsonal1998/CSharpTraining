using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment2_B
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] arr = new int[5,6];
			Console.WriteLine("Enter Array elements : ");
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 6; j++)
				{
					arr[i,j]= Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.WriteLine("Enter elements are : ");
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 6; j++)
				{
					Console.Write(arr[i,j]+"\t");
				}
				Console.WriteLine("\n");
			}
			Console.ReadKey();
		}
		
	}
}
