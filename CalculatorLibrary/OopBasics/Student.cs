using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopBasics
{
	class Student
	{
		private int RollNumber;
		private string Name;
		private string Division;

		public int GetRollNumber()
		{
			return RollNumber;
		}

		public void setRollNumber(int RollNumber)
		{
			this.RollNumber = RollNumber;
		}

		public string GetName() { return Name; }
		public void setName(string name) { this.Name = name; }

		public string getDivision() { return Division; }
		public void setDivision(string division) {
			this.Division = division;
		}
	}
}
