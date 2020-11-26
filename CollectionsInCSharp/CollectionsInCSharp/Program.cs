using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsInCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add("123");
			arrayList.Add("Sonal");
			arrayList.Add(1234.654);
			arrayList.Add('c');
			arrayList.Add("good");
			arrayList.Add("check");
			arrayList.Add('j');
			arrayList.Add('f');
			arrayList.Add('c');


			Console.WriteLine("Arraylist size is : {0}", arrayList.Capacity);
			Console.WriteLine("No.of elements : {0}", arrayList.Count);

			Console.WriteLine("ArrayList elements are : ");
			for (int i = 0; i < arrayList.Count; i++)
			{
				Console.Write(arrayList[i] + "\t");
			}

			//object Array
			Object[] arr = new object[15];

			//CopyTo(Array array) - Copy all elements from array list to the array and pasteit from index

			//arrayList.CopyTo(arr);
			//CopyTo(arr,3)

			arrayList.CopyTo(3, arr, 5, 4);
			Console.WriteLine("Array elements are :");
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
			Console.WriteLine("-------");
		}
	}
}
