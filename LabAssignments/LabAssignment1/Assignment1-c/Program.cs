using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_c
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Create a Console application to test usage of Switch case construct. Accept some integer from user
as command line argument and using a switch case construct, check if the value entered is 1, 2, 3, 4 or 5.
Print some message in each case.If the value is other than the above values, then print error message.*/
			Console.WriteLine("Enter any nnumber : ");
			int num = Convert.ToInt32(Console.ReadLine());

			switch (num)
			{
				case 1:
					Console.WriteLine("Enter number is one");
					break;

				case 2:
					Console.WriteLine("Enter number is Two");
					break;
				case 3:
					Console.WriteLine("Enter number is Three");
					break;
				case 4:
					Console.WriteLine("Enter number is Four");
					break;
				case 5:
					Console.WriteLine("Enter number is Five");
					break;
				default:
					Console.WriteLine("Error!!!!! please enter correct number");
					break;
			}
		}
	}
}
