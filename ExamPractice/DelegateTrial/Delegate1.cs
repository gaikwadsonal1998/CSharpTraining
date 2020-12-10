using System.Collections.Generic;
using System;
namespace DelegateTrial
{
	delegate bool IsEligibleforScholarship(Student s);
	class Student
	{
		public int Rollno;
		public string Name;
		public int Marks;
		public char SportsGrade;
		public string GetEligibleStudent(List<Student> student, IsEligibleforScholarship isEligiblefor)
		{
			string names = "";
			foreach(Student s in student)
			{
				if (isEligiblefor(s)==true)
				{
					names= names+s.Name +",";
				}
			}
			names = names.Remove(names.Length - 2, 2);
			return names;
		}
	}
	class Delegate1
	{
		public static bool ScholarshipEligibility(Student s)
		{
			if (s.Marks > 80 && s.SportsGrade == 'A')
			{
				return true;
			}
			else
				return false;
		}
		static void Main(string[] args)
		{
			List<Student> lststudents = new List<Student>();
			lststudents.Add(new Student { Rollno = 1, Name = "ram", Marks = 85, SportsGrade = 'A' });
			lststudents.Add(new Student { Rollno = 2, Name = "VIita", Marks = 75, SportsGrade = 'B' });
			lststudents.Add(new Student { Rollno = 3, Name = "Hello ", Marks = 89, SportsGrade = 'A' });
			lststudents.Add(new Student { Rollno = 4, Name = "Inita", Marks = 43, SportsGrade = 'C' });
			Student s = new Student();
			IsEligibleforScholarship ie = ScholarshipEligibility;
			ScholarshipEligibility(s);
			Console.WriteLine(s.GetEligibleStudent(lststudents, ie));
			Console.ReadLine();
		}
	}
}
