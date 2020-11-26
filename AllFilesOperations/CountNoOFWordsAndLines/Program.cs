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

			string repeat = "";
			
			while ((repeat)!="n")
			{
				Console.WriteLine("Choose the option\n1.Create File\n2.Write On File\n3.CountLines\n4.Count Words\n5.Download File\n6.AppendTextTo Data\n7.Copy Files\n8.Delete");
				int op = Convert.ToInt32(Console.ReadLine());
				switch (op)
				{
					case 1:
						Console.WriteLine("Enter the path of file , you want to create: ");
						string filepath = Console.ReadLine();
						objfoc.CreateFile(filepath);
						break;
					case 2:
						Console.WriteLine("Enter the path of file , you want to write on :");
						string filepathn = Console.ReadLine();
						objfoc.WriteDataToFile(filepathn);
						break;
					case 3:
						objfoc.CountOfLines();
						break;
					case 4:
						objfoc.CountOfWords();
						break;
					case 5:
						Console.WriteLine("Enter address of the file");
						string address = Console.ReadLine();
						Console.WriteLine("Enter name of the file");
						string downloadfilename = Console.ReadLine();
						break;
					case 6:
						objfoc.AppendTexttOFile();
						break;
					case 7:
						Console.WriteLine("Enter path of source file");
						string sourceFile = Console.ReadLine();
						Console.WriteLine("Enter path of Destination file");
						string destFile = Console.ReadLine();
						objfoc.CopyFiles(sourceFile, destFile);
						break;
					case 8:
						objfoc.DeleteFile();
						break;

				}
				Console.WriteLine("Want to continue: y/n");
				repeat = Console.ReadLine();
			}
		}
	}
}
