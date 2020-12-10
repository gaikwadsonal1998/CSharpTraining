using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate bool IsELigibleforScholarship(Student std);
    public class Student
    {
        public int Rollno;
        public string Name;
        public int Marks;
        public char SportsGrade;
        public string name;
        public string GetEligibleStudent(List<Student> student, IsELigibleforScholarship isEligiblefor)
        {
            string names = "";
            foreach (Student std in student)
            {
                if (isEligiblefor(std) == true)
                {
                    names = names + std.Name + ", ";
                }
            }
            names = names.Remove(names.Length - 2, 2);
            return names;
        }
    }


    class delegate1
    {
        public static bool ScholarshipEligibility(Student std)
        {
            if (std.Marks > 80 && std.SportsGrade == 'A')
            { return true; }
            else
            { return false; }

        }
        static void Main(string[] args)
        {
            List<Student> lststudents = new List<Student>();
            lststudents.Add(new Student { Rollno = 1, Name = "ram", Marks = 85, SportsGrade = 'A' });
            lststudents.Add(new Student { Rollno = 2, Name = "site", Marks = 75, SportsGrade = 'B' });
            lststudents.Add(new Student { Rollno = 3, Name = "hello", Marks = 89, SportsGrade = 'A' });
            lststudents.Add(new Student { Rollno = 4, Name = "bye", Marks = 43, SportsGrade = 'C' });
            Student s = new Student();
            IsELigibleforScholarship ie = ScholarshipEligibility;
            ScholarshipEligibility(s);
            Console.WriteLine(s.GetEligibleStudent(lststudents, ie));
            Console.ReadKey();

        }

    }

}
