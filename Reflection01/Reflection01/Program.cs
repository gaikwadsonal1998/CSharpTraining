using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection01
{
	class Program
	{
		static void Main(string[] args)
		{
			Assembly assembly = Assembly.LoadFile(@"C:\Windows\Microsoft.NET\Framework\v2.0.50727\System.Drawing.dll");

			foreach (Type t in assembly.GetTypes())
			{
				Console.WriteLine(t.Name);

			}
		}
	}
}
