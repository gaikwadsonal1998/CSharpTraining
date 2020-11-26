using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDirectory
{
	class Program
	{
		static void Main(string[] args)
		{
			Directory cd = new Directory();
			cd.createddirectory();
			cd.GetSubDirectories();
			cd.GetFilesinaDirectory();
			Console.ReadLine();
		}
	}
}
