using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo
{
	public class Program
	{
		 public int add(int a,int b)
		{
			int c= a + b;
			return c;
		}
		public int Sub(int a, int b)
		{
			int c = a - b;
			return c;
		}
		static void Main(string[] args)
		{
			Program p = new Program();
			int res=p.add(10,20);
			int ressub = p.Sub(20, 10);
			Console.WriteLine(res);
			Console.ReadLine();
		}
	}
}
