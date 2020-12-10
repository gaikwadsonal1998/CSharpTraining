using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabAssignment12_A
{
	class Program
	{
		/*
		 Q1. Write a Code to Read and Display the contents of a text file. 
		Accept the name of the file from the user.
		Handle all the exceptions that might occur during reading.
		 */
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the path of file");
			string filepath = Console.ReadLine();
			Console.WriteLine("**************The contents of file : *******************");
			try
			{
				if (File.Exists(filepath))
				{
					using(StreamReader sr= File.OpenText(filepath))
					{
						string s = "";
						while((s=sr.ReadLine())!=null)
						{
							Console.WriteLine(s);
						}
					}
				}
			}
			catch(IOException ex)
			{
				Console.Write(ex.Message);
			}
		}
	}
}
