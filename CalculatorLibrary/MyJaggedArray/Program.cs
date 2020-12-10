using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJaggedArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] myjaggedarr = new int[3][];
			myjaggedarr[0] =new int[] { 2, 3, 4, 5};
			myjaggedarr[1] =new int[] { 6,7};
			myjaggedarr[2] =new int[] {8};


			for (int i = 0; i < myjaggedarr.Length; i++)
			{
				foreach(int j in myjaggedarr[i])
				{
					Console.Write(j + "\t");
				}
				Console.WriteLine();
			}

		}

	}
}
