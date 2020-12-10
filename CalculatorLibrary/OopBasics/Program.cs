using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopBasics
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Student student = new Student();
			student.setRollNumber(1);
			Console.WriteLine("RollNumber is  {0} ",student.GetRollNumber());

			student.setName("Sonal");
			Console.WriteLine("Name is : {0}",student.GetName());

			student.setDivision("A");
			Console.WriteLine("Division is : {0}",student.getDivision());
		}
	}
}
