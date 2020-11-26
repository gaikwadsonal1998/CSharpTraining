using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemoMam
{
	class Program
	{
		static void Main(string[] args)
		{
			DaysOfTheWeek weeks = new DaysOfTheWeek();

			foreach (var item in weeks)
			{
				Console.WriteLine(item);
			}
		}
	}
}
