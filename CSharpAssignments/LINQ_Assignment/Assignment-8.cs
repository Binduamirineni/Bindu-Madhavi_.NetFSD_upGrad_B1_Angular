using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQMultiLevelGrouping
{
    // Student Class
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }

        // Constructor
        public Student(int id, string name, string cls, string subject, int marks)
        {
            Id = id;
            Name = name;
            Class = cls;
            Subject = subject;
            Marks = marks;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "Ravi", "10A", "Maths", 80),
                new Student(2, "Ravi", "10A", "Science", 70),
                new Student(3, "Anita", "10A", "Maths", 90),
                new Student(4, "Anita", "10A", "Science", 85),
                new Student(5, "Kiran", "10B", "Maths", 75),
                new Student(6, "Kiran", "10B", "Science", 65),
                new Student(7, "Sneha", "10B", "Maths", 88),
                new Student(8, "Sneha", "10B", "Science", 92)
            };

            // 1 & 2 & 3: Multi-level grouping + average
            var result = students
                .GroupBy(s => s.Class)
                .Select(classGroup => new
                {
                    Class = classGroup.Key,
                    Subjects = classGroup
                        .GroupBy(s => s.Subject)
                        .Select(subjectGroup => new
                        {
                            Subject = subjectGroup.Key,
                            AverageMarks = subjectGroup.Average(s => s.Marks)
                        })
                });

            // Display
            Console.WriteLine("---- Multi-Level Grouping ----");

            foreach (var cls in result)
            {
                Console.WriteLine($"\nClass: {cls.Class}");

                foreach (var sub in cls.Subjects)
                {
                    Console.WriteLine($"  Subject: {sub.Subject} - Avg Marks: {sub.AverageMarks}");
                }
            }
        }
    }
}