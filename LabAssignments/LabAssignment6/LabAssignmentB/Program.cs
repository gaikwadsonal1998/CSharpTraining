using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LabAssignmentB
{
	class Program
	{
		static void Main(string[] args)
		{
			ProductMock productMock = new ProductMock();
			try
			{
				Console.WriteLine("Enter the ProductID : ");
				productMock.ProductID = Convert.ToInt32(Console.ReadLine());
				
				if (productMock.ProductID <= 0)
				{
					throw new DataEntryException("ProductID shoild be greater than zero");
				}
				
				Console.WriteLine("Enter the Product Name : ");
				productMock.ProductName = Console.ReadLine();

				
				if (productMock.ProductName == "")
				{
					throw new DataEntryException("ProductName cannot be blank");
				}
				else if (!Regex.IsMatch(productMock.ProductName, "[a-zA-Z0-9]$"))
				{
					throw new DataEntryException("Product Name should have alphabets and numbers only");
				}
				
				Console.WriteLine("Enter the product Price : ");
				productMock.Price = Convert.ToDouble(Console.ReadLine());
				
				if (productMock.Price <= 0)
				{
					throw new DataEntryException("Price of product must be greater than zero");
				}
				
				

			}

			
			catch (DataEntryException ex)
			{
				Console.WriteLine(ex.Message);
			}
	} }
}
