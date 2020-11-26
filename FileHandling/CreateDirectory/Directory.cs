using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateDirectory
{
	
	class Directory
	{
		DirectoryInfo dir = new DirectoryInfo(@"F:\\NewDirectory");
		public void GetSubDirectories()
		{
			DirectoryInfo[] directoryList = dir.GetDirectories();

			if (directoryList.Length > 0)
			{
				foreach (DirectoryInfo item in directoryList)
				{
					Console.WriteLine("Name of subdirectory"+item.Name.ToString());
					Console.WriteLine("Last-Access-time "+item.LastAccessTime);
					Console.WriteLine("Created "+item.CreationTime.ToLongDateString());
					
					//item.CreationTime=
				}
			}
		}

		public void GetFilesinaDirectory()
		{
			FileInfo[] finf = dir.GetFiles();
			if (finf.Length > 0)
			{
				foreach (FileInfo item in finf)
				{
					
					Console.WriteLine("====================================");
					Console.WriteLine(item.FullName);
					Console.WriteLine("Size of the file " + item.Length);
					Console.WriteLine("Created on : " + item.CreationTime);
					Console.WriteLine("Extensio of file : " + item.Extension);
					Console.WriteLine("Directory Name : " + item.DirectoryName);
					Console.WriteLine("====================================");
				}
			}
		}
		public void createddirectory() {
			try
			{
				if (dir.Exists)
				{
					
					Console.WriteLine("Directory already exist");
					return;
				}
				else
				{ 
					dir.Create();
					Console.WriteLine("Directory created successfully");
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
