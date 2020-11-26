using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo2
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1, num2, result;
			string[] cities = new string[5];
			try
			{
				Console.Write("Enter number1 ");
				num1 = Convert.ToInt32(Console.ReadLine());

				Console.Write("Enter number2 ");
				num2 = Convert.ToInt32(Console.ReadLine());

				result = num1 / num2;

				cities[0] = "Pune";
				cities[1] = "Mumbai";
				cities[2] = "Bangalore";
				cities[3] = "Hyderabad";
				cities[4] = "Bangalore";
				cities[5] = "Chennai";
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (IndexOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (SystemException ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.WriteLine("Finally Executed");
			}
			Console.ReadKey();
		}
	}
}
