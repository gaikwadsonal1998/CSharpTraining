using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlling
{
	/*
	Define a Customer class with following members
	CustomerId, Customer Name, Address, City, Phone, CreditLimit
	 */
	class Customer
	{
		public int CustomerId { get; set; }
		public string CustomerName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Phone { get; set; }
		public int CreditLimit { get; set; }

		public Customer() { }
		public Customer(int id,string name,string address,string city,string phone,int credit)
		{
			this.CustomerId = id;
			this.CustomerName = name;
			this.Address = address;
			this.City = city;
			this.Phone = phone;
			this.CreditLimit = credit;
		}
	}
}
