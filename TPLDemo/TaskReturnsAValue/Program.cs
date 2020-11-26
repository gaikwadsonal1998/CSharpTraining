using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskReturnsAValue
{
    class Program
    {

        // to return value sfrom tas
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread Started");
            Task<double> task1 = Task.Run(() =>
            {
                return CalculateSum(10);
            });



            Console.WriteLine($"Sum is: {task1.Result}");
            Console.WriteLine($"Main Thread Completed");
            Console.ReadKey();
        }
        static double CalculateSum(int num)
        {
            double sum = 0;
            for (int count = 1; count <= num; count++)
            {
                sum += count;
            }
            return sum;


        }
    }
}