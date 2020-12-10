using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment9_1
{
	class Program
	{
		static void Main(string[] args)
		{
			IDictionary<string, string> dictObj = new Dictionary<string, string>();

			//Adding elements to dictionary
			dictObj.Add("India", "NewDelhi");
			dictObj.Add("Maharashtra", "Mumbai");
			dictObj.Add("Russia", "Moscow");

			//Duplicate key entering
			//dictObj.Add("Maharashtra", "Mumbai");

			//The indexer can be used to change the value associated with a key. Try changing the value of any
			//record and display the updated value.
			//var capitals = new Dictionary<string, string>();
			//capitals["Russia"] = "china";
			if(dictObj.ContainsKey)

			foreach(var kvp in dictObj)
			{
				Console.WriteLine($"{kvp.Key}-{kvp.Value}");
			}

		}

	}
}
