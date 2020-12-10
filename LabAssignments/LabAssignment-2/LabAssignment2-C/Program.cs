using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment2_C
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the no.of cities you want to enter : ");
			int NoOfCity = Convert.ToInt32(Console.ReadLine());
			string[] city = new string[NoOfCity];
			for (int i = 0; i < city.Length; i++)
			{
				city[i] = Console.ReadLine();
			}
			Console.WriteLine("Entered cities are: ");
			foreach (string item in city)
			{

				Console.WriteLine(item);
			}
			{

			}
			
		}
	}
}
