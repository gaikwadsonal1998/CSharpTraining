using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TakUsingWaitMethod
{
	/*
	 Task using Wait:

As we already discussed, the tasks will run asynchronously on the thread pool thread and the thread will start the task execution asynchronously along with the main thread of the application.

, the child thread will continue its execution until it finishes its task even after the completion of the main thread execution of the application.

If you want to make the main thread execution wait until all child tasks are completed, then you need to use the Wait method of the Task class. The Wait method of Task class will block the execution of other threads until the assigned task has completed its execution.
	 */
	class Program


	{


		static void Main(string[] args)


		{


			Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Statred");


			Task task1 = Task.Run(() =>


			{


				PrintCounter();


			});


			task1.Wait();


			Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");


			Console.ReadKey();


		}





		static void PrintCounter()


		{


			Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Started");


			for (int count = 1; count <= 5; count++)


			{


				Console.WriteLine($"count value: {count}");


			}


			Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Completed");


		}
	}
}
