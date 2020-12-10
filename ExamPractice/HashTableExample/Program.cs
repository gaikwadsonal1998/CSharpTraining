using System;
using System.Collections;

namespace HashTableExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Hashtable ht = new Hashtable();
			ht.Add(101,"Sonal");
			ht.Add(102, "Snheal");
			ht.Add(103, "Mack");

			//Display the data
			ICollection key = ht.Keys;
			foreach(var item in key)
			{
				int roll = (int)item;
				Console.Write(roll);
				Console.WriteLine(ht[item]);
			}

			//Search data
			Console.WriteLine("Enter the key");
			int searchelement = Convert.ToInt32(Console.ReadLine());
			if(ht.ContainsKey(searchelement))
			{
				Console.WriteLine(ht[searchelement]);
			}
			Console.WriteLine("Before deletion : " + ht.Count);
			//Delete element
			object del = 102;
			ht.Remove(del);
			Console.WriteLine("After deletion : " + ht.Count);
			//display after deletion
			foreach(object obj in key)
			{
				Console.WriteLine(obj + ":" + ht[obj]);
			}
		}
	}
}
