using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp_outwithcSharp7._0
{
	class Program
	{
		public void add(int i, int j, out int k) => k = i + j;
		static void Main(string[] args)
		{
			
			int i=2,j =12;
			int m;
			Program p = new Program();
			p.add(i, j, out m);
			Console.WriteLine(m);
			Read();
		}

		
	}
}
