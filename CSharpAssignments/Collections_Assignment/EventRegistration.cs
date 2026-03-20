using System;
using System.Collections.Generic;
using System.Linq;

namespace EventRegistration
{
    class Program
    {
        static void Main()
        {
            // HashSet to store unique emails
            HashSet<string> emails = new HashSet<string>();

            // Add 10 emails (with duplicates)
            emails.Add("user1@gmail.com");
            emails.Add("user2@gmail.com");
            emails.Add("user3@gmail.com");
            emails.Add("user4@gmail.com");
            emails.Add("user5@gmail.com");
            emails.Add("user1@gmail.com"); // duplicate
            emails.Add("user2@gmail.com"); // duplicate
            emails.Add("user6@gmail.com");
            emails.Add("user7@gmail.com");
            emails.Add("user8@gmail.com");

            // Display unique emails
            Console.WriteLine("---- Unique Registered Emails ----");
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }

            // Check if email exists
            Console.WriteLine("\n---- Check Email ----");
            string checkEmail = "user3@gmail.com";

            if (emails.Contains(checkEmail))
                Console.WriteLine(checkEmail + " is registered.");
            else
                Console.WriteLine(checkEmail + " is NOT registered.");

            // Remove an email
            Console.WriteLine("\n---- Remove Email ----");
            string removeEmail = "user4@gmail.com";

            if (emails.Remove(removeEmail))
                Console.WriteLine(removeEmail + " removed successfully.");
            else
                Console.WriteLine(removeEmail + " not found.");

            Console.WriteLine("\n---- After Removal ----");
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }

            // Bonus: Compare two events
            Console.WriteLine("\n---- Common Participants (Bonus) ----");

            HashSet<string> event1 = new HashSet<string>()
            {
                "a@gmail.com", "b@gmail.com", "c@gmail.com", "d@gmail.com"
            };

            HashSet<string> event2 = new HashSet<string>()
            {
                "c@gmail.com", "d@gmail.com", "e@gmail.com", "f@gmail.com"
            };

            // Find common participants
            event1.IntersectWith(event2);

            foreach (var email in event1)
            {
                Console.WriteLine(email);
            }
        }
    }
}