using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment7_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Product pObj = new Product();
			//Product[] arr = new Product[20];
			bool chn = true;
			while (chn != false)
			{
				Console.WriteLine("Choose any option from the following");
				Console.WriteLine("\n1.Add Product\n2.Delete Product\n3.Search Product\n4.Save new Product\n5.Show All\n6.Exit");
				ArrayList arrl = new ArrayList();
				int op = Convert.ToInt32(Console.ReadLine());
				//pObj.SortArrayListItem();
				switch (op)
				{
					case 1:
						pObj.AddNewProduct();
						break;
					case 2:
						Console.Write("Enter Product No : ");
						int no = Convert.ToInt32(Console.ReadLine());
						pObj.DeleteProduct(no);
						break;
					case 3:
						Console.Write("Enter Product No : ");
						int nod = Convert.ToInt32(Console.ReadLine());
						pObj.SearchProduct(nod);
						break;
					case 4:
						pObj.SortProduct();
						break;
					case 5:
						pObj.ShowAll();
						break;
					case 6:
						chn = false;
						break;

				}

			}
		}
	}
}
