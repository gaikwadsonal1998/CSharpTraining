using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSupportingConcepts
{
	class Student
	{
		static int count = 0;
		public int RollNumber { get; set; }
		public string Name { get; set; }

		public Student() {
			this.RollNumber = count+1;
			this.Name = "New Name";
			count = count + 1;
		}

		public void show() {
			Console.WriteLine("RollNumber - {0} & Name {1} ", RollNumber, Name);
		}

		public static void Display()
		{
			Console.WriteLine("Student Management System");
		}
	}
}
