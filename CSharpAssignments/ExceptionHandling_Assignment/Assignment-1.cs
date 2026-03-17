using System;

// User Defined Exception
public class CheckBalanceException : Exception
{
    public CheckBalanceException(string message) : base(message)
    {
    }
}

// BankAccount Class
public class BankAccount
{
    public int AccountNumber { get; set; }
    public string Name { get; set; }
    public static double Balance = 1000; // initial balance

    // Constructor
    public BankAccount(int accNo, string name)
    {
        AccountNumber = accNo;
        Name = name;
    }

    public void Transaction(char type, double amount)
    {
        if (type == 'd' || type == 'D') // Deposit
        {
            Balance += amount;
            Console.WriteLine("Amount Deposited: " + amount);
        }
        else if (type == 'w' || type == 'W') // Withdraw
        {
            if (Balance - amount < 500)
            {
                throw new CheckBalanceException("Minimum balance of 500 must be maintained!");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Amount Withdrawn: " + amount);
            }
        }
        else
        {
            Console.WriteLine("Invalid Transaction Type");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine("Current Balance: " + Balance);
    }
}

// Main Program
class Program
{
    static void Main()
    {
        try
        {
            BankAccount acc = new BankAccount(101, "Ravi");

            acc.ShowBalance();

            acc.Transaction('w', 600); // valid withdrawal
            acc.ShowBalance();

            acc.Transaction('w', 500); // will cause exception
            acc.ShowBalance();
        }
        catch (CheckBalanceException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Error: " + ex.Message);
        }
    }
}