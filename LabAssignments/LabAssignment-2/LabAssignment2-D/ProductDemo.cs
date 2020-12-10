using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment2_D
{
	class ProductDemo
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter ProductID : ");
			int ProductID = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter product Name : ");
			string ProductName = Console.ReadLine();
			Console.WriteLine("Enetr Price :");
			double price = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter quantity : ");
			int Quantity = Convert.ToInt32(Console.ReadLine());

			Object objProductid = ProductID;
			Object objProductname = ProductName;
			Object objPrice = price;
			Object objQuantity = Quantity;

			Console.WriteLine("Product id : {0}", objProductid);
			Console.WriteLine("Product Name : {0}", objProductname);
			Console.WriteLine("Product Quantity : {0}", objQuantity);
			Console.WriteLine("Product Price : {0}", objPrice);

			Console.Write("Bill payable is :");
			Console.WriteLine(AmountPayable(Convert.ToDouble(objPrice), Convert.ToInt32(objQuantity)));

			
		}
		public static double AmountPayable(double price,int quantity)
		{
			double PayableAmount = price * quantity;
			return PayableAmount;
		}
	}
}
