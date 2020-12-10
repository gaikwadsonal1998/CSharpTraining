using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDemo2
{
	class Program
	{
		static void Main(string[] args)
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			Type t= assembly.GetType("ReflectionDemo2.Program");
			MethodInfo[] methods = t.GetMethods();
			foreach(var method in methods)
			{
				Console.WriteLine("===>Methods are :" + method.Name);
			}
			object ShapeClassObj=Activator.CreateInstance(t)
		}
		public string Add() { return "Hello Method"; }
		public void IntEx() { Console.WriteLine("IntEx method"); }
	}
}
