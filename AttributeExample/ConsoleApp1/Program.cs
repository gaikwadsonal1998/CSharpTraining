using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeUsageTrial
{
	class Sample: Attribute
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public Sample(string name)
		{
			Name = name;
		}
	}
	[Sample("John",Age=30)]
	[Sample("ghitj", Age = 30)]
	
	class SampleTest
	{
		static void Main(string[] args)
		{
			Attribute[] attr = Attribute.GetCustomAttributes(typeof(sampleTest));
			Sample sample = (sample)attr[0];
			Console.WriteLine("{0}-{1}",sample.)
		}
	}
}
