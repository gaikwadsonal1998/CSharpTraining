using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment3_A
{
	 class Participants
	{
		//Participants objparticipant = new Participants();
		public int EmployeeID { get; set; }
		public string Name { get; set; }
		static string CompanyName;
		public double FoundationMarks { get; set; }
		public double WebBasicMarks { get; set; }
		public double DotNetMarks { get; set; }

		public double TotalMarks = 300;
		public double ObtainedMarks()
		{
			return FoundationMarks + WebBasicMarks + DotNetMarks;
		}
		public double Percentages()
		{
			double percent = ObtainedMarks() / TotalMarks;
			return percent * 100;
		}

		public Participants() { }
		public Participants(int employeeid,string name,double foundation,double webbase,double dotnet)
		{
			this.EmployeeID = employeeid;
			this.Name = name;
			this.FoundationMarks = foundation;
			this.WebBasicMarks = webbase;
			this.DotNetMarks = dotnet;
		}
		 static Participants()
		{
			CompanyName = "Corporate Unniversity";
		}
	}
}
