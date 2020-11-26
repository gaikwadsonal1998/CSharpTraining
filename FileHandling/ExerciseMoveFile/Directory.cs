using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExerciseMoveFile
{
	class directory_ex
	{
		DirectoryInfo dir = new DirectoryInfo(@"F://NewDirectory");

		
		public void Movefiles()
		{
			string source = "F:\\NewDirectory\\myFile.txt";
			string dest = "F:\\NewDirectory\\Exercise\\myFile.txt";
			Directory.Move(source, dest);
				Console.WriteLine("file move from {0} to {1}", source, dest);
		}
	}
}
