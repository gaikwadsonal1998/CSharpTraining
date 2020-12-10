using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMiniCaseStudyOOP
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			BankAccount.ShowLine();
			BankAccount bankAccount = new BankAccount("Sonal",10000);
			bankAccount.ShowAccountDetails();
			Console.WriteLine("Balance after withdrawing rs.500 is: {0}",bankAccount.WithDraw(500));
			Console.WriteLine("Balance after Depositing rs.500 is: {0}", bankAccount.Deposite(500));


			Console.WriteLine();

			BankAccount bankAccount2 = new BankAccount("Prajakta", 50000);
			bankAccount2.ShowAccountDetails();
			Console.WriteLine("Balance after withdrawing rs.1500 is: {0}", bankAccount2.WithDraw(1500));
			Console.WriteLine("Balance after Depositing rs.2500 is: {0}", bankAccount2.Deposite(2500));
			BankAccount.ShowLine();
			*/
			/*
			SavingsAccount savingAccount = new SavingsAccount("Saving","Sonal",10000);
			savingAccount.ShowAccountDetails();
			savingAccount.WithDraw(20000);
			savingAccount.Deposite(10000);
			*/

			CurrentAccount currentAccount = new CurrentAccount("current account","sonal",14000);
			
			Console.WriteLine("Balance after Withdrawing 25000 is :{0}", currentAccount.WithDraw(25000));
			Console.WriteLine("Balance after Depositing 30000 is :{0}", currentAccount.Deposite(30000));
		}
	}
}
