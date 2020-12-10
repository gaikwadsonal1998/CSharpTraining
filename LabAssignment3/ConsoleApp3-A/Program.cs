using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabAssignment3_A;

namespace ConsoleApp3_A
{
	class Program
	{
		static void Main(string[] args)
		{
			Participants parti = new Participants();
			int EmployeeId = Convert.ToInt32(Console.ReadLine());
			string Ename = Console.ReadLine();
			double foundmarks = Convert.ToDouble(Console.ReadLine());
			double webbase = Convert.ToDouble(Console.ReadLine());
			double dotnemark = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine();
			Console.WriteLine("Obtained Marks are : {0}",parti.ObtainedMarks());
			Console.WriteLine("Percentages : {0}",parti.Percentages());
		}
	}
}
