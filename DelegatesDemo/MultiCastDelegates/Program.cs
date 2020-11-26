using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegates
{
	delegate void SampleDelegate();
	class Program
	{
		static void Main(string[] args)
		{
			SampleDelegate delone, deltwo, delthree, delfour;
			delone = new SampleDelegate(SampleOneMethod);
			deltwo = new SampleDelegate(SampleTwoMethod);
			delthree = new SampleDelegate(SampleThreMethod);
			delfour = delone + deltwo + delthree;
			delfour();
			
		}

		public static void SampleOneMethod()
		{
			Console.WriteLine("SampleOneMethod");
		}
		public static void SampleTwoMethod()
		{
			Console.WriteLine("SampleTwoeMethod");
		}
		public static void SampleThreMethod()
		{
			Console.WriteLine("SampleThreeMethod");
		}
	}
}
