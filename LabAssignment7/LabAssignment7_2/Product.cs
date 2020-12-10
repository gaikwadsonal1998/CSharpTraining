using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment7_2
{
	class Product
	{
		// ProductNo, Name, Rate and Stock
		int i = 0;
		public int ProductNo { get; set; }
		public string ProductName { get; set; }
		public double Price { get; set; }
		public int Stock{ get; set; }
		ArrayList arrListObj = new ArrayList();

		public Product() { }
		public Product(int pno,string pname,double price,int stock)
		{
			this.ProductNo = pno;
			this.ProductName = pname;
			this.Price = price;
			this.Stock = stock;
		}
		public void AddNewProduct()
		{
			Console.WriteLine("Enter product No.");
			int no = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter product Name.");
			string nm = Console.ReadLine();

			Console.WriteLine("Enter product Price.");
			double pric = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter product Stock.");
			int stok = Convert.ToInt32(Console.ReadLine());
			Product p = new Product(no, nm, pric, stok);

			arrListObj.Add(p);
		}

		public void SortArrayListItem()
		{
			arrListObj.Sort();
			
			
		}

		public void DeleteProduct(int pno)
		{
			foreach (Product item in arrListObj)
			{
				if(pno==item.ProductNo)
				{
					break;
				}
				else
				{ 
					i++;
				}

			
			}
			arrListObj.RemoveAt(i);
			//arrListObj.Remove(i);
			Console.WriteLine("Item Removed Successfully");
		}
		public void SearchProduct(int pno)
		{
			foreach (Product item in arrListObj)
			{
				if(item.ProductNo==pno)
				{
					Console.WriteLine($"Product no : {item.ProductNo}\tProduct Name :{item.ProductName}\tProduct Price{item.Price}\t Product Stock : {item.Stock}");

				}
				else
				{
					Console.WriteLine("Product is not found in the List");
				}
			}
		}
		public void ShowAll()
		{
			foreach (Product item in arrListObj)
			{
				
				Console.WriteLine($"Product no :{item.ProductNo}\tProduct Name: {item.ProductName}\tPrice : {item.Price}\tStoc : {item.Stock}");
			}
		}
		public void SortProduct()
		{
			foreach (Product p in arrListObj)
			{
				arrListObj.Sort();
				Console.WriteLine("Sorted succefully");
			}
		}
	}
}
