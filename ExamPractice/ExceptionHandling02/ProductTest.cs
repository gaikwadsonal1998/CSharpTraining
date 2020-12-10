using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling02
{
	class ProductTest
	{
		
		public void GetProductDetails()
		{
			Console.WriteLine("Enter product id : ");
			int id = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter product name : ");
			string name = Console.ReadLine();
			Console.WriteLine("Enter product price : ");
			double price = Convert.ToDouble(Console.ReadLine());
			ProductMock p = new ProductMock(id, name, price);
		}
		public void DisplayDetailsProduct()
		{
			ProductMock pm = new ProductMock();
			Console.WriteLine(pm.ProductID);
			Console.WriteLine(pm.ProductName);
			Console.WriteLine(pm.Price);
		}
		static void Main(string[] args)
		{
			ProductTest test = new ProductTest();
			test.GetProductDetails();
			test.DisplayDetailsProduct();

		}
	}
}
