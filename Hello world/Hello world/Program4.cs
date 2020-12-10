using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world
{
	class Program4
	{
		static void Main(string[] args)
		{
			int[] Scores = new int[] { 10,30,50,22,60};
			for (int S = 0; S < Scores.Length; S++)
			{
				Console.WriteLine(Scores[S]);
			}
			foreach (int item in Scores)
			{
				Console.WriteLine(item);
			}
		}
	}
}
