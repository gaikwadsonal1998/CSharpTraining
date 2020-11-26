using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RenameFileDirectoryAndExtension
{
	class Program
	{
		static void Main(string[] args)
		{
			 
			Console.WriteLine("Enter the path of file : ");
			string oldpath = Console.ReadLine();
			FileInfo file = new FileInfo(oldpath);
			Console.Write("Enter the new Name to the file :");
			string newname = Console.ReadLine();
			//RenameFileclassExample.RenameFileOrDirectory(file,newname);
			file.RenameFileOrDirectory(newname);


		}
	}
}
