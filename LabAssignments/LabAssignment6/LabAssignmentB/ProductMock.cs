﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentB
{
	class ProductMock
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public double Price { get; set; }

		public ProductMock() { }
		public ProductMock(int prodid, string prodname, double price)
		{
			this.ProductID = prodid;
			this.ProductName = prodname;
			this.Price = price;
		}
	}
}
