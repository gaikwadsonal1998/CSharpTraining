using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTrial
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Product> listproduct = new List<Product>();
			listproduct.Add(new Product() { ProductID = 1, ProductName = "Soap", ProductPrice = 100, Quantity = 100 });
			listproduct.Add(new Product() { ProductID = 2, ProductName = "Shampoo", ProductPrice = 10, Quantity = 10 });
			listproduct.Add(new Product() { ProductID = 3, ProductName = "Conditioner", ProductPrice = 500, Quantity = 50 });
			listproduct.Add(new Product() { ProductID = 4, ProductName = "Detergent", ProductPrice = 256, Quantity = 5});

			IsDiscountable isDiscountable = new IsDiscountable(Discounted);
			Product.Discount(listproduct, isDiscountable);

		}

		public static bool Discounted(Product pr)
		{
			if (pr.Quantity >= 20 || pr.ProductPrice >= 100)
			{
				return true;
			}
			else
				return false;
		}
	}
}
