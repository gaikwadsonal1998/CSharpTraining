using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelism
{
	class Program
	{
		static void Main(string[] args)
		{
			Task t = new Task(() => Console.WriteLine("Hello from task A"));
			t.Start();
			Console.WriteLine("Hello from the calling thread");
		}
	}
}
