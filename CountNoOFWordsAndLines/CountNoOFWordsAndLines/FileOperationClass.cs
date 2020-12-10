using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace CountNoOFWordsAndLines
{
	class FileOperationClass
	{
		string fileName = @"D:\CountOfWordAndLinesInAFile.txt";
		string filen = "CountOfWordAndLinesInAFile.txt";
		int count = 0;
		public void CountOfLines()
		{
			try
			{

				if (File.Exists(fileName))
				{
					using (StreamReader sr = File.OpenText(fileName))
					{
						string s = "";

						while ((s = sr.ReadLine()) != null)
						{
							Console.WriteLine(s);
							count++;
						}
						Console.WriteLine();
					}
					Console.WriteLine("The no.of Lines in {0} : {1}", filen, count);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public void CountOfWords()
		{
			//string inFileName = null;

			Console.WriteLine(fileName);
			//inFileName = Console.ReadLine();

			//StreamReader sr = new StreamReader(fileName);
			

				int counter = 0;
			string delim = " ,.\n";
			string[] fields = null;
			string line = null;
			using (StreamReader sr = File.OpenText(fileName))
			{
				/*while  (!sr.EndOfStream)
				{
					line = sr.ReadLine();
				}



				fields = line.Split(delim.ToCharArray());
				for (int i = 0; i < fields.Length; i++)
				{
					counter++;
				}*/
				while (!sr.EndOfStream)
				{
					line = sr.ReadLine();//each time you read a line you should split it into the words
					line.Trim();
					fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
					counter += fields.Length; //and just add how many of them there is
				}

				sr.Close();
				Console.WriteLine("The word count is {0}", counter);
			}
		}
		public void DownloadAFile(string address, string downloadfilename)
		{
			WebClient webclient = new WebClient();
			webclient.DownloadFile(address,downloadfilename);
		}

		public void AppendTexttOFile()
		{
			using (StreamWriter sw2 = File.AppendText(fileName))
			{
				Console.WriteLine("Enter the data which you want to append :");
				string newAppendData = Console.ReadLine();
				sw2.WriteLine(newAppendData);
			}
			using (StreamReader sr = File.OpenText(fileName))
			{
				string s = "";
				while ((s = sr.ReadLine()) != null)
				{
					Console.WriteLine(s);
				}
			}
		}
	}
}
	