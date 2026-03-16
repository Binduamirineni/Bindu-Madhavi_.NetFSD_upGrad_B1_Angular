using System;

namespace C__Basic_Assignments1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise_1 obj = new Exercise_1();
            obj.Divided();

            Console.ReadLine();
        }
    }
}
    internal class Exercise_1
    {
        public void Divided()
        {
            Console.WriteLine("Enter First value:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second value:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b != 0)
            {
                Console.WriteLine("Quotient: " + (a / b));
            }
            else
            {
                Console.WriteLine("Second number should not be zero");
            }
        }
    }
