using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMiniCaseStudyOOP
{
	interface IAccount
	{
		double WithDraw(double Amount);
		double Deposite(double Amount);
	}
}
