using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LabAssignment8_1
{
	class Program
	{

		
		static void Main(string[] args)
		{
			//RTODistrict rt = new RTODistrict();
			Hashtable ht = new Hashtable();
			ICollection c = ht.Keys;
			bool ch = true;
			while (ch != false)
			{
				Console.WriteLine("choose option");
				Console.WriteLine("1.Add\n2.Search\n3.Display All Record\n4.Count\n5.Remove Record \n6.Exit");
				int op = Convert.ToInt32(Console.ReadLine());
				switch (op)
				{
					case 1:
					Console.WriteLine("Enter key");
					object key = Console.ReadLine();
					Console.WriteLine("enter city");
					object city = Console.ReadLine();
					ht.Add(key, city);
						Console.WriteLine("******Record added successfully*****");
						break;
					case 2:
						Console.WriteLine("Enter city");
						string citysearch = Console.ReadLine();
						
							if (ht.ContainsValue(citysearch))
							{
								Console.WriteLine("****Record is found****");
							Console.WriteLine($"{citysearch} : {ht[citysearch]}");
							}
							else
							{
								Console.WriteLine("Record not found");
							}
						
						
						break;
					case 3:
						//ICollection c = ht.Keys;
						Console.WriteLine("***********Record In Hashtable********");
						foreach (string item in c)
					{
							
						Console.Write(item+ " : "+ht[item] +"\n");
					}
						break;
					case 4:
						Console.WriteLine($"Count of hashtable : {ht.Count}");
						break;
					case 5:
						Console.WriteLine("Enter the RTOCode which you want to remove");
						string code = Console.ReadLine();
						ht.Remove(code);
						break;
					case 6:
						ch = false;
						break;

						
			}
			}
		}
		
	}
}
