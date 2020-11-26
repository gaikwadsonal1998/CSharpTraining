using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SupportingPrograms
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Program p = new Program();
			Console.WriteLine("Enter the path of file , you want to create: ");
			string filepath = Console.ReadLine();*/
			try
			{
				/*if(File.Exists(filepath))
				{
					Console.WriteLine("File already exist");
				}
				else
				{
					File.Create(filepath);
					Console.WriteLine("File created Successfully");
				}*/
				Console.WriteLine("Enter path of file : ");
				string filepath = Console.ReadLine();
				FileStream fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
				StreamWriter sw = new StreamWriter(fs);
				Console.WriteLine("Enter data which you wan to write in file");
				string data = Console.ReadLine();
				sw.WriteLine(data);
				sw.Flush();
				sw.Close();
				fs.Close();
			}
			catch(IOException ex)
			{
				Console.WriteLine(ex.Message);
			}
			//p.WriteData(filepath);
			
		}
		public void WriteData(string filepath)
		{
			FileStream fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs);
			Console.WriteLine("Enter data which you wan to write in file");
			string data = Console.ReadLine();
			sw.WriteLine(data);
			sw.Flush();
			sw.Close();
			fs.Close();
		}
	}
}
