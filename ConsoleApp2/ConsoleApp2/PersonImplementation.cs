using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	
		class PersonImplementation
		{
		IList<Person> p = new List<Person>();
		     //public string
			 public void SetName()
		{
			p.Add(new Person { Name = "sonal", Address = "Chalisgaon", Age = 21 });
			p.Add(new Person { Name = "vishal", Address = "Jalgaon", Age = 20 });
		}
			public void GetName(IList<Person> person)
			{
				foreach (Person p in person)
				{
					Console.WriteLine( $"{p.Name}+{p.Address}");
				}
				
			}
			public double Average(IList<Person> person)
			{
				// foreach(Person p in person)
				// {

				// }
				double res = person.Average(x => x.Age);
				return res;
			}
			public double Max(IList<Person> person)
			{
				// foreach(Person p in person)
				// {

				// }
				double res = person.Max(x => x.Age);
				return res;
			}
		}
}
