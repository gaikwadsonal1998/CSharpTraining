using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LabAssignment8
{
	class Program
	{
		static void Main(string[] args)
		{
			RTODistrict rto = new RTODistrict();
			bool ch = true;
			//while(ch!=false)
			{
				
				Console.WriteLine("Choose any of the following");
				Console.WriteLine("\n1.Add New Record\n2.Search ");
				int op = Convert.ToInt32(Console.Read());
				switch(op)
				{
					case 1:
						Console.WriteLine("Enter RTO Code : ");
						string key = Console.ReadLine();
						Console.WriteLine("Enter city Name");
						string city = Console.ReadLine();
						//RTODistrict rt = new RTODistrict();
					
						rto.AddRecord(key,city);
						break;
					case 2:
						Console.WriteLine("Enter city Name :");
						string nm = Console.ReadLine();
						rto.SearchRecord(nm);
						break;
				}
			}
		}
	}
}
