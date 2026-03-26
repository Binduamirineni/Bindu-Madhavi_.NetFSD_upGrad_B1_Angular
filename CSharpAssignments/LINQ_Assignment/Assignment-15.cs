using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDashboard
{
    // Employee Class
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }

        // Constructor
        public Employee(int id, string name, string dept, double salary, DateTime joiningDate)
        {
            Id = id;
            Name = name;
            Department = dept;
            Salary = salary;
            JoiningDate = joiningDate;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1, "Ravi", "IT", 50000, DateTime.Now.AddMonths(-2)),
                new Employee(2, "Anita", "HR", 40000, DateTime.Now.AddMonths(-8)),
                new Employee(3, "Kiran", "IT", 70000, DateTime.Now.AddMonths(-1)),
                new Employee(4, "Sneha", "Finance", 60000, DateTime.Now.AddMonths(-12)),
                new Employee(5, "Arjun", "HR", 45000, DateTime.Now.AddMonths(-3)),
                new Employee(6, "Meena", "IT", 65000, DateTime.Now.AddMonths(-5))
            };

            // 1. Total employees
            Console.WriteLine("---- Total Employees ----");
            Console.WriteLine(employees.Count());

            // 2. Department-wise average salary
            Console.WriteLine("\n---- Avg Salary by Department ----");
            var avgSalaryDept = employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    AvgSalary = g.Average(e => e.Salary)
                });

            foreach (var item in avgSalaryDept)
            {
                Console.WriteLine($"{item.Department} - {item.AvgSalary}");
            }

            // 3. Recently joined employees (last 6 months)
            Console.WriteLine("\n---- Recently Joined (Last 6 Months) ----");
            var recent = employees
                .Where(e => e.JoiningDate >= DateTime.Now.AddMonths(-6));

            foreach (var e in recent)
            {
                Console.WriteLine($"{e.Name} - {e.JoiningDate.ToShortDateString()}");
            }

            // 4. Highest paid employee per department
            Console.WriteLine("\n---- Highest Paid per Department ----");
            var highestPerDept = employees
                .GroupBy(e => e.Department)
                .Select(g => g.OrderByDescending(e => e.Salary).First());

            foreach (var e in highestPerDept)
            {
                Console.WriteLine($"{e.Department} - {e.Name} - {e.Salary}");
            }

            // 5. Salary distribution
            Console.WriteLine("\n---- Salary Distribution ----");
            var minSalary = employees.Min(e => e.Salary);
            var maxSalary = employees.Max(e => e.Salary);
            var avgSalary = employees.Average(e => e.Salary);

            Console.WriteLine($"Min: {minSalary}");
            Console.WriteLine($"Max: {maxSalary}");
            Console.WriteLine($"Avg: {avgSalary}");
        }
    }
}