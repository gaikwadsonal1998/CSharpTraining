using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTrial
{
	delegate bool IsDiscountable(Product pr);
	class Product
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public double ProductPrice { get; set; }
		public int Quantity { get; set; }

		public static void Discount(List<Product> prlist, IsDiscountable isdiscountable) {
			foreach (Product product in prlist)
			{
				if (isdiscountable(product))
				{
					Console.WriteLine(" {0} is Eligible for 50 % Discount  ", product.ProductName);
				}
				
			}
		}
	}
}
