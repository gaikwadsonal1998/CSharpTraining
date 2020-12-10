using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountNoOFWordsAndLines
{
	class Program
	{
		static void Main(string[] args)
		{
			FileOperationClass objfoc = new FileOperationClass();
			Console.WriteLine("Choose the option\n1.CountLines\n2.Count Words\n3.Download File\n4.AppendTextTo Data");
			int op = Convert.ToInt32(Console.ReadLine());
			switch (op)
			{
				case 1:
				objfoc.CountOfLines();
					break;
				case 2:
				objfoc.CountOfWords();
					break;
				case 3:
					Console.WriteLine("Enter address of the file");
					string address = Console.ReadLine();
					Console.WriteLine("Enter name of the file");
					string downloadfilename = Console.ReadLine();
					break;
				case 4:
					objfoc.AppendTexttOFile();
					break;

			}
			
			
		}
	}
}
