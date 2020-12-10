using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractice
{
	class Program
	{/*
	  Add(out int a) : retrun int res
			return type: int
			visibility: public
		Add(int a) : retrun int res
			return type: int
			visibility: public
		Add(int a, int b , string name) : retrun string res
			return type: string
			visibility: public

	  */
		public int Add(out int a)
		{
			   a = 30;
			return a + 20;
		}
		public int Add(int a)
		{
			return a + 3;
		}
		public string Add(int a,int b, string name)
		{
			return a + b + name;
		}
		static void Main(string[] args)
		{
			Program p = new Program();
			int a = 30;
			int b = 20;
			Console.WriteLine(p.Add(out a));
			Console.WriteLine(p.Add(a));
			Console.WriteLine(p.Add(a, b, "One Two"));



		}
	}
}
