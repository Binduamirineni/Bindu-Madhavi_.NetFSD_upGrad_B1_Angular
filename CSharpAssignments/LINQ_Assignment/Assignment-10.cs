using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQCustomSorting
{
    // Employee Class
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        // Constructor
        public Employee(int id, string name, string dept, double salary)
        {
            Id = id;
            Name = name;
            Department = dept;
            Salary = salary;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1, "Ravi", "IT", 50000),
                new Employee(2, "Anita", "HR", 40000),
                new Employee(3, "Kiran", "IT", 70000),
                new Employee(4, "Sneha", "Finance", 60000),
                new Employee(5, "Arjun", "HR", 45000),
                new Employee(6, "Meena", "IT", 65000)
            };

            // Custom Sorting
            var sortedEmployees = employees
                .OrderBy(e => e.Department)          // 1. Department ASC
                .ThenByDescending(e => e.Salary);   // 2. Salary DESC

            Console.WriteLine("---- Sorted Employees ----");

            foreach (var e in sortedEmployees)
            {
                Console.WriteLine($"{e.Department} - {e.Name} - {e.Salary}");
            }
        }
    }
}
