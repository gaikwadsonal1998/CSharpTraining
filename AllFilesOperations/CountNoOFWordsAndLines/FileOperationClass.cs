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
		string fileName = "";
		string filen = "CountOfWordAndLinesInAFile.txt";
		int count = 0;

		public void CreateFile(string filepath)
		{
			try
			{
				if (File.Exists(filepath))
				{
					Console.WriteLine("File already exist");
				}
				else
				{
					File.Create(filepath);
					Console.WriteLine("File created Successfully");
				}
			}
			catch (IOException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		public void WriteDataToFile(string filepathn)
		{
			FileStream fs2 = new FileStream(filepathn, FileMode.Append, FileAccess.Write);
			StreamWriter sw2 = new StreamWriter(fs2);
			string data = "";
			Console.WriteLine("Enter data : ");
			data = Console.ReadLine();
			sw2.WriteLine(data);
			sw2.Flush();
			sw2.Close();
			fs2.Close();
		}
		public void CountOfLines()
		{
			try
			{
				//check whether file is available or not
				Console.Write("Enter path of file to count Lines :");
				fileName = Console.ReadLine();
				if (File.Exists(fileName))
				{   // create an object of streamreader class and assign a file to it
					using (StreamReader sr = File.OpenText(fileName))
					{
						string s = "";

						while ((s = sr.ReadLine()) != null)//execute till the end 
						{
							Console.WriteLine(s);
							count++;
						}
						Console.WriteLine();
					}
					Console.WriteLine("The no.of Lines in {0} : {1}", fileName, count);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public void CountOfWords()
		{
			Console.Write("Enter path of file to count Lines :");
			fileName = Console.ReadLine();
			//Console.WriteLine(fileName);
			
			int counter = 0;
			string delim = " ,.\n";
			string[] fields = null;
			string line = null;
			using (StreamReader sr = File.OpenText(fileName))
			{
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
		public void CopyFiles(string SourceFile,string DestFile)
		{
			File.Copy(SourceFile, DestFile);
		}
		public void DeleteFile()
		{
			File.Delete(fileName);
		}
	}
}
	