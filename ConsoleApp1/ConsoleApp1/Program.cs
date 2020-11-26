using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"D:\\FileTrial.txt";
			FileStream fs = new FileStream(path, FileMode.Open);
			fs.Close();
			Program.CountLines(path);
		}
		public static void CountLines(string path)
		{
			int count = 0;
			if(File.Exists(path))
			{
				using(StreamReader sr=File.OpenText(path))
				{
					string s = "";
					while((s=sr.ReadLine())!=null)
					{
						Console.WriteLine(s);
						count++;
					}
					Console.WriteLine();
				}
				Console.WriteLine($"no.of Lines{count}");
			}
		}
		public static void CountWords(string path)
		{

		}
	}
}
