using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment7_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Contact cObj = new Contact();
			Contact[] arr = new Contact[20];
			bool chn = true;
			while (chn != false)
			{
				Console.WriteLine("Choose any option from the following");
			Console.WriteLine("\n1.Add Contact\n2.Display Contact\n3.Edit Contact\n4.Display All Contact\n5.Exit");
			int op = Convert.ToInt32(Console.ReadLine());
			
				switch (op)
				{
					case 1:
						cObj.AddContact();
						break;
					case 2:
						Console.Write("Enter Name : ");
						string name = Console.ReadLine();
						cObj.DisplayContact(name);
						break;
					case 3:
						Console.WriteLine("Enter ContactNO which you want to modify :");
						int no = Convert.ToInt32(Console.ReadLine());
						cObj.EditContact(no);
						break;

					case 4:
						cObj.ShowAllContacts();
						break;
					case 5:
						chn = false;
						break;

					
				}
			}
			
		}
	}
}
