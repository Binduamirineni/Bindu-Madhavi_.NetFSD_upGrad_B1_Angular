using System;
using System.IO;

namespace StudentReportCard
{
    class Program
    {
        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n1. Generate Report Card");
                Console.WriteLine("2. View Report Card");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        GenerateReport();
                        break;
                    case 2:
                        ViewReport();
                        break;
                }

            } while (choice != 3);
        }

        // Generate Report Card
        static void GenerateReport()
        {
            try
            {
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Roll Number: ");
                string roll = Console.ReadLine();

                int m1 = GetMarks("Enter Marks for Subject 1: ");
                int m2 = GetMarks("Enter Marks for Subject 2: ");
                int m3 = GetMarks("Enter Marks for Subject 3: ");

                int total = m1 + m2 + m3;
                double avg = total / 3.0;
                string grade = GetGrade(avg);

                string content =
$@"Student Name: {name}
Roll Number: {roll}
Marks: {m1}, {m2}, {m3}
Total: {total}
Average: {avg}
Grade: {grade}";

                File.WriteAllText($"{roll}.txt", content);

                Console.WriteLine("Report card generated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // View Report Card
        static void ViewReport()
        {
            try
            {
                Console.Write("Enter Roll Number: ");
                string roll = Console.ReadLine();

                string file = $"{roll}.txt";

                if (File.Exists(file))
                {
                    string data = File.ReadAllText(file);
                    Console.WriteLine("\n---- Report Card ----");
                    Console.WriteLine(data);
                }
                else
                {
                    Console.WriteLine("Report not found!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Marks Validation
        static int GetMarks(string message)
        {
            int marks;

            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out marks) && marks >= 0 && marks <= 100)
                    return marks;

                Console.WriteLine("Invalid marks! Enter between 0 and 100.");
            }
        }

        // Grade Calculation
        static string GetGrade(double avg)
        {
            if (avg >= 75)
                return "A";
            else if (avg >= 60)
                return "B";
            else if (avg >= 50)
                return "C";
            else
                return "Fail";
        }
    }
}