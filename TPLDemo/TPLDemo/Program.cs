
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Data Parallellism

namespace TPLDemo
{
	class Program
	{
		public void PrintNum()
		{
			Parallel.For(0, 100, i => { Console.WriteLine(i); });
			
			/*int[] arr = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

			Parallel.ForEach(arr, num => Console.WriteLine(num));*/
		}
		static void Main(string[] args)
		{
			Program p = new Program();
			p.PrintNum();
			Console.ReadLine();
		}
	}
}
