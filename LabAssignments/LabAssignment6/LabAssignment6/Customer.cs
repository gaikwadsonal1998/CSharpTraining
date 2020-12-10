using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment6
{
	class Customer
	{
		public int CustomerID { get; set; }
		public string CustomerName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Phone { get; set; }
		public int CreditLimit { get; set; }

		public Customer(){ }

		public Customer(int Custid,string custname,string address, string city,string phone,int creditlimit) {
			this.CustomerID = Custid;
			this.CustomerName = custname;
			this.Address = address;
			this.City = city;
			this.Phone = phone;
			this.CreditLimit = creditlimit;
		}
	}
}
