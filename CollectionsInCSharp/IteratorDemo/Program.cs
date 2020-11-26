using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
	
	class Program
	{
		public static IEnumerable<string> GetArray()
		{
			int[] arr = new int[] { 1, 2, 3, 4, 5 };

			foreach (var element in arr)
			{
				yield return element.ToString();
			}
		}
		static void Main(string[] args)
		{
			IEnumerable<string> element = GetArray();
			foreach (var elements in element)
			{
				Console.WriteLine(elements);
			}
		}
	}
}
