using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
	class Program


	{


		static void Main(string[] args)


		{


			Console.WriteLine($"Main Thread Started");





			Task<double> task1 = Task.Run(() =>


			{


				double sum = 0;


				for (int count = 1; count <= 10; count++)


				{


					sum += count;


				}


				return sum;


			});





			Console.WriteLine($"Sum is: {task1.Result}");


			Console.WriteLine($"Main Thread Completed");


			Console.ReadKey();


		}


	}
}
