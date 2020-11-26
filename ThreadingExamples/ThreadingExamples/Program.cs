using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingExamples
{
	class Program
	{
		public void printNumbers()
		{
			lock(this)
			for (int i = 0; i < 10; i++)
			{
					Console.Write("Thread started :");
					Console.WriteLine(i);
					
			}
			
		}
		static void Main(string[] args)
		{
			Program p = new Program();
			ThreadStart t = new ThreadStart(p.printNumbers);
			Thread th = new Thread(t);
			th.Start();
			Thread.Sleep(10000);
			Console.WriteLine();
			ThreadStart t1 = new ThreadStart(p.printNumbers);
			Thread th1 = new Thread(t1);
			th1.Abort();
			th1.Start();
			
			Console.ReadLine();

		}
	}
}
