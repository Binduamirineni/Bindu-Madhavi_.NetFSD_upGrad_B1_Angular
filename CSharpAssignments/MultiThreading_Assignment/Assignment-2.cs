using System;
using System.Threading;

namespace BankWithLock
{
    class BankAccount
    {
        public int Balance = 1000;
        private object lockObj = new object();

        public void Withdraw(int amount)
        {
            lock (lockObj) // 🔐 critical section
            {
                if (Balance >= amount)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} is withdrawing {amount}");

                    Thread.Sleep(500); // simulate delay

                    Balance -= amount;

                    Console.WriteLine($"{Thread.CurrentThread.Name} completed withdrawal. Remaining: {Balance}");
                }
                else
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} - Insufficient Balance!");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount();

            Thread t1 = new Thread(() => account.Withdraw(800)) { Name = "User1" };
            Thread t2 = new Thread(() => account.Withdraw(500)) { Name = "User2" };
            Thread t3 = new Thread(() => account.Withdraw(300)) { Name = "User3" };

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine($"\nFinal Balance: {account.Balance}");
        }
    }
}