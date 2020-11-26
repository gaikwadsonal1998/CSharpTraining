using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Hashtable ht = new Hashtable();
			ht.Add(1, "Sonal");
			ht.Add(2, "Mumbai");
			ht.Add(3, "Pune");
			ht.Add(4, "Hyderabad");
			ht.Add(5, "Chennai");
			ht.Add(6, "Bangalore");
			ht.Add(7, "Delhi");
			ht.Add(8, null);
			ht.Add(9, "Delhi");

			Console.WriteLine("Hashtable elements are : ");

			foreach (var item in ht.Keys)
			{
				Console.Write("Keys {0} : ", item);
				Console.WriteLine("\t Values :{0} ", ht[item]);
			}
		}
	}
}
