using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CLSComplaintAttribute
{
	[assembly:CLSComplaint(true)]
	public class GFG { public uint z; }
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Helloworld");
		}
	}
}
