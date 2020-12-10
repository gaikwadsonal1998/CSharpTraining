using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
	class Program
	{
		static void Main(string[] args)
		{
			Oops obj = new Oops();
			int a;
			int b = 20;
			Console.WriteLine(obj.Add(out a));
			Console.WriteLine(obj.Add(a));
			Console.WriteLine(obj.Add(a, b, "One Two"));

		}
		class Oops
		{
			public int Add(out int a)
			{
				a = 30;
				return a + 20;
			}
			public int Add(int a)
			{
				return a + 3;
			}
			public string Add(int a, int b, string name)
			{
				return a + b + name;
			}
		}
	}
}
