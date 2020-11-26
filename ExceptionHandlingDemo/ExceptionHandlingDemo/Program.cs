using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
	class MyException : ApplicationException
	{
		public MyException(string str) : base(str)
		{ Console.WriteLine("User defined exception"); }
	}

	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				throw new MyException("Some error has happened");
}
			catch (MyException e)
			{
				Console.WriteLine("Exception caught here" + e.ToString());
			}
			Console.WriteLine("LAST STATEMENT");
		}
	}
}
