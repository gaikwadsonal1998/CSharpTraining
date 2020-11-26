using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstraintDemo
{
	public class MyClass<T> where T : IComparable
	{ }

	public class Employee { }

	public struct Student { }
	class Program
	{
		static void Main(string[] args)
		{
			MyClass<int> intObj = new MyClass<int>();
			MyClass<double> doubleObj = new MyClass<double>();
			MyClass<bool> boolObj = new MyClass<bool>();
			//MyClass<Student> studObj = new MyClass<Student>();
			MyClass<string> stringObj = new MyClass<string>();
			//MyClass<Employee> empObj = new MyClass<Employee>();

		}
	}
}
