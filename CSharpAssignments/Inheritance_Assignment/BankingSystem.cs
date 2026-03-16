using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public Account(int accNo, double balance)
        {
            AccountNumber = accNo;
            Balance = balance;
        }

        public void CalculateInterest()
        {
            Console.WriteLine("Base account interest calculation");
        }
    }

    public class SavingsAccount : Account
    {
        public SavingsAccount(int accNo, double balance)
            : base(accNo, balance)
        {
        }

        public new void CalculateInterest()
        {
            Console.WriteLine("Savings Account Interest Calculation");
        }
    }

    public class CurrentAccount : Account
    {
        public CurrentAccount(int accNo, double balance)
            : base(accNo, balance)
        {
        }

        public new void CalculateInterest()
        {
            Console.WriteLine("Current Account Interest Calculation");
        }
    }

    class Program
    {
        static void Main()
        {
            Account acc = new SavingsAccount(101, 10000);
            acc.CalculateInterest();

            SavingsAccount sa = new SavingsAccount(102, 15000);
            sa.CalculateInterest();
        }
    }
}