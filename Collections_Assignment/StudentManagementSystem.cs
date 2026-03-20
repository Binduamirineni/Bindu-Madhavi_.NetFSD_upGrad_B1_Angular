using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem
{
    // Student Class
    public class Student
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        // Constructor
        public Student(int id, string name, int marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }
    }

    class Program
    {
        static void Main()
        {
            // Dictionary to store students
            Dictionary<int, Student> students = new Dictionary<int, Student>();

            // Add 5 students
            students.Add(1, new Student(1, "Ravi", 85));
            students.Add(2, new Student(2, "Anita", 72));
            students.Add(3, new Student(3, "Kiran", 90));
            students.Add(4, new Student(4, "Sneha", 65));
            students.Add(5, new Student(5, "Arjun", 78));

            Console.WriteLine("---- All Students ----");
            Display(students);

            // Retrieve student by Id
            Console.WriteLine("\n---- Retrieve Student with Id = 3 ----");
            if (students.ContainsKey(3))
            {
                var s = students[3];
                Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Marks: {s.Marks}");
            }

            // Check existence
            Console.WriteLine("\n---- Check Student Exists (Id = 2) ----");
            Console.WriteLine(students.ContainsKey(2) ? "Student Exists" : "Not Found");

            // Update marks
            Console.WriteLine("\n---- Update Marks (Id = 2) ----");
            if (students.ContainsKey(2))
            {
                students[2].Marks = 80;
                Console.WriteLine("Marks updated!");
            }

            // Remove student
            Console.WriteLine("\n---- Remove Student (Id = 4) ----");
            students.Remove(4);
            Console.WriteLine("Student removed!");

            Console.WriteLine("\n---- After Updates ----");
            Display(students);

            // Bonus: Marks > 75
            Console.WriteLine("\n---- Students with Marks > 75 ----");
            var topStudents = students.Values.Where(s => s.Marks > 75);
            foreach (var s in topStudents)
            {
                Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Marks: {s.Marks}");
            }
        }

        // Display Method
        static void Display(Dictionary<int, Student> students)
        {
            foreach (var kvp in students)
            {
                var s = kvp.Value;
                Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Marks: {s.Marks}");
            }
        }
    }
}