using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQEmployeeManagement
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

            // 1. Employees from IT department
            Console.WriteLine("---- IT Department Employees ----");
            var itEmployees = employees.Where(e => e.Department == "IT");
            foreach (var e in itEmployees)
            {
                Console.WriteLine($"{e.Name} - {e.Salary}");
            }

            // 2. Highest salary employee
            Console.WriteLine("\n---- Highest Salary Employee ----");
            var maxSalary = employees.Max(e => e.Salary);
            var highestPaid = employees.First(e => e.Salary == maxSalary);
            Console.WriteLine($"{highestPaid.Name} - {highestPaid.Salary}");

            // 3. Average salary
            Console.WriteLine("\n---- Average Salary ----");
            var avgSalary = employees.Average(e => e.Salary);
            Console.WriteLine(avgSalary);

            // 4. Group by Department
            Console.WriteLine("\n---- Group by Department ----");
            var groupDept = employees.GroupBy(e => e.Department);
            foreach (var group in groupDept)
            {
                Console.WriteLine($"\nDepartment: {group.Key}");
                foreach (var e in group)
                {
                    Console.WriteLine($"{e.Name} - {e.Salary}");
                }
            }

            // 5. Count employees in each department
            Console.WriteLine("\n---- Employee Count by Department ----");
            var countDept = employees.GroupBy(e => e.Department)
                                     .Select(g => new { Dept = g.Key, Count = g.Count() });

            foreach (var item in countDept)
            {
                Console.WriteLine($"{item.Dept}: {item.Count}");
            }
        }
    }
}