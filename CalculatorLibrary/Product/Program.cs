using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
	class Program
	{


		public int ProductID { get; set; }
		private string ProductName { get; set; }
		private int Quantity { get; set; }
		private double Price { get; set; }

		public static void Bill(int Quantity, Double Price)
		{
			double res =  Quantity * Price;
			Console.WriteLine("Bill IS : "+res);
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Enter the ProductID");
			int pid = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the ProductName");
			string pname = Console.ReadLine();

			Console.WriteLine("Enter the Product Quantity");
			int quantity = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the Product Price");
			double price  = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter details are : ");
			Console.WriteLine("Product id is {0}", pid);
			Console.WriteLine("Product Name is {0}", pname);
			Console.WriteLine("Quantity is {0}", quantity);
			Console.WriteLine("Price is {0}", price);
			Console.WriteLine();
			Bill(quantity,price);


		}
	}
}


