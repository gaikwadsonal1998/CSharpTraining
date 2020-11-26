using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationDemo
{
	enum days { sun,mon=5,tue,wed,thu,fri,sat};
	class Program
	{
		static void Main(string[] args)
		{
			int wednesday = (int)days.wed;
			string day = days[2];
			Console.WriteLine(wednesday);
		}
	}
}
