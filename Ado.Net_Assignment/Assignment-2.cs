using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EmployeeSPDemo
{
    class Program
    {
        static string cs = @"Data Source=DESKTOP-3MDBT1A\SQLEXPRESS;Initial Catalog=NewPracticeDb;Integrated Security=True;TrustServerCertificate=True";

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n1. Insert Employee");
                Console.WriteLine("2. Get Employees by Department");
                Console.WriteLine("3. Update Salary");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InsertEmployee();
                        break;
                    case 2:
                        GetEmployeesByDept();
                        break;
                    case 3:
                        UpdateSalary();
                        break;
                    case 4:
                        DeleteEmployee();
                        break;
                }

            } while (choice != 5);
        }

        // ✅ INSERT using Stored Procedure
        static void InsertEmployee()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();

            SqlCommand cmd = new SqlCommand("InsertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@Department", dept);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("Employee Inserted!");
        }

        // ✅ SELECT using Stored Procedure
        static void GetEmployeesByDept()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();

            SqlCommand cmd = new SqlCommand("GetEmployeesByDept", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Department", dept);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\n--- Employees ---");

            while (reader.Read())
            {
                Console.WriteLine($"Id:{reader["EmpId"]} Name:{reader["Name"]} Salary:{reader["Salary"]} Dept:{reader["Department"]}");
            }

            con.Close();
        }

        // ✅ UPDATE using Stored Procedure
        static void UpdateSalary()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Employee Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter New Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("UpdateEmployeeSalary", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmpId", id);
            cmd.Parameters.AddWithValue("@Salary", salary);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            con.Close();

            if (rows > 0)
                Console.WriteLine("Salary Updated!");
            else
                Console.WriteLine("Employee Not Found!");
        }

        // ✅ DELETE using Parameterized Query
        static void DeleteEmployee()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Employee Id: ");
            int id = int.Parse(Console.ReadLine());

            string query = "DELETE FROM Employees WHERE EmpId=@EmpId";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EmpId", id);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            con.Close();

            if (rows > 0)
                Console.WriteLine("Employee Deleted!");
            else
                Console.WriteLine("Employee Not Found!");
        }
    }
}