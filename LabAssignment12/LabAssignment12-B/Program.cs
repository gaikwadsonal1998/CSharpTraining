using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment12_B
{
	class Program
	{
		/*
	 Q2. Write a Code to perform File Copy operation. You need to accept the source and destination file names. 
	The data should be copied from source file to destination file.
	Handle all the exceptions that might occur during the file copy operation.
		 */
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the path of source file :");
			string sourcefile = Console.ReadLine();
			Console.WriteLine("Enter the path of destination file :");
			string destfile = Console.ReadLine();
			try
			{
				if(File.Exists(sourcefile))
				{
					
					File.Copy(sourcefile, destfile);
					
				}
			}
			catch (IOException ex)
			{

				Console.WriteLine(ex.Message);
			}
		}
	}
}
