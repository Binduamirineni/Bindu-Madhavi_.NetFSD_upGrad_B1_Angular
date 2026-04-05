using System;
using Microsoft.Data.SqlClient;

namespace StudentManagementCRUD
{
    class Program
    {
        static string cs = @"Data Source=DESKTOP-3MDBT1A\SQLEXPRESS;Initial Catalog=NewPracticeDb;Integrated Security=True;TrustServerCertificate=True";

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n1. Insert Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Update Student Grade");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InsertStudent();
                        break;
                    case 2:
                        GetStudents();
                        break;
                    case 3:
                        UpdateStudent();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                }

            } while (choice != 5);
        }

        // ✅ INSERT
        static void InsertStudent()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Grade: ");
            string grade = Console.ReadLine();

            string query = "INSERT INTO Students (Name, Age, Grade) VALUES (@Name, @Age, @Grade)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Grade", grade);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("Student Inserted Successfully!");
        }

        // ✅ SELECT
        static void GetStudents()
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM Students";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\n--- Student List ---");

            while (reader.Read())
            {
                Console.WriteLine($"Id:{reader["Id"]} Name:{reader["Name"]} Age:{reader["Age"]} Grade:{reader["Grade"]}");
            }

            con.Close();
        }

        // ✅ UPDATE
        static void UpdateStudent()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Student Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter New Grade: ");
            string grade = Console.ReadLine();

            string query = "UPDATE Students SET Grade=@Grade WHERE Id=@Id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Grade", grade);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            con.Close();

            if (rows > 0)
                Console.WriteLine("Student Updated Successfully!");
            else
                Console.WriteLine("Student Not Found!");
        }

        // ✅ DELETE
        static void DeleteStudent()
        {
            SqlConnection con = new SqlConnection(cs);

            Console.Write("Enter Student Id: ");
            int id = int.Parse(Console.ReadLine());

            string query = "DELETE FROM Students WHERE Id=@Id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            con.Close();

            if (rows > 0)
                Console.WriteLine("Student Deleted Successfully!");
            else
                Console.WriteLine("Student Not Found!");
        }
    }
}