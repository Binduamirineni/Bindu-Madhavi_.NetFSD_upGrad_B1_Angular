using System;

// Interface
interface ISales
{
    double YearlySales();
}

// Abstract Class
abstract class Sales
{
    // Non-abstract method
    public double DailySales()
    {
        return 400;
    }

    // Abstract method
    public abstract double MonthlySales(double dailySales);
}

// Main Class
class SalesCalculation : Sales, ISales
{
    public override double MonthlySales(double dailySales)
    {
        return dailySales * 30;
    }

    public double YearlySales()
    {
        return 400 * 30 * 12;
    }

    static void Main()
    {
        SalesCalculation obj = new SalesCalculation();

        double daily = obj.DailySales();
        double monthly = obj.MonthlySales(daily);
        double yearly = obj.YearlySales();

        Console.WriteLine("Daily sales: Rs." + daily);
        Console.WriteLine("Monthly sales: Rs." + monthly);
        Console.WriteLine("Annual sales: Rs." + yearly);
    }
}