using System;
using System.IO;
using System.Collections.Generic;

namespace EmployeeLogSystem
{
    class Program
    {
        static string filePath = "employee_log.txt";

        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n1. Add Login Entry");
                Console.WriteLine("2. Update Logout Time");
                Console.WriteLine("3. Display Logs");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddLogin();
                        break;
                    case 2:
                        UpdateLogout();
                        break;
                    case 3:
                        DisplayLogs();
                        break;
                }

            } while (choice != 4);
        }

        // Add Login Entry
        static void AddLogin()
        {
            try
            {
                Console.Write("Enter Employee Id: ");
                string id = Console.ReadLine();

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                string loginTime = DateTime.Now.ToString();
                string logoutTime = "NA";

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{id}|{name}|{loginTime}|{logoutTime}");
                }

                Console.WriteLine("Login recorded successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Update Logout Time
        static void UpdateLogout()
        {
            try
            {
                Console.Write("Enter Employee Id to update logout: ");
                string id = Console.ReadLine();

                List<string> lines = new List<string>();

                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] parts = line.Split('|');

                        if (parts[0] == id && parts[3] == "NA")
                        {
                            parts[3] = DateTime.Now.ToString();
                            line = string.Join("|", parts);
                        }

                        lines.Add(line);
                    }
                }

                File.WriteAllLines(filePath, lines);

                Console.WriteLine("Logout time updated!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Display Logs
        static void DisplayLogs()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        Console.WriteLine("\n---- Employee Logs ----");
                        Console.WriteLine(sr.ReadToEnd());
                    }
                }
                else
                {
                    Console.WriteLine("No log file found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}