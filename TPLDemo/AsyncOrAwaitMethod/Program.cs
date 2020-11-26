using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncOrAwaitMethod
{
	class Program
	{
		/*
		 We will get all the benefits of traditional Asynchronous programming with much less effort
		by the help of async and await keywords.
		Suppose, we are using two methods as Method1 and Method2 respectively 
		and both the methods are not dependent on each other and Method1 
		is taking a long time to complete its task. In Synchronous programming, 
		it will execute the first Method1 and it will wait for completion of this method 
		and then it will execute Method2. 
		Thus, it will be a time intensive process even though both the methods 
		are not depending on each other.
We can run all the methods parallelly by using the simple thread programming but it 
		will block UI and wait to complete all the tasks. To come out of this problem, 
		we have to write too many codes in traditional programming but if we will simply use
		the async and await keywords, then we will get the solutions in much less code.
	Also, we are going to see more examples, if any third Method as Method3 has a dependency of method1,
		then it will wait for the completion of Method1 with the help of await keyword.
Async and await in C# are the code markers, which marks code positions from where 
		the control should resume after a task completes.
		 */
		static void Main(string[] args)
		{
			Method1();
			Method2();
			Console.ReadKey();
		}



		public static async Task Method1()
		{
			await Task.Run(() =>
			{
				for (int i = 0; i < 100; i++)
				{
					Console.WriteLine(" Method 1");
				}
			});
		}
		public static void Method2()
		{
			for (int i = 0; i < 25; i++)
			{
				Console.WriteLine(" Method 2");
			}
		}
	}
}
