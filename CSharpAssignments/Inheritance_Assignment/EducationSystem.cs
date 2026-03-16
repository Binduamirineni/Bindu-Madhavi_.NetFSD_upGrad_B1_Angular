using System;
using System.Collections.Generic;
using System.Text;

namespace EducationSystem
{
    // Base Class
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        // Constructor
        public Student(int id, string name, int marks)
        {
            StudentId = id;
            Name = name;
            Marks = marks;
        }

        // Virtual Method
        public virtual void CalculateGrade()
        {
            if (Marks > 50)
                Console.WriteLine(Name + " : Pass");
            else
                Console.WriteLine(Name + " : Fail");
        }
    }

    // School Student
    public class SchoolStudent : Student
    {
        public SchoolStudent(int id, string name, int marks) : base(id, name, marks)
        {
        }

        public override void CalculateGrade()
        {
            if (Marks > 40)
                Console.WriteLine(Name + " (School Student) : Pass");
            else
                Console.WriteLine(Name + " (School Student) : Fail");
        }
    }

    // College Student
    public class CollegeStudent : Student
    {
        public CollegeStudent(int id, string name, int marks) : base(id, name, marks)
        {
        }

        public override void CalculateGrade()
        {
            if (Marks > 50)
                Console.WriteLine(Name + " (College Student) : Pass");
            else
                Console.WriteLine(Name + " (College Student) : Fail");
        }
    }

    // Online Student
    public class OnlineStudent : Student
    {
        public OnlineStudent(int id, string name, int marks) : base(id, name, marks)
        {
        }

        public override void CalculateGrade()
        {
            if (Marks > 60)
                Console.WriteLine(Name + " (Online Student) : Pass");
            else
                Console.WriteLine(Name + " (Online Student) : Fail");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism
            Student[] students = new Student[3];

            students[0] = new SchoolStudent(1, "Ravi", 45);
            students[1] = new CollegeStudent(2, "Anita", 55);
            students[2] = new OnlineStudent(3, "Rahul", 58);

            foreach (Student s in students)
            {
                s.CalculateGrade();
            }
        }
    }
}