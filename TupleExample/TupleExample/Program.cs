using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //This represents a tuple of size 3 (Create a new 3-tuple, or Triple) with all string type  
            var tuple = Tuple.Create<string, string, string>("EDUDOTNET", "IT", "SOLUTION");
            Console.WriteLine(tuple);
            //This represents a tuple of size 2 (Create a new 2-tuple, or Pair) with int & string type  
            var tuple1 = Tuple.Create<int, string>(51, "CTO-EDUDOTNET");
            Console.WriteLine(tuple1);



            //We can also access values of Tuple using ItemN property. Where N point to a particular item in the tuple.  
            //This represents a tuple of size 4 (Create a new 4-tuple, or quadruple) with 3 string & 1 int type  
            var tuple2 = Tuple.Create<int, string, string, string>(1, "Khumesh", "EDUDOTNET", "IT-Solution");
            Console.WriteLine(tuple2.Item1);
            Console.WriteLine(tuple2.Item2);
            Console.WriteLine(tuple2.Item3);
            Console.WriteLine(tuple2.Item4);
            Console.WriteLine("Enjoying With Tuple.......... :)");
            Console.ReadLine();
        }
    }
}
