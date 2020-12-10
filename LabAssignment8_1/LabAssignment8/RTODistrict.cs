using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LabAssignment8
{
	class RTODistrict
	{
		public string Key { get; set; }
		public string City { get; set; }
		Hashtable ht = new Hashtable();
		public void AddRecord(string key,string city)
		{
			
			
			ht.Add(key,city);
		}
		public void SearchRecord(string nm)
		{
			foreach (RTODistrict dist in ht)
			{
				if(dist.City==nm)
				{
					Console.WriteLine($"RTO Code :{dist.Key}\t City : {dist.City}");
				}
				else
				{
					Console.WriteLine("Enter Valid Passing No");
				}
			}
		}

		
	}
}
