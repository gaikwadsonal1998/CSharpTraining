using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParallelInvoke
{
    public class Program
    {
        static void Main()
        {
            Parallel.Invoke(
                 NormalAction, // Invoking Normal Method
                 delegate ()   // Invoking an inline delegate
                 {
                     Console.WriteLine($"Method 2, Thread={Thread.CurrentThread.ManagedThreadId}");
                 },
                () =>   // Invoking a lambda expression
                {
                    Console.WriteLine($"Method 3, Thread={Thread.CurrentThread.ManagedThreadId}");
                }
            );
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
        static void NormalAction()
        {
            Console.WriteLine($"Method 1, Thread={Thread.CurrentThread.ManagedThreadId}");
        }
    }
}

/*
 The Parallel Invoke method is used to execute a set of operations (actions) in parallel.
As you can see in the above output three threads are created to execute 
three actions which prove that this parallel Invoke Method executes the actions in parallel.
 T he Task class will always represent a single operation and that operation will be executed 
asynchronously on a thread pool thread rather than synchronously on the main thread of the application. 
If this is not clear at the moment then don’t worry we will discuss this in practice
 */