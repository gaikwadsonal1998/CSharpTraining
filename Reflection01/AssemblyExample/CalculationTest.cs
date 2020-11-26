using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyExample
{
	class Calculation
	{
		private int firstNumber;
		public int FirstNumber
		{
			get { return FirstNumber; }
			set
			{
				firstNumber = value;
			}
		}

		protected int SecondNumber
		{
			get { return SecondNumber; }
			set { SecondNumber = value; }
		}

		private static int AddTwoNumbers(int firstNumber, int secondNumber)
		{
			return firstNumber + secondNumber;
		}
	}
	class CalculationTest
	{
		static void Main(string[] args)
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			Type t = assembly.GetType("AssemblyExample.Calculation");
			MethodInfo methodInfo = t.GetMethod("AddTwoNumbers", BindingFlags.NonPublic | BindingFlags.Static);
			int result = (int)methodInfo.Invoke(null, new object[] { 22, 3 });
			Console.WriteLine(result);
		}
	}
}
