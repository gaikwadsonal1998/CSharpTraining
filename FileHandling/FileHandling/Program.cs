using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
	class Program
	{
		public void WriteData()
		{
			string path = "D:\\C#\\Rama\\myFile.txt";
			FileStream fs1 = new FileStream(path, FileMode.Open, FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs1);
			
			string input = Console.ReadLine();
			sw.WriteLine(input);
			//fs.Close();
			//fs.Flush();


			sw.Flush();
			fs1.Close();

		}
		static void Main(string[] args)
		{
			Program objfileio = new Program();
			objfileio.WriteData();

			try
			{
				string path = "D:\\C#\\Rama\\myFile.txt";
				FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
				StreamReader sr = new StreamReader(fs);

				string data = null;
				while ((data = sr.ReadLine()) != null)
				{
					Console.WriteLine(data);
				}
				Console.ReadLine();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
