using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
	class ReflectionDemo
	{
		public int Addition(Type t1, int a1, int b1)
		{
			object m = Activator.CreateInstance(t1, false);
			MethodInfo mi = t1.GetMethod("Add");
			return (int)mi.Invoke(m, new object[] { a1, b1 });
		}
		public int Subtraction(Type t1, int a, int b)
		{
			object m = Activator.CreateInstance(t1, false);
			MethodInfo mi = t1.GetMethod("Subtract");
			return (int)mi.Invoke(m, new object[] { a, b });
		}
		public int Multiplication(Type t1, int a, int b)
		{
			object m = Activator.CreateInstance(t1, false);
			MethodInfo mi = t1.GetMethod("Multiply");
			return (int)mi.Invoke(m, new object[] { a, b });
		}
		static void Main(string[] args)
		{
			
		}
	}
}
