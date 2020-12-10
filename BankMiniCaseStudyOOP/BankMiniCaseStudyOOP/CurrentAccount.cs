using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMiniCaseStudyOOP
{
	class CurrentAccount : BankAccount
	{
		private double ODlimit;
		private double AmountBorrowed;
		public string AccountType { get; set; }
		public CurrentAccount(string AccountType, string AccountHolderName, double Balance) :
		base(AccountHolderName, Balance)
		{
			this.AccountType = AccountType;
			this.ODlimit = 15000;
		}
		public override double Deposite(double Amount)
		{
			if (AmountBorrowed > 0)
			{
				if (AmountBorrowed < Amount)
				{
					base.Balance = Amount - AmountBorrowed;
					AmountBorrowed = 0;
				}
				else
				{
					AmountBorrowed = AmountBorrowed - Amount;
				}
			}
			else
			{
				base.Deposite(Amount);
			}
			return base.Balance;
		}

		public override double WithDraw(double Amount)
		{
			double temp = base.Balance - Amount;
			if (temp >= 0)
			{
				base.Balance = temp;
			}
			else if (temp < 0)
			{
				if ((-1) * temp < (ODlimit - AmountBorrowed))
				{
					base.Balance = 0;
					AmountBorrowed += (-1) * temp;
				}
			}
			return base.Balance;
		}
	}
}
