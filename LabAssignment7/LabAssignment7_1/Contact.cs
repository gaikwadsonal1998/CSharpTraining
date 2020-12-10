using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment7_1
{
	class Contact
	{
		
		public int ContactNo { get; set; }
		public string ContactName { get; set; }
		public string CellNo { get; set; }
		List<Contact> clist = new List<Contact>();
		public Contact(int Contactno,string cnmae,string cell)
		{
			this.ContactNo = Contactno;
			this.ContactName = cnmae;
			this.CellNo = cell;
		}
		public Contact() { }
		public void AddContact()
		{
			Console.WriteLine("Enter Contact No :");
			ContactNo = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Contact Name:");
			ContactName = Console.ReadLine();

			Console.WriteLine("Enter Cell No :");
			CellNo = Console.ReadLine();

			Contact c = new Contact(ContactNo,ContactName,CellNo);
			clist.Add(c);
		}

		public void DisplayContact(string name)
		{
			foreach (Contact cont in clist)
			{
				if(cont.ContactName==name)
				{
					Console.WriteLine($"Contact name : {cont.ContactName}\t Contact number : {cont.ContactNo}\t Cell No : {cont.CellNo}");
				}
			}
		}
		public void EditContact(int contactID)
		{
			foreach (Contact c in clist)
			{
				if (contactID == c.ContactNo)
				{
					Console.Write("Enter New Name : ");
					string nm = Console.ReadLine();
					c.ContactName = nm;
					Console.Write("Enter New cell No. : ");
					string nwecell = Console.ReadLine();
					c.CellNo = nwecell;
					Console.WriteLine("Modification Sucessfull");
				}
			}
		}
		public void ShowAllContacts()
			{
				foreach(Contact contact in clist)
			{
				Console.WriteLine($"ContactNo : {contact.ContactNo}\tContact Name : {contact.ContactName}\tCell No. {contact.CellNo}");
			}
			}

	}
}
