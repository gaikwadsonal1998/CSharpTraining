using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMiniCaseStudyOOP
{
	class SavingsAccount : BankAccount
	{
		public string AccountType { get; set; }
		public SavingsAccount(string AccountType, string AccountHolderName, double Balance) : base(AccountHolderName, Balance)
		{

		}
		public override double WithDraw(double Amount)
		{
			if (Amount > 0) {
				base.Balance = base.Balance - Amount;
				return base.Balance;
			
		
		}
			//Console.WriteLine("Balance after withdrawal of {0} is {1}", Amount, base.WithDraw(Amount));
			else
				return -1;
		}
		public override double Deposite(double Amount)
		{
			base.Balance = base.Balance + Amount;
			return base.Balance;
			//Console.WriteLine("Balance after deposit of {0} is {1}", Amount, base.Deposite(Amount));
		}
	}
}