using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQStudentFiltering
{
    // Student Class
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

        // Constructor
        public Student(int id, string name, int age, int marks)
        {
            Id = id;
            Name = name;
            Age = age;
            Marks = marks;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "Ravi", 20, 85),
                new Student(2, "Anita", 22, 72),
                new Student(3, "Kiran", 19, 90),
                new Student(4, "Sneha", 17, 65),
                new Student(5, "Arjun", 24, 78),
                new Student(6, "Meena", 26, 88)
            };

            // 1. Students with marks > 75
            Console.WriteLine("---- Marks > 75 ----");
            var highMarks = students.Where(s => s.Marks > 75);
            foreach (var s in highMarks)
            {
                Console.WriteLine($"{s.Name} - {s.Marks}");
            }

            // 2. Age between 18 and 25
            Console.WriteLine("\n---- Age between 18 and 25 ----");
            var ageFilter = students.Where(s => s.Age >= 18 && s.Age <= 25);
            foreach (var s in ageFilter)
            {
                Console.WriteLine($"{s.Name} - Age: {s.Age}");
            }

            // 3. Sort by Marks (Descending)
            Console.WriteLine("\n---- Sorted by Marks (Descending) ----");
            var sorted = students.OrderByDescending(s => s.Marks);
            foreach (var s in sorted)
            {
                Console.WriteLine($"{s.Name} - {s.Marks}");
            }

            // 4. Select only Name and Marks
            Console.WriteLine("\n---- Name and Marks ----");
            var selected = students.Select(s => new { s.Name, s.Marks });
            foreach (var s in selected)
            {
                Console.WriteLine($"{s.Name} - {s.Marks}");
            }
        }
    }
}