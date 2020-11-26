using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimePolymorphism
{
	static class ExtensionClass
	{
		public static void ExtensionMethod(this Employee e) {
			Console.WriteLine("ExtensionMethod");
		} 
	}
}
