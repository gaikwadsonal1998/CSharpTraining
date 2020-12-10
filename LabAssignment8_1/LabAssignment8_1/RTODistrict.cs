using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LabAssignment8_1
{
	class RTODistrict
	{
		Hashtable ht = new Hashtable();

		
		public void AddRecord()
		{
			Console.WriteLine("Enter key");
			object key = Console.ReadLine();
			Console.WriteLine("enter city");
			object city = Console.ReadLine();
			ht.Add(key, city);
		}
	}
}
