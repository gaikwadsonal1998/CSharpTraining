using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling02
{
	class ProductMock
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public double Price { get; set; }

		public ProductMock() { }
		public ProductMock(int id,string name,double price)
		{
			this.ProductID = id;
			this.ProductName = name;
			this.Price = price;
		}
	}
}
