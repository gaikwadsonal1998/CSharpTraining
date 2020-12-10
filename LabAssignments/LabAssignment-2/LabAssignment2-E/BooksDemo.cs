using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment2_E
{
	class BooksDemo
	{
		
		

		static void Main(string[] args)
		{
			string[,] book = new string[2, 4];
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					book[i, j] = Console.ReadLine();
				}
			}
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					Console.Write(book[i, j]+"\t");
				}
				Console.WriteLine("\n");
			}
			/*foreach (string item in book)
			{
				Console.Write(item+"\t");
			}*/
		}
	}
}
