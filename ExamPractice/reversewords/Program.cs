using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversewords
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = Console.ReadLine();
			string[] word=str.Split(' ');
			int temp = str.Length-1;
			
				for(int i=temp;temp>=0;i--)
				{
				Console.WriteLine(word[temp] + "" + ' ');
				--temp;
				}
			Console.ReadKey();
			
		}
	}
}
