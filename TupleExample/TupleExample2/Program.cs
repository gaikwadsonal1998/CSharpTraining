using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExample2
{
	class Program
	{
		static void Main(string[] args)
		{
			var person = Tuple.Create(1, "sonal", "jobs");
			DisplayTuple(person);
		}
		static void DisplayTuple(Tuple<int,string,string>person)
		{
			Console.WriteLine($"ID={person.Item1}");
			Console.WriteLine($"FirstName={person.Item2}");
			Console.WriteLine($"LastName={person.Item3}");
		}
	}
}
