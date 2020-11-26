using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
	public delegate void myDelegate(int a,int b);
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();
			//myDelegate objdel = new myDelegate(p.Addition);

			myDelegate objdel = (int a, int b) => Console.WriteLine(a + b);
			 objdel += (int a, int b) => Console.WriteLine(a - b);


			//objdel += p.Subtract;
			objdel(10,20);
		}
		 void Addition(int a,int b)
		{
			Console.WriteLine(a + b);
		}
		 void Subtract(int a, int b)
		{
			Console.WriteLine(a - b);
		}
	}
}
