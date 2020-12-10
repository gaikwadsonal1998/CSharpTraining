using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LabAssignment8_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Hashtable ht = GetHashtable();
			Console.WriteLine("Count before "+ht.Count);
			ICollection c = ht.Keys;
			Console.WriteLine(ht.ContainsKey("Perimeter"));
			
			int val = (int)ht["Area"];
			Console.WriteLine(val);
			//string rem = "Mortage";
			Console.WriteLine("Count before removing a key: {0}", ht.Count);

			ht.Remove("Mortgage");

			Console.WriteLine("Count after removing a key: {0}", ht.Count);

			/*foreach (string c in ht)
			{

				if (ht.ContainsKey("Mortage"))
				{
					break;
				}
				else
				{
					i++;
				}
				
			}*/
		}
		static Hashtable GetHashtable()
		{
			// Create and return new Hashtable.
			Hashtable hashtable = new Hashtable();
			hashtable.Add("Area", 1000);
			hashtable.Add("Perimeter", 55);
			hashtable.Add("Mortgage", 540);
			return hashtable;
		}
	}
}
