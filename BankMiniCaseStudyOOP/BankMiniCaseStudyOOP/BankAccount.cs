using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMiniCaseStudyOOP
{
	abstract class BankAccount:IAccount
	{
		static int count = 0;
		public int AccountNumber { get; set; }
		public string AccountHolderName { get; set; }
		public Double Balance { get; set; }




	    public BankAccount(string AccountHolderName, double Balance)
		{
			this.AccountNumber = ++count;
			this.AccountHolderName = AccountHolderName;
			this.Balance = Balance;
		}
		/*
		public void ShowAccountDetails()
		{
			Console.WriteLine("AccountNumber : {0} - Account Holder-Name: {1} - Balance: {2}", this.AccountNumber, this.AccountHolderName,this.Balance);
		}

		public virtual double WithDraw(double Amount) {
			this.Balance = this.Balance - Amount;
			return this.Balance;
		}

		public virtual double Deposite(double Amount)
		{
			this.Balance = this.Balance + Amount;
			return this.Balance;
		}
		*/
		public abstract double WithDraw(double Amount);
		public abstract double Deposite(double Amount);
		public static void ShowLine()
		{
			Console.WriteLine("========================================");
		}
	}
}
