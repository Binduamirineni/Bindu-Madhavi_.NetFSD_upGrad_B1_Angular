using System;

// Custom Exception
public class TicketException : Exception
{
    public TicketException(string message) : base(message)
    {
    }
}

class TicketBookingApp   // ✅ Renamed class (fix)
{
    static void Main()
    {
        int availableTickets = 15;

        try
        {
            Console.Write("Do you want to book tickets? (yes/no): ");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "yes")
            {
                Console.Write("Enter number of tickets: ");
                int tickets = Convert.ToInt32(Console.ReadLine());

                if (tickets > availableTickets)
                {
                    throw new TicketException("Requested tickets exceed available tickets!");
                }

                availableTickets -= tickets;

                Console.WriteLine("Tickets booked successfully!");
                Console.WriteLine("Remaining Tickets: " + availableTickets);
            }
            else
            {
                Console.WriteLine("Thank you!");
            }
        }
        catch (TicketException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}