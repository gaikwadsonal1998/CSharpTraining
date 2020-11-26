using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IteratorDemo2
{
	public class Calculations
	{
		public IEnumerable Power(int num1, int pow)
		
		{
			for (int i = 1; i <= pow; i++)
			{
				yield return Math.Pow(num1, i);
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Calculations cal = new Calculations();

			foreach (var item in cal.Power(2,5))
			{
				Console.WriteLine(item);
			}
		}
	}
}
