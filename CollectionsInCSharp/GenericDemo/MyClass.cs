using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
	class MyClass<T>
	{
		T[] arr;
		public MyClass(int size)
		{
			arr = new T[size];
		}

		public void Add(int index, T value)
		{
			arr[index] = value;
		}

		public void reverse()
		{
			for (int  i= arr.Length-1; i >=0; i--)
			{
				Console.WriteLine(arr[i]);
			}
		}

		
	}
}
