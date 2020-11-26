using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
	class Program
	{
		static void Main(string[] args)
		{
			MyClass.message("in main");
			function1();
			Console.ReadKey();
		}
	}
	class MyClass
	{
		[Conditional("DEBUG")]
		public static void message(string msg)
		{
			Console.WriteLine(msg);
		}
	}
	class Test
	{
		static void function1()
		{
			MyClass.message("In function 1");
			function2();
		}
		
		static void function2()
		{
			MyClass.message("In function 2");
		}
	}
}
