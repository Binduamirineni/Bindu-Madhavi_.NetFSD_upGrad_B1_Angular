using System;
using System.IO;

namespace MiniNotepad
{
    class Program
    {
        static void Main()
        {
            int choice;
            string fileName;

            do
            {
                Console.WriteLine("\n1. Create New File");
                Console.WriteLine("2. Write to File");
                Console.WriteLine("3. Read File");
                Console.WriteLine("4. Append Text");
                Console.WriteLine("5. Delete File");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                Console.Write("Enter file name (with .txt): ");
                fileName = Console.ReadLine();

                switch (choice)
                {
                    case 1:
                        CreateFile(fileName);
                        break;
                    case 2:
                        WriteFile(fileName);
                        break;
                    case 3:
                        ReadFile(fileName);
                        break;
                    case 4:
                        AppendFile(fileName);
                        break;
                    case 5:
                        DeleteFile(fileName);
                        break;
                }

            } while (choice != 6);
        }

        // Create File
        static void CreateFile(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    FileStream fs = new FileStream(fileName, FileMode.Create);
                    fs.Close();
                    Console.WriteLine("File created successfully!");
                }
                else
                {
                    Console.WriteLine("File already exists.");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Write to File (overwrite)
        static void WriteFile(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.WriteLine("Enter text (type 'exit' to stop):");

                    while (true)
                    {
                        string line = Console.ReadLine();
                        if (line.ToLower() == "exit")
                            break;

                        sw.WriteLine(line);
                    }
                }

                Console.WriteLine("Data written successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Read File
        static void ReadFile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    using (FileStream fs = new FileStream(fileName, FileMode.Open))
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        Console.WriteLine("\n---- File Content ----");
                        Console.WriteLine(sr.ReadToEnd());
                    }
                }
                else
                {
                    Console.WriteLine("File not found!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Append Text
        static void AppendFile(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Append))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.WriteLine("Enter text to append (type 'exit' to stop):");

                    while (true)
                    {
                        string line = Console.ReadLine();
                        if (line.ToLower() == "exit")
                            break;

                        sw.WriteLine(line);
                    }
                }

                Console.WriteLine("Data appended successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Delete File
        static void DeleteFile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                    Console.WriteLine("File deleted successfully!");
                }
                else
                {
                    Console.WriteLine("File not found!");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}