using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
	class Program
	{
		public static void Swap<T>(ref T lhs, ref T rhs)
		{
			T temp;
			temp = lhs;
			lhs = rhs;
			rhs = temp;
		}
		static void Main(string[] args)
		{
			MyClass<string> obj = new MyClass<string>(5);
			obj.Add(0,"Pune");
			obj.Add(1,"Jalgaon");
			obj.Add(2, "Maharashtra");
			obj.Add(3, "India");
			obj.Add(4, "Delhi");

			
			int a = 1;
			int b = 2;
			Console.WriteLine("Values Before swapping a = {0}  &  b = {1}", a, b);
			//we have to provide the datatype in following step while calling to the function.
			Swap<int>(ref a, ref b);
			Console.WriteLine("Values After swapping a = {0}  &  b = {1}", a, b);

		}
	}
}
